//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from MFSHParser.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace MFSH.Parser {
using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class MFSHParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		APPLY=1, END=2, FSHLINE=3, INCLUDE=4, JSONARRAY=5, MACRO=6, PROFILE=7, 
		USE=8, STRING=9, MULTILINE_STRING=10, OPAR=11, COMMA=12, CPAR=13, GT=14, 
		NAME=15, WS=16;
	public const int
		RULE_document = 0, RULE_command = 1, RULE_fshLine = 2, RULE_apply = 3, 
		RULE_end = 4, RULE_include = 5, RULE_macro = 6, RULE_profile = 7, RULE_redirect = 8, 
		RULE_use = 9, RULE_anyString = 10, RULE_multiLineString = 11, RULE_singleString = 12;
	public static readonly string[] ruleNames = {
		"document", "command", "fshLine", "apply", "end", "include", "macro", 
		"profile", "redirect", "use", "anyString", "multiLineString", "singleString"
	};

	private static readonly string[] _LiteralNames = {
		null, "'apply'", "'end'", "'FshLine'", "'include'", "'jsonArray'", "'macro'", 
		"'profile'", "'use'", null, null, "'('", "','", "')'", "'>'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "APPLY", "END", "FSHLINE", "INCLUDE", "JSONARRAY", "MACRO", "PROFILE", 
		"USE", "STRING", "MULTILINE_STRING", "OPAR", "COMMA", "CPAR", "GT", "NAME", 
		"WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "MFSHParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static MFSHParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public MFSHParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public MFSHParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class DocumentContext : ParserRuleContext {
		public ITerminalNode Eof() { return GetToken(MFSHParser.Eof, 0); }
		public CommandContext[] command() {
			return GetRuleContexts<CommandContext>();
		}
		public CommandContext command(int i) {
			return GetRuleContext<CommandContext>(i);
		}
		public DocumentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_document; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDocument(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DocumentContext document() {
		DocumentContext _localctx = new DocumentContext(Context, State);
		EnterRule(_localctx, 0, RULE_document);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 29;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << APPLY) | (1L << END) | (1L << FSHLINE) | (1L << INCLUDE) | (1L << MACRO) | (1L << PROFILE) | (1L << USE))) != 0)) {
				{
				{
				State = 26; command();
				}
				}
				State = 31;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 32; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CommandContext : ParserRuleContext {
		public FshLineContext fshLine() {
			return GetRuleContext<FshLineContext>(0);
		}
		public ApplyContext apply() {
			return GetRuleContext<ApplyContext>(0);
		}
		public EndContext end() {
			return GetRuleContext<EndContext>(0);
		}
		public IncludeContext include() {
			return GetRuleContext<IncludeContext>(0);
		}
		public MacroContext macro() {
			return GetRuleContext<MacroContext>(0);
		}
		public ProfileContext profile() {
			return GetRuleContext<ProfileContext>(0);
		}
		public UseContext use() {
			return GetRuleContext<UseContext>(0);
		}
		public CommandContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_command; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCommand(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CommandContext command() {
		CommandContext _localctx = new CommandContext(Context, State);
		EnterRule(_localctx, 2, RULE_command);
		try {
			State = 41;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case FSHLINE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 34; fshLine();
				}
				break;
			case APPLY:
				EnterOuterAlt(_localctx, 2);
				{
				State = 35; apply();
				}
				break;
			case END:
				EnterOuterAlt(_localctx, 3);
				{
				State = 36; end();
				}
				break;
			case INCLUDE:
				EnterOuterAlt(_localctx, 4);
				{
				State = 37; include();
				}
				break;
			case MACRO:
				EnterOuterAlt(_localctx, 5);
				{
				State = 38; macro();
				}
				break;
			case PROFILE:
				EnterOuterAlt(_localctx, 6);
				{
				State = 39; profile();
				}
				break;
			case USE:
				EnterOuterAlt(_localctx, 7);
				{
				State = 40; use();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FshLineContext : ParserRuleContext {
		public ITerminalNode FSHLINE() { return GetToken(MFSHParser.FSHLINE, 0); }
		public AnyStringContext anyString() {
			return GetRuleContext<AnyStringContext>(0);
		}
		public FshLineContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fshLine; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFshLine(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FshLineContext fshLine() {
		FshLineContext _localctx = new FshLineContext(Context, State);
		EnterRule(_localctx, 4, RULE_fshLine);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 43; Match(FSHLINE);
			State = 44; anyString();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ApplyContext : ParserRuleContext {
		public ITerminalNode APPLY() { return GetToken(MFSHParser.APPLY, 0); }
		public ITerminalNode NAME() { return GetToken(MFSHParser.NAME, 0); }
		public ITerminalNode OPAR() { return GetToken(MFSHParser.OPAR, 0); }
		public ITerminalNode CPAR() { return GetToken(MFSHParser.CPAR, 0); }
		public AnyStringContext[] anyString() {
			return GetRuleContexts<AnyStringContext>();
		}
		public AnyStringContext anyString(int i) {
			return GetRuleContext<AnyStringContext>(i);
		}
		public ITerminalNode[] COMMA() { return GetTokens(MFSHParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(MFSHParser.COMMA, i);
		}
		public ApplyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_apply; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitApply(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ApplyContext apply() {
		ApplyContext _localctx = new ApplyContext(Context, State);
		EnterRule(_localctx, 6, RULE_apply);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 46; Match(APPLY);
			State = 47; Match(NAME);
			State = 48; Match(OPAR);
			State = 57;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==STRING || _la==MULTILINE_STRING) {
				{
				State = 49; anyString();
				State = 54;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 50; Match(COMMA);
					State = 51; anyString();
					}
					}
					State = 56;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
			}

			State = 59; Match(CPAR);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EndContext : ParserRuleContext {
		public ITerminalNode END() { return GetToken(MFSHParser.END, 0); }
		public EndContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_end; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitEnd(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public EndContext end() {
		EndContext _localctx = new EndContext(Context, State);
		EnterRule(_localctx, 8, RULE_end);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 61; Match(END);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IncludeContext : ParserRuleContext {
		public ITerminalNode INCLUDE() { return GetToken(MFSHParser.INCLUDE, 0); }
		public AnyStringContext anyString() {
			return GetRuleContext<AnyStringContext>(0);
		}
		public IncludeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_include; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInclude(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IncludeContext include() {
		IncludeContext _localctx = new IncludeContext(Context, State);
		EnterRule(_localctx, 10, RULE_include);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 63; Match(INCLUDE);
			State = 64; anyString();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MacroContext : ParserRuleContext {
		public ITerminalNode MACRO() { return GetToken(MFSHParser.MACRO, 0); }
		public ITerminalNode[] NAME() { return GetTokens(MFSHParser.NAME); }
		public ITerminalNode NAME(int i) {
			return GetToken(MFSHParser.NAME, i);
		}
		public ITerminalNode OPAR() { return GetToken(MFSHParser.OPAR, 0); }
		public ITerminalNode CPAR() { return GetToken(MFSHParser.CPAR, 0); }
		public RedirectContext redirect() {
			return GetRuleContext<RedirectContext>(0);
		}
		public ITerminalNode[] COMMA() { return GetTokens(MFSHParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(MFSHParser.COMMA, i);
		}
		public MacroContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_macro; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMacro(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MacroContext macro() {
		MacroContext _localctx = new MacroContext(Context, State);
		EnterRule(_localctx, 12, RULE_macro);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 66; Match(MACRO);
			State = 67; Match(NAME);
			State = 68; Match(OPAR);
			State = 77;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==NAME) {
				{
				State = 69; Match(NAME);
				State = 74;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 70; Match(COMMA);
					State = 71; Match(NAME);
					}
					}
					State = 76;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
			}

			State = 79; Match(CPAR);
			State = 81;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==GT) {
				{
				State = 80; redirect();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ProfileContext : ParserRuleContext {
		public ITerminalNode PROFILE() { return GetToken(MFSHParser.PROFILE, 0); }
		public ITerminalNode NAME() { return GetToken(MFSHParser.NAME, 0); }
		public ProfileContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_profile; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProfile(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProfileContext profile() {
		ProfileContext _localctx = new ProfileContext(Context, State);
		EnterRule(_localctx, 14, RULE_profile);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 83; Match(PROFILE);
			State = 84; Match(NAME);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class RedirectContext : ParserRuleContext {
		public ITerminalNode GT() { return GetToken(MFSHParser.GT, 0); }
		public ITerminalNode JSONARRAY() { return GetToken(MFSHParser.JSONARRAY, 0); }
		public ITerminalNode OPAR() { return GetToken(MFSHParser.OPAR, 0); }
		public SingleStringContext singleString() {
			return GetRuleContext<SingleStringContext>(0);
		}
		public ITerminalNode CPAR() { return GetToken(MFSHParser.CPAR, 0); }
		public RedirectContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_redirect; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRedirect(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public RedirectContext redirect() {
		RedirectContext _localctx = new RedirectContext(Context, State);
		EnterRule(_localctx, 16, RULE_redirect);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 86; Match(GT);
			State = 87; Match(JSONARRAY);
			State = 88; Match(OPAR);
			State = 89; singleString();
			State = 90; Match(CPAR);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class UseContext : ParserRuleContext {
		public ITerminalNode USE() { return GetToken(MFSHParser.USE, 0); }
		public AnyStringContext anyString() {
			return GetRuleContext<AnyStringContext>(0);
		}
		public UseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_use; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUse(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public UseContext use() {
		UseContext _localctx = new UseContext(Context, State);
		EnterRule(_localctx, 18, RULE_use);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 92; Match(USE);
			State = 93; anyString();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AnyStringContext : ParserRuleContext {
		public SingleStringContext singleString() {
			return GetRuleContext<SingleStringContext>(0);
		}
		public MultiLineStringContext multiLineString() {
			return GetRuleContext<MultiLineStringContext>(0);
		}
		public AnyStringContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_anyString; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAnyString(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AnyStringContext anyString() {
		AnyStringContext _localctx = new AnyStringContext(Context, State);
		EnterRule(_localctx, 20, RULE_anyString);
		try {
			State = 97;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case STRING:
				EnterOuterAlt(_localctx, 1);
				{
				State = 95; singleString();
				}
				break;
			case MULTILINE_STRING:
				EnterOuterAlt(_localctx, 2);
				{
				State = 96; multiLineString();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MultiLineStringContext : ParserRuleContext {
		public ITerminalNode MULTILINE_STRING() { return GetToken(MFSHParser.MULTILINE_STRING, 0); }
		public MultiLineStringContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_multiLineString; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMultiLineString(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MultiLineStringContext multiLineString() {
		MultiLineStringContext _localctx = new MultiLineStringContext(Context, State);
		EnterRule(_localctx, 22, RULE_multiLineString);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 99; Match(MULTILINE_STRING);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SingleStringContext : ParserRuleContext {
		public ITerminalNode STRING() { return GetToken(MFSHParser.STRING, 0); }
		public SingleStringContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_singleString; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSingleString(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SingleStringContext singleString() {
		SingleStringContext _localctx = new SingleStringContext(Context, State);
		EnterRule(_localctx, 24, RULE_singleString);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 101; Match(STRING);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x12', 'j', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', '\v', 
		'\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', '\t', 
		'\xE', '\x3', '\x2', '\a', '\x2', '\x1E', '\n', '\x2', '\f', '\x2', '\xE', 
		'\x2', '!', '\v', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x5', '\x3', ',', '\n', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\a', '\x5', '\x37', '\n', '\x5', '\f', '\x5', '\xE', 
		'\x5', ':', '\v', '\x5', '\x5', '\x5', '<', '\n', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\a', '\b', 'K', '\n', '\b', '\f', '\b', '\xE', '\b', 'N', 
		'\v', '\b', '\x5', '\b', 'P', '\n', '\b', '\x3', '\b', '\x3', '\b', '\x5', 
		'\b', 'T', '\n', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x5', '\f', 
		'\x64', '\n', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x2', '\x2', '\xF', '\x2', '\x4', '\x6', '\b', '\n', '\f', 
		'\xE', '\x10', '\x12', '\x14', '\x16', '\x18', '\x1A', '\x2', '\x2', '\x2', 
		'i', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x4', '+', '\x3', '\x2', 
		'\x2', '\x2', '\x6', '-', '\x3', '\x2', '\x2', '\x2', '\b', '\x30', '\x3', 
		'\x2', '\x2', '\x2', '\n', '?', '\x3', '\x2', '\x2', '\x2', '\f', '\x41', 
		'\x3', '\x2', '\x2', '\x2', '\xE', '\x44', '\x3', '\x2', '\x2', '\x2', 
		'\x10', 'U', '\x3', '\x2', '\x2', '\x2', '\x12', 'X', '\x3', '\x2', '\x2', 
		'\x2', '\x14', '^', '\x3', '\x2', '\x2', '\x2', '\x16', '\x63', '\x3', 
		'\x2', '\x2', '\x2', '\x18', '\x65', '\x3', '\x2', '\x2', '\x2', '\x1A', 
		'g', '\x3', '\x2', '\x2', '\x2', '\x1C', '\x1E', '\x5', '\x4', '\x3', 
		'\x2', '\x1D', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x1E', '!', '\x3', 
		'\x2', '\x2', '\x2', '\x1F', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x1F', 
		' ', '\x3', '\x2', '\x2', '\x2', ' ', '\"', '\x3', '\x2', '\x2', '\x2', 
		'!', '\x1F', '\x3', '\x2', '\x2', '\x2', '\"', '#', '\a', '\x2', '\x2', 
		'\x3', '#', '\x3', '\x3', '\x2', '\x2', '\x2', '$', ',', '\x5', '\x6', 
		'\x4', '\x2', '%', ',', '\x5', '\b', '\x5', '\x2', '&', ',', '\x5', '\n', 
		'\x6', '\x2', '\'', ',', '\x5', '\f', '\a', '\x2', '(', ',', '\x5', '\xE', 
		'\b', '\x2', ')', ',', '\x5', '\x10', '\t', '\x2', '*', ',', '\x5', '\x14', 
		'\v', '\x2', '+', '$', '\x3', '\x2', '\x2', '\x2', '+', '%', '\x3', '\x2', 
		'\x2', '\x2', '+', '&', '\x3', '\x2', '\x2', '\x2', '+', '\'', '\x3', 
		'\x2', '\x2', '\x2', '+', '(', '\x3', '\x2', '\x2', '\x2', '+', ')', '\x3', 
		'\x2', '\x2', '\x2', '+', '*', '\x3', '\x2', '\x2', '\x2', ',', '\x5', 
		'\x3', '\x2', '\x2', '\x2', '-', '.', '\a', '\x5', '\x2', '\x2', '.', 
		'/', '\x5', '\x16', '\f', '\x2', '/', '\a', '\x3', '\x2', '\x2', '\x2', 
		'\x30', '\x31', '\a', '\x3', '\x2', '\x2', '\x31', '\x32', '\a', '\x11', 
		'\x2', '\x2', '\x32', ';', '\a', '\r', '\x2', '\x2', '\x33', '\x38', '\x5', 
		'\x16', '\f', '\x2', '\x34', '\x35', '\a', '\xE', '\x2', '\x2', '\x35', 
		'\x37', '\x5', '\x16', '\f', '\x2', '\x36', '\x34', '\x3', '\x2', '\x2', 
		'\x2', '\x37', ':', '\x3', '\x2', '\x2', '\x2', '\x38', '\x36', '\x3', 
		'\x2', '\x2', '\x2', '\x38', '\x39', '\x3', '\x2', '\x2', '\x2', '\x39', 
		'<', '\x3', '\x2', '\x2', '\x2', ':', '\x38', '\x3', '\x2', '\x2', '\x2', 
		';', '\x33', '\x3', '\x2', '\x2', '\x2', ';', '<', '\x3', '\x2', '\x2', 
		'\x2', '<', '=', '\x3', '\x2', '\x2', '\x2', '=', '>', '\a', '\xF', '\x2', 
		'\x2', '>', '\t', '\x3', '\x2', '\x2', '\x2', '?', '@', '\a', '\x4', '\x2', 
		'\x2', '@', '\v', '\x3', '\x2', '\x2', '\x2', '\x41', '\x42', '\a', '\x6', 
		'\x2', '\x2', '\x42', '\x43', '\x5', '\x16', '\f', '\x2', '\x43', '\r', 
		'\x3', '\x2', '\x2', '\x2', '\x44', '\x45', '\a', '\b', '\x2', '\x2', 
		'\x45', '\x46', '\a', '\x11', '\x2', '\x2', '\x46', 'O', '\a', '\r', '\x2', 
		'\x2', 'G', 'L', '\a', '\x11', '\x2', '\x2', 'H', 'I', '\a', '\xE', '\x2', 
		'\x2', 'I', 'K', '\a', '\x11', '\x2', '\x2', 'J', 'H', '\x3', '\x2', '\x2', 
		'\x2', 'K', 'N', '\x3', '\x2', '\x2', '\x2', 'L', 'J', '\x3', '\x2', '\x2', 
		'\x2', 'L', 'M', '\x3', '\x2', '\x2', '\x2', 'M', 'P', '\x3', '\x2', '\x2', 
		'\x2', 'N', 'L', '\x3', '\x2', '\x2', '\x2', 'O', 'G', '\x3', '\x2', '\x2', 
		'\x2', 'O', 'P', '\x3', '\x2', '\x2', '\x2', 'P', 'Q', '\x3', '\x2', '\x2', 
		'\x2', 'Q', 'S', '\a', '\xF', '\x2', '\x2', 'R', 'T', '\x5', '\x12', '\n', 
		'\x2', 'S', 'R', '\x3', '\x2', '\x2', '\x2', 'S', 'T', '\x3', '\x2', '\x2', 
		'\x2', 'T', '\xF', '\x3', '\x2', '\x2', '\x2', 'U', 'V', '\a', '\t', '\x2', 
		'\x2', 'V', 'W', '\a', '\x11', '\x2', '\x2', 'W', '\x11', '\x3', '\x2', 
		'\x2', '\x2', 'X', 'Y', '\a', '\x10', '\x2', '\x2', 'Y', 'Z', '\a', '\a', 
		'\x2', '\x2', 'Z', '[', '\a', '\r', '\x2', '\x2', '[', '\\', '\x5', '\x1A', 
		'\xE', '\x2', '\\', ']', '\a', '\xF', '\x2', '\x2', ']', '\x13', '\x3', 
		'\x2', '\x2', '\x2', '^', '_', '\a', '\n', '\x2', '\x2', '_', '`', '\x5', 
		'\x16', '\f', '\x2', '`', '\x15', '\x3', '\x2', '\x2', '\x2', '\x61', 
		'\x64', '\x5', '\x1A', '\xE', '\x2', '\x62', '\x64', '\x5', '\x18', '\r', 
		'\x2', '\x63', '\x61', '\x3', '\x2', '\x2', '\x2', '\x63', '\x62', '\x3', 
		'\x2', '\x2', '\x2', '\x64', '\x17', '\x3', '\x2', '\x2', '\x2', '\x65', 
		'\x66', '\a', '\f', '\x2', '\x2', '\x66', '\x19', '\x3', '\x2', '\x2', 
		'\x2', 'g', 'h', '\a', '\v', '\x2', '\x2', 'h', '\x1B', '\x3', '\x2', 
		'\x2', '\x2', '\n', '\x1F', '+', '\x38', ';', 'L', 'O', 'S', '\x63',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace MFSH.Parser
