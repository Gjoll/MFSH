using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Dfa;
using Antlr4.Runtime.Tree;
using MFSH;
using Microsoft.VisualBasic.CompilerServices;

namespace MFSH
{
    class MFSHVisitor : MFSHParserBaseVisitor<Object>
    {
        public bool DebugFlag { get; set; } = false;

        public Stack<ParseInfo> state = new Stack<ParseInfo>();
        ParseInfo Current => this.state.Peek();
        public String[] InputLines;
        public string SourceName;
        MFsh mfsh;

        void PushState(ParseInfo s)
        {
            this.state.Push(s);
        }

        ParseInfo PopState()
        {
            ParseInfo s = this.state.Peek();
            this.state.Pop();
            return s;
        }
        public StringBuilder ParsedText => this.Current.ParsedText;

        public MFSHVisitor(MFsh mfsh,
            string sourceName)
        {
            this.SourceName = sourceName;
            this.mfsh = mfsh;
            this.PushState(new ParseInfo());
        }

        void TraceMsg(ParserRuleContext context, String fcn)
        {
            if (!DebugFlag)
                return;
            String text = context.GetText().Replace("\r", "").Replace("\n", "");
            Trace.WriteLine($"{fcn}. [{this.state.Count}] {this.SourceName}, #{context.Start.Line} '{text}'");
        }

        public override object VisitDocument(MFSHParser.DocumentContext context)
        {
            const String fcn = "VisitDocument";
            TraceMsg(context, fcn);
            this.VisitChildren(context);
            return null;
        }

        public override object VisitMUse(MFSHParser.MUseContext context)
        {
            const String fcn = "VisitMuse";
            TraceMsg(context, fcn);
            String include = context.MSTRING().GetText();
            include = include.Substring(1, include.Length - 2);
            ProcessInclude(include);
            return null;
        }

        public override object VisitMInclude(MFSHParser.MIncludeContext context)
        {
            const String fcn = "VisitMInclude";
            TraceMsg(context, fcn);
            String include = context.MSTRING().GetText();
            include = include.Substring(1, include.Length - 2);
            String text = ProcessInclude(include);
            if (text == null)
                return null;
            if (text.Length == 0)
                return null;
            if (text[^1] != '\n')
                text += '\n';
            this.ParsedText.Append(text);
            return null;
        }

        public override object VisitMMacro(MFSHParser.MMacroContext context)
        {
            const String fcn = "VisitMMacro";
            TraceMsg(context, fcn);

            DefineInfo s = new DefineInfo();
            this.PushState(s);
            String[] names = context
                .MPNAME()
                .Select((a) => a.GetText())
                .ToArray();
            s.Name = names[0];
            s.Parameters.AddRange(names.Skip(1));
            return null;
        }

        public override object VisitMApply(MFSHParser.MApplyContext context)
        {
            const String fcn = "VisitMApply";
            TraceMsg(context, fcn);

            String macroName = context.MPNAME().GetText();
            String[] parameters = context
                .mString()
                .Select((a) =>
                {
                    String s = a.GetText();
                    return s.Substring(1, s.Length - 2);
                })
                .ToArray();

            if (this.mfsh.Defines.TryGetValue(macroName, out DefineInfo info) == false)
            {
                this.Error(fcn,
                    context.Start,
                    $"Macro {macroName} not found.");
                return null;
            }

            if (info.Parameters.Count != parameters.Length)
            {
                this.Error(fcn,
                    context.Start,
                    $"Macro {macroName} requires {info.Parameters.Count} parameters, but only {parameters.Length} supplied.");
                return null;
            }

            string text = info.ParsedText.ToString();
            for (Int32 i = 0; i < info.Parameters.Count; i++)
            {
                // Replace occurances of macro parameter.
                // Replacement is done on word boundaries ('\b');
                String word = info.Parameters[i];
                String byWhat = parameters[i];
                text = ReplaceWholeWord(text, word, byWhat);
            }

            this.Current.ParsedText.Append(text);
            return null;
        }

        public override object VisitMEnd(MFSHParser.MEndContext context)
        {
            const String fcn = "VisitMEnd";
            TraceMsg(context, fcn);

            ParseInfo s = this.PopState();
            switch (s)
            {
                case DefineInfo defineInfo:
                    this.mfsh.Defines.Add(defineInfo.Name, defineInfo);
                    break;

                default:
                    Error(fcn, 
                        context.Start,
                        $"Unexpected '#end'");
                    break;
            }
            return null;
        }

        public override object VisitMModeEnd(MFSHParser.MModeEndContext context)
        {
            const String fcn = "VisitMModeEnd";
            TraceMsg(context, fcn);

            String s = context.GetText();
            this.ParsedText.Append(s.Substring(1));
            return null;
        }

        public override object VisitFsh(MFSHParser.FshContext context)
        {
            const String fcn = "VisitFsh";
            TraceMsg(context, fcn);

            this.ParsedText.Append(context.GetText());
            return null;
        }

        String FindInclude(String includeFile)
        {
            if (Path.IsPathRooted(includeFile))
            {
                if (File.Exists(includeFile) == true)
                    return includeFile;
            }
            else
            {
                foreach (String dir in this.mfsh.IncludeDirs)
                {
                    String path = Path.Combine(dir, includeFile);
                    if (File.Exists(path))
                        return path;
                }
            }

            throw new Exception($"Include file '{includeFile}' does not exist");
        }

        String ProcessInclude(String includeFile)
        {
            String includePath = this.FindInclude(includeFile);
            if (this.mfsh.Includes.Contains(includeFile))
                return null;

            this.mfsh.Includes.Add(includeFile);
            String fshText = File.ReadAllText(includePath);

            string includeFileText = this.mfsh.SubParse(fshText, includeFile);
            return includeFileText;
        }

        public String ReplaceWholeWord(String s, String wordToReplace, String bywhat)
        {
            bool IsBreakChar(char c)
            {
                if (Char.IsLetterOrDigit(c))
                    return false;
                if (c == '$')
                    return false;
                if (c == '%')
                    return false;
                return true;
            }
            StringBuilder sb = new StringBuilder();
            Int32 i = 0;
            Int32 length = s.Length;
            void SkipLeading()
            {
                while (i < length)
                {
                    Char c = s[i];
                    if (IsBreakChar(c) == false)
                        return;
                    sb.Append(c);
                    i += 1;
                }
            }

            String GetWholeWord()
            {
                StringBuilder w = new StringBuilder();
                while (i < length)
                {
                    Char c = s[i];
                    if (IsBreakChar(c) == true)
                        break;
                    w.Append(c);
                    i += 1;
                }
                return w.ToString();
            }

            while (i < length)
            {
                SkipLeading();
                String wholeWord = GetWholeWord();
                if (String.Compare(wholeWord, wordToReplace, StringComparison.Ordinal) == 0)
                    sb.Append(bywhat);
                else
                    sb.Append(wholeWord);
            }
            return sb.ToString();
        }

        void Error(String fcn,
            IToken start,
            String msg)
        {
            String fullMsg = $"{this.SourceName}, line {start.Line}. {msg}";
            this.mfsh.ConversionError("mfsh", fcn, fullMsg);
        }
    }
}
