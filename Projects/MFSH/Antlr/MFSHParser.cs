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

namespace MFSH {
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
		MSTART=1, LINE=2, BLANKLINE=3, CR=4, Err=5, MINCLUDE=6, MUSE=7, MMACRO=8, 
		MEND=9, MAPPLY=10, MMODEEND=11, MMODECONT=12, MSTRING=13, MOPAR=14, MCOMMA=15, 
		MCPAR=16, MPNAME=17, MWS=18, MCR=19, MErr=20;
	public const int
		RULE_document = 0, RULE_fsh = 1, RULE_mCommands = 2, RULE_mModeStart = 3, 
		RULE_mModeEnd = 4, RULE_mCommand = 5, RULE_mInclude = 6, RULE_mUse = 7, 
		RULE_mMacro = 8, RULE_mApply = 9, RULE_mEnd = 10;
	public static readonly string[] ruleNames = {
		"document", "fsh", "mCommands", "mModeStart", "mModeEnd", "mCommand", 
		"mInclude", "mUse", "mMacro", "mApply", "mEnd"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, "'include'", "'use'", "'macro'", "'end'", 
		"'apply'", null, null, null, "'('", "','", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "MSTART", "LINE", "BLANKLINE", "CR", "Err", "MINCLUDE", "MUSE", 
		"MMACRO", "MEND", "MAPPLY", "MMODEEND", "MMODECONT", "MSTRING", "MOPAR", 
		"MCOMMA", "MCPAR", "MPNAME", "MWS", "MCR", "MErr"
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
		public FshContext[] fsh() {
			return GetRuleContexts<FshContext>();
		}
		public FshContext fsh(int i) {
			return GetRuleContext<FshContext>(i);
		}
		public MCommandsContext[] mCommands() {
			return GetRuleContexts<MCommandsContext>();
		}
		public MCommandsContext mCommands(int i) {
			return GetRuleContext<MCommandsContext>(i);
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
			State = 26;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << MSTART) | (1L << LINE) | (1L << BLANKLINE))) != 0)) {
				{
				State = 24;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case LINE:
				case BLANKLINE:
					{
					State = 22; fsh();
					}
					break;
				case MSTART:
					{
					State = 23; mCommands();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				State = 28;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 29; Match(Eof);
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

	public partial class FshContext : ParserRuleContext {
		public ITerminalNode LINE() { return GetToken(MFSHParser.LINE, 0); }
		public ITerminalNode BLANKLINE() { return GetToken(MFSHParser.BLANKLINE, 0); }
		public FshContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fsh; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFsh(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FshContext fsh() {
		FshContext _localctx = new FshContext(Context, State);
		EnterRule(_localctx, 2, RULE_fsh);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 31;
			_la = TokenStream.LA(1);
			if ( !(_la==LINE || _la==BLANKLINE) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
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

	public partial class MCommandsContext : ParserRuleContext {
		public MModeStartContext mModeStart() {
			return GetRuleContext<MModeStartContext>(0);
		}
		public MModeEndContext mModeEnd() {
			return GetRuleContext<MModeEndContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(MFSHParser.Eof, 0); }
		public MCommandContext[] mCommand() {
			return GetRuleContexts<MCommandContext>();
		}
		public MCommandContext mCommand(int i) {
			return GetRuleContext<MCommandContext>(i);
		}
		public MCommandsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_mCommands; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMCommands(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MCommandsContext mCommands() {
		MCommandsContext _localctx = new MCommandsContext(Context, State);
		EnterRule(_localctx, 4, RULE_mCommands);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 33; mModeStart();
			State = 35;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 34; mCommand();
				}
				}
				State = 37;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << MINCLUDE) | (1L << MUSE) | (1L << MMACRO) | (1L << MEND) | (1L << MAPPLY))) != 0) );
			State = 41;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case MMODEEND:
				{
				State = 39; mModeEnd();
				}
				break;
			case Eof:
				{
				State = 40; Match(Eof);
				}
				break;
			default:
				throw new NoViableAltException(this);
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

	public partial class MModeStartContext : ParserRuleContext {
		public ITerminalNode MSTART() { return GetToken(MFSHParser.MSTART, 0); }
		public MModeStartContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_mModeStart; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMModeStart(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MModeStartContext mModeStart() {
		MModeStartContext _localctx = new MModeStartContext(Context, State);
		EnterRule(_localctx, 6, RULE_mModeStart);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 43; Match(MSTART);
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

	public partial class MModeEndContext : ParserRuleContext {
		public ITerminalNode MMODEEND() { return GetToken(MFSHParser.MMODEEND, 0); }
		public MModeEndContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_mModeEnd; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMModeEnd(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MModeEndContext mModeEnd() {
		MModeEndContext _localctx = new MModeEndContext(Context, State);
		EnterRule(_localctx, 8, RULE_mModeEnd);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 45; Match(MMODEEND);
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

	public partial class MCommandContext : ParserRuleContext {
		public MIncludeContext mInclude() {
			return GetRuleContext<MIncludeContext>(0);
		}
		public MUseContext mUse() {
			return GetRuleContext<MUseContext>(0);
		}
		public MMacroContext mMacro() {
			return GetRuleContext<MMacroContext>(0);
		}
		public MApplyContext mApply() {
			return GetRuleContext<MApplyContext>(0);
		}
		public MEndContext mEnd() {
			return GetRuleContext<MEndContext>(0);
		}
		public MCommandContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_mCommand; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMCommand(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MCommandContext mCommand() {
		MCommandContext _localctx = new MCommandContext(Context, State);
		EnterRule(_localctx, 10, RULE_mCommand);
		try {
			State = 52;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case MINCLUDE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 47; mInclude();
				}
				break;
			case MUSE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 48; mUse();
				}
				break;
			case MMACRO:
				EnterOuterAlt(_localctx, 3);
				{
				State = 49; mMacro();
				}
				break;
			case MAPPLY:
				EnterOuterAlt(_localctx, 4);
				{
				State = 50; mApply();
				}
				break;
			case MEND:
				EnterOuterAlt(_localctx, 5);
				{
				State = 51; mEnd();
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

	public partial class MIncludeContext : ParserRuleContext {
		public ITerminalNode MINCLUDE() { return GetToken(MFSHParser.MINCLUDE, 0); }
		public ITerminalNode MSTRING() { return GetToken(MFSHParser.MSTRING, 0); }
		public MIncludeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_mInclude; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMInclude(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MIncludeContext mInclude() {
		MIncludeContext _localctx = new MIncludeContext(Context, State);
		EnterRule(_localctx, 12, RULE_mInclude);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 54; Match(MINCLUDE);
			State = 55; Match(MSTRING);
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

	public partial class MUseContext : ParserRuleContext {
		public ITerminalNode MUSE() { return GetToken(MFSHParser.MUSE, 0); }
		public ITerminalNode MSTRING() { return GetToken(MFSHParser.MSTRING, 0); }
		public MUseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_mUse; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMUse(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MUseContext mUse() {
		MUseContext _localctx = new MUseContext(Context, State);
		EnterRule(_localctx, 14, RULE_mUse);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 57; Match(MUSE);
			State = 58; Match(MSTRING);
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

	public partial class MMacroContext : ParserRuleContext {
		public ITerminalNode MMACRO() { return GetToken(MFSHParser.MMACRO, 0); }
		public ITerminalNode[] MPNAME() { return GetTokens(MFSHParser.MPNAME); }
		public ITerminalNode MPNAME(int i) {
			return GetToken(MFSHParser.MPNAME, i);
		}
		public ITerminalNode MOPAR() { return GetToken(MFSHParser.MOPAR, 0); }
		public ITerminalNode MCPAR() { return GetToken(MFSHParser.MCPAR, 0); }
		public ITerminalNode[] MCOMMA() { return GetTokens(MFSHParser.MCOMMA); }
		public ITerminalNode MCOMMA(int i) {
			return GetToken(MFSHParser.MCOMMA, i);
		}
		public MMacroContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_mMacro; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMMacro(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MMacroContext mMacro() {
		MMacroContext _localctx = new MMacroContext(Context, State);
		EnterRule(_localctx, 16, RULE_mMacro);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 60; Match(MMACRO);
			State = 61; Match(MPNAME);
			{
			State = 62; Match(MOPAR);
			State = 71;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==MPNAME) {
				{
				State = 63; Match(MPNAME);
				State = 68;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==MCOMMA) {
					{
					{
					State = 64; Match(MCOMMA);
					State = 65; Match(MPNAME);
					}
					}
					State = 70;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
			}

			State = 73; Match(MCPAR);
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

	public partial class MApplyContext : ParserRuleContext {
		public ITerminalNode MAPPLY() { return GetToken(MFSHParser.MAPPLY, 0); }
		public ITerminalNode MPNAME() { return GetToken(MFSHParser.MPNAME, 0); }
		public ITerminalNode MOPAR() { return GetToken(MFSHParser.MOPAR, 0); }
		public ITerminalNode MCPAR() { return GetToken(MFSHParser.MCPAR, 0); }
		public ITerminalNode[] MSTRING() { return GetTokens(MFSHParser.MSTRING); }
		public ITerminalNode MSTRING(int i) {
			return GetToken(MFSHParser.MSTRING, i);
		}
		public ITerminalNode[] MCOMMA() { return GetTokens(MFSHParser.MCOMMA); }
		public ITerminalNode MCOMMA(int i) {
			return GetToken(MFSHParser.MCOMMA, i);
		}
		public MApplyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_mApply; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMApply(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MApplyContext mApply() {
		MApplyContext _localctx = new MApplyContext(Context, State);
		EnterRule(_localctx, 18, RULE_mApply);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 75; Match(MAPPLY);
			State = 76; Match(MPNAME);
			State = 77; Match(MOPAR);
			State = 86;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==MSTRING) {
				{
				State = 78; Match(MSTRING);
				State = 83;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==MCOMMA) {
					{
					{
					State = 79; Match(MCOMMA);
					State = 80; Match(MSTRING);
					}
					}
					State = 85;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
			}

			State = 88; Match(MCPAR);
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

	public partial class MEndContext : ParserRuleContext {
		public ITerminalNode MEND() { return GetToken(MFSHParser.MEND, 0); }
		public MEndContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_mEnd; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHParserVisitor<TResult> typedVisitor = visitor as IMFSHParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMEnd(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MEndContext mEnd() {
		MEndContext _localctx = new MEndContext(Context, State);
		EnterRule(_localctx, 20, RULE_mEnd);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 90; Match(MEND);
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
		'\x5964', '\x3', '\x16', '_', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', '\v', 
		'\x4', '\f', '\t', '\f', '\x3', '\x2', '\x3', '\x2', '\a', '\x2', '\x1B', 
		'\n', '\x2', '\f', '\x2', '\xE', '\x2', '\x1E', '\v', '\x2', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', 
		'\x6', '\x4', '&', '\n', '\x4', '\r', '\x4', '\xE', '\x4', '\'', '\x3', 
		'\x4', '\x3', '\x4', '\x5', '\x4', ',', '\n', '\x4', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x5', '\a', '\x37', '\n', '\a', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\a', '\n', '\x45', '\n', '\n', '\f', '\n', '\xE', '\n', 'H', '\v', '\n', 
		'\x5', '\n', 'J', '\n', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\a', '\v', 
		'T', '\n', '\v', '\f', '\v', '\xE', '\v', 'W', '\v', '\v', '\x5', '\v', 
		'Y', '\n', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x2', '\x2', '\r', '\x2', '\x4', '\x6', '\b', '\n', '\f', '\xE', 
		'\x10', '\x12', '\x14', '\x16', '\x2', '\x3', '\x3', '\x2', '\x4', '\x5', 
		'\x2', '_', '\x2', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x4', '!', '\x3', 
		'\x2', '\x2', '\x2', '\x6', '#', '\x3', '\x2', '\x2', '\x2', '\b', '-', 
		'\x3', '\x2', '\x2', '\x2', '\n', '/', '\x3', '\x2', '\x2', '\x2', '\f', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '\xE', '\x38', '\x3', '\x2', '\x2', 
		'\x2', '\x10', ';', '\x3', '\x2', '\x2', '\x2', '\x12', '>', '\x3', '\x2', 
		'\x2', '\x2', '\x14', 'M', '\x3', '\x2', '\x2', '\x2', '\x16', '\\', '\x3', 
		'\x2', '\x2', '\x2', '\x18', '\x1B', '\x5', '\x4', '\x3', '\x2', '\x19', 
		'\x1B', '\x5', '\x6', '\x4', '\x2', '\x1A', '\x18', '\x3', '\x2', '\x2', 
		'\x2', '\x1A', '\x19', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x1E', '\x3', 
		'\x2', '\x2', '\x2', '\x1C', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x1C', 
		'\x1D', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1F', '\x3', '\x2', '\x2', 
		'\x2', '\x1E', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x1F', ' ', '\a', 
		'\x2', '\x2', '\x3', ' ', '\x3', '\x3', '\x2', '\x2', '\x2', '!', '\"', 
		'\t', '\x2', '\x2', '\x2', '\"', '\x5', '\x3', '\x2', '\x2', '\x2', '#', 
		'%', '\x5', '\b', '\x5', '\x2', '$', '&', '\x5', '\f', '\a', '\x2', '%', 
		'$', '\x3', '\x2', '\x2', '\x2', '&', '\'', '\x3', '\x2', '\x2', '\x2', 
		'\'', '%', '\x3', '\x2', '\x2', '\x2', '\'', '(', '\x3', '\x2', '\x2', 
		'\x2', '(', '+', '\x3', '\x2', '\x2', '\x2', ')', ',', '\x5', '\n', '\x6', 
		'\x2', '*', ',', '\a', '\x2', '\x2', '\x3', '+', ')', '\x3', '\x2', '\x2', 
		'\x2', '+', '*', '\x3', '\x2', '\x2', '\x2', ',', '\a', '\x3', '\x2', 
		'\x2', '\x2', '-', '.', '\a', '\x3', '\x2', '\x2', '.', '\t', '\x3', '\x2', 
		'\x2', '\x2', '/', '\x30', '\a', '\r', '\x2', '\x2', '\x30', '\v', '\x3', 
		'\x2', '\x2', '\x2', '\x31', '\x37', '\x5', '\xE', '\b', '\x2', '\x32', 
		'\x37', '\x5', '\x10', '\t', '\x2', '\x33', '\x37', '\x5', '\x12', '\n', 
		'\x2', '\x34', '\x37', '\x5', '\x14', '\v', '\x2', '\x35', '\x37', '\x5', 
		'\x16', '\f', '\x2', '\x36', '\x31', '\x3', '\x2', '\x2', '\x2', '\x36', 
		'\x32', '\x3', '\x2', '\x2', '\x2', '\x36', '\x33', '\x3', '\x2', '\x2', 
		'\x2', '\x36', '\x34', '\x3', '\x2', '\x2', '\x2', '\x36', '\x35', '\x3', 
		'\x2', '\x2', '\x2', '\x37', '\r', '\x3', '\x2', '\x2', '\x2', '\x38', 
		'\x39', '\a', '\b', '\x2', '\x2', '\x39', ':', '\a', '\xF', '\x2', '\x2', 
		':', '\xF', '\x3', '\x2', '\x2', '\x2', ';', '<', '\a', '\t', '\x2', '\x2', 
		'<', '=', '\a', '\xF', '\x2', '\x2', '=', '\x11', '\x3', '\x2', '\x2', 
		'\x2', '>', '?', '\a', '\n', '\x2', '\x2', '?', '@', '\a', '\x13', '\x2', 
		'\x2', '@', 'I', '\a', '\x10', '\x2', '\x2', '\x41', '\x46', '\a', '\x13', 
		'\x2', '\x2', '\x42', '\x43', '\a', '\x11', '\x2', '\x2', '\x43', '\x45', 
		'\a', '\x13', '\x2', '\x2', '\x44', '\x42', '\x3', '\x2', '\x2', '\x2', 
		'\x45', 'H', '\x3', '\x2', '\x2', '\x2', '\x46', '\x44', '\x3', '\x2', 
		'\x2', '\x2', '\x46', 'G', '\x3', '\x2', '\x2', '\x2', 'G', 'J', '\x3', 
		'\x2', '\x2', '\x2', 'H', '\x46', '\x3', '\x2', '\x2', '\x2', 'I', '\x41', 
		'\x3', '\x2', '\x2', '\x2', 'I', 'J', '\x3', '\x2', '\x2', '\x2', 'J', 
		'K', '\x3', '\x2', '\x2', '\x2', 'K', 'L', '\a', '\x12', '\x2', '\x2', 
		'L', '\x13', '\x3', '\x2', '\x2', '\x2', 'M', 'N', '\a', '\f', '\x2', 
		'\x2', 'N', 'O', '\a', '\x13', '\x2', '\x2', 'O', 'X', '\a', '\x10', '\x2', 
		'\x2', 'P', 'U', '\a', '\xF', '\x2', '\x2', 'Q', 'R', '\a', '\x11', '\x2', 
		'\x2', 'R', 'T', '\a', '\xF', '\x2', '\x2', 'S', 'Q', '\x3', '\x2', '\x2', 
		'\x2', 'T', 'W', '\x3', '\x2', '\x2', '\x2', 'U', 'S', '\x3', '\x2', '\x2', 
		'\x2', 'U', 'V', '\x3', '\x2', '\x2', '\x2', 'V', 'Y', '\x3', '\x2', '\x2', 
		'\x2', 'W', 'U', '\x3', '\x2', '\x2', '\x2', 'X', 'P', '\x3', '\x2', '\x2', 
		'\x2', 'X', 'Y', '\x3', '\x2', '\x2', '\x2', 'Y', 'Z', '\x3', '\x2', '\x2', 
		'\x2', 'Z', '[', '\a', '\x12', '\x2', '\x2', '[', '\x15', '\x3', '\x2', 
		'\x2', '\x2', '\\', ']', '\a', '\v', '\x2', '\x2', ']', '\x17', '\x3', 
		'\x2', '\x2', '\x2', '\v', '\x1A', '\x1C', '\'', '+', '\x36', '\x46', 
		'I', 'U', 'X',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace MFSH