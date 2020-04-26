//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from MFSHPreParser.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace MFSH.PreParser {
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
public partial class MFSHPreParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		COLON=1, EOL=2, TICKTEXT=3, TEXT=4, LB=5, WS=6, CR=7;
	public const int
		RULE_text = 0, RULE_fshCmd = 1, RULE_data = 2, RULE_tickData = 3, RULE_mfsh = 4;
	public static readonly string[] ruleNames = {
		"text", "fshCmd", "data", "tickData", "mfsh"
	};

	private static readonly string[] _LiteralNames = {
		null, "':'", "'\n'", null, null, "'#'", null, "'\r'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "COLON", "EOL", "TICKTEXT", "TEXT", "LB", "WS", "CR"
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

	public override string GrammarFileName { get { return "MFSHPreParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static MFSHPreParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public MFSHPreParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public MFSHPreParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class TextContext : ParserRuleContext {
		public ITerminalNode Eof() { return GetToken(MFSHPreParser.Eof, 0); }
		public DataContext[] data() {
			return GetRuleContexts<DataContext>();
		}
		public DataContext data(int i) {
			return GetRuleContext<DataContext>(i);
		}
		public TickDataContext[] tickData() {
			return GetRuleContexts<TickDataContext>();
		}
		public TickDataContext tickData(int i) {
			return GetRuleContext<TickDataContext>(i);
		}
		public FshCmdContext[] fshCmd() {
			return GetRuleContexts<FshCmdContext>();
		}
		public FshCmdContext fshCmd(int i) {
			return GetRuleContext<FshCmdContext>(i);
		}
		public MfshContext[] mfsh() {
			return GetRuleContexts<MfshContext>();
		}
		public MfshContext mfsh(int i) {
			return GetRuleContext<MfshContext>(i);
		}
		public TextContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_text; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHPreParserVisitor<TResult> typedVisitor = visitor as IMFSHPreParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitText(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TextContext text() {
		TextContext _localctx = new TextContext(Context, State);
		EnterRule(_localctx, 0, RULE_text);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 16;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << EOL) | (1L << TICKTEXT) | (1L << TEXT) | (1L << LB) | (1L << WS))) != 0)) {
				{
				State = 14;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,0,Context) ) {
				case 1:
					{
					State = 10; data();
					}
					break;
				case 2:
					{
					State = 11; tickData();
					}
					break;
				case 3:
					{
					State = 12; fshCmd();
					}
					break;
				case 4:
					{
					State = 13; mfsh();
					}
					break;
				}
				}
				State = 18;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 19; Match(Eof);
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

	public partial class FshCmdContext : ParserRuleContext {
		public ITerminalNode[] TEXT() { return GetTokens(MFSHPreParser.TEXT); }
		public ITerminalNode TEXT(int i) {
			return GetToken(MFSHPreParser.TEXT, i);
		}
		public ITerminalNode[] COLON() { return GetTokens(MFSHPreParser.COLON); }
		public ITerminalNode COLON(int i) {
			return GetToken(MFSHPreParser.COLON, i);
		}
		public ITerminalNode EOL() { return GetToken(MFSHPreParser.EOL, 0); }
		public ITerminalNode[] WS() { return GetTokens(MFSHPreParser.WS); }
		public ITerminalNode WS(int i) {
			return GetToken(MFSHPreParser.WS, i);
		}
		public ITerminalNode[] LB() { return GetTokens(MFSHPreParser.LB); }
		public ITerminalNode LB(int i) {
			return GetToken(MFSHPreParser.LB, i);
		}
		public FshCmdContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fshCmd; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHPreParserVisitor<TResult> typedVisitor = visitor as IMFSHPreParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFshCmd(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FshCmdContext fshCmd() {
		FshCmdContext _localctx = new FshCmdContext(Context, State);
		EnterRule(_localctx, 2, RULE_fshCmd);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 22;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WS) {
				{
				State = 21; Match(WS);
				}
			}

			State = 24; Match(TEXT);
			State = 26;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WS) {
				{
				State = 25; Match(WS);
				}
			}

			State = 28; Match(COLON);
			State = 30;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 29;
				_la = TokenStream.LA(1);
				if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << COLON) | (1L << TEXT) | (1L << LB) | (1L << WS))) != 0)) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
				}
				State = 32;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << COLON) | (1L << TEXT) | (1L << LB) | (1L << WS))) != 0) );
			State = 34; Match(EOL);
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

	public partial class DataContext : ParserRuleContext {
		public ITerminalNode EOL() { return GetToken(MFSHPreParser.EOL, 0); }
		public ITerminalNode[] WS() { return GetTokens(MFSHPreParser.WS); }
		public ITerminalNode WS(int i) {
			return GetToken(MFSHPreParser.WS, i);
		}
		public ITerminalNode[] TEXT() { return GetTokens(MFSHPreParser.TEXT); }
		public ITerminalNode TEXT(int i) {
			return GetToken(MFSHPreParser.TEXT, i);
		}
		public ITerminalNode[] LB() { return GetTokens(MFSHPreParser.LB); }
		public ITerminalNode LB(int i) {
			return GetToken(MFSHPreParser.LB, i);
		}
		public ITerminalNode[] COLON() { return GetTokens(MFSHPreParser.COLON); }
		public ITerminalNode COLON(int i) {
			return GetToken(MFSHPreParser.COLON, i);
		}
		public DataContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_data; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHPreParserVisitor<TResult> typedVisitor = visitor as IMFSHPreParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitData(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DataContext data() {
		DataContext _localctx = new DataContext(Context, State);
		EnterRule(_localctx, 4, RULE_data);
		int _la;
		try {
			State = 60;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,10,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 37;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==WS) {
					{
					State = 36; Match(WS);
					}
				}

				State = 39; Match(EOL);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 41;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==WS) {
					{
					State = 40; Match(WS);
					}
				}

				State = 43; Match(TEXT);
				State = 44; Match(EOL);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 46;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==WS) {
					{
					State = 45; Match(WS);
					}
				}

				State = 48; Match(TEXT);
				State = 50;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==WS) {
					{
					State = 49; Match(WS);
					}
				}

				State = 52;
				_la = TokenStream.LA(1);
				if ( !(_la==TEXT || _la==LB) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 56;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << COLON) | (1L << TEXT) | (1L << LB) | (1L << WS))) != 0)) {
					{
					{
					State = 53;
					_la = TokenStream.LA(1);
					if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << COLON) | (1L << TEXT) | (1L << LB) | (1L << WS))) != 0)) ) {
					ErrorHandler.RecoverInline(this);
					}
					else {
						ErrorHandler.ReportMatch(this);
					    Consume();
					}
					}
					}
					State = 58;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 59; Match(EOL);
				}
				break;
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

	public partial class TickDataContext : ParserRuleContext {
		public ITerminalNode TICKTEXT() { return GetToken(MFSHPreParser.TICKTEXT, 0); }
		public ITerminalNode EOL() { return GetToken(MFSHPreParser.EOL, 0); }
		public ITerminalNode WS() { return GetToken(MFSHPreParser.WS, 0); }
		public TickDataContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tickData; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHPreParserVisitor<TResult> typedVisitor = visitor as IMFSHPreParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTickData(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TickDataContext tickData() {
		TickDataContext _localctx = new TickDataContext(Context, State);
		EnterRule(_localctx, 6, RULE_tickData);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 63;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WS) {
				{
				State = 62; Match(WS);
				}
			}

			State = 65; Match(TICKTEXT);
			State = 66; Match(EOL);
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

	public partial class MfshContext : ParserRuleContext {
		public ITerminalNode[] LB() { return GetTokens(MFSHPreParser.LB); }
		public ITerminalNode LB(int i) {
			return GetToken(MFSHPreParser.LB, i);
		}
		public ITerminalNode EOL() { return GetToken(MFSHPreParser.EOL, 0); }
		public ITerminalNode[] WS() { return GetTokens(MFSHPreParser.WS); }
		public ITerminalNode WS(int i) {
			return GetToken(MFSHPreParser.WS, i);
		}
		public ITerminalNode[] TEXT() { return GetTokens(MFSHPreParser.TEXT); }
		public ITerminalNode TEXT(int i) {
			return GetToken(MFSHPreParser.TEXT, i);
		}
		public MfshContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_mfsh; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHPreParserVisitor<TResult> typedVisitor = visitor as IMFSHPreParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMfsh(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MfshContext mfsh() {
		MfshContext _localctx = new MfshContext(Context, State);
		EnterRule(_localctx, 8, RULE_mfsh);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 69;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WS) {
				{
				State = 68; Match(WS);
				}
			}

			State = 71; Match(LB);
			State = 75;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << TEXT) | (1L << LB) | (1L << WS))) != 0)) {
				{
				{
				State = 72;
				_la = TokenStream.LA(1);
				if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << TEXT) | (1L << LB) | (1L << WS))) != 0)) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
				}
				State = 77;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 78; Match(EOL);
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
		'\x5964', '\x3', '\t', 'S', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', '\t', 
		'\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', '\x6', 
		'\t', '\x6', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\a', 
		'\x2', '\x11', '\n', '\x2', '\f', '\x2', '\xE', '\x2', '\x14', '\v', '\x2', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x5', '\x3', '\x19', '\n', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x5', '\x3', '\x1D', '\n', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x6', '\x3', '!', '\n', '\x3', '\r', '\x3', 
		'\xE', '\x3', '\"', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x5', '\x4', 
		'(', '\n', '\x4', '\x3', '\x4', '\x3', '\x4', '\x5', '\x4', ',', '\n', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x5', '\x4', '\x31', 
		'\n', '\x4', '\x3', '\x4', '\x3', '\x4', '\x5', '\x4', '\x35', '\n', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\a', '\x4', '\x39', '\n', '\x4', '\f', '\x4', 
		'\xE', '\x4', '<', '\v', '\x4', '\x3', '\x4', '\x5', '\x4', '?', '\n', 
		'\x4', '\x3', '\x5', '\x5', '\x5', '\x42', '\n', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x5', '\x6', 'H', '\n', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\a', '\x6', 'L', '\n', '\x6', '\f', '\x6', 
		'\xE', '\x6', 'O', '\v', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x2', '\x2', '\a', '\x2', '\x4', '\x6', '\b', '\n', '\x2', '\x5', '\x4', 
		'\x2', '\x3', '\x3', '\x6', '\b', '\x3', '\x2', '\x6', '\a', '\x3', '\x2', 
		'\x6', '\b', '\x2', '^', '\x2', '\x12', '\x3', '\x2', '\x2', '\x2', '\x4', 
		'\x18', '\x3', '\x2', '\x2', '\x2', '\x6', '>', '\x3', '\x2', '\x2', '\x2', 
		'\b', '\x41', '\x3', '\x2', '\x2', '\x2', '\n', 'G', '\x3', '\x2', '\x2', 
		'\x2', '\f', '\x11', '\x5', '\x6', '\x4', '\x2', '\r', '\x11', '\x5', 
		'\b', '\x5', '\x2', '\xE', '\x11', '\x5', '\x4', '\x3', '\x2', '\xF', 
		'\x11', '\x5', '\n', '\x6', '\x2', '\x10', '\f', '\x3', '\x2', '\x2', 
		'\x2', '\x10', '\r', '\x3', '\x2', '\x2', '\x2', '\x10', '\xE', '\x3', 
		'\x2', '\x2', '\x2', '\x10', '\xF', '\x3', '\x2', '\x2', '\x2', '\x11', 
		'\x14', '\x3', '\x2', '\x2', '\x2', '\x12', '\x10', '\x3', '\x2', '\x2', 
		'\x2', '\x12', '\x13', '\x3', '\x2', '\x2', '\x2', '\x13', '\x15', '\x3', 
		'\x2', '\x2', '\x2', '\x14', '\x12', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'\x16', '\a', '\x2', '\x2', '\x3', '\x16', '\x3', '\x3', '\x2', '\x2', 
		'\x2', '\x17', '\x19', '\a', '\b', '\x2', '\x2', '\x18', '\x17', '\x3', 
		'\x2', '\x2', '\x2', '\x18', '\x19', '\x3', '\x2', '\x2', '\x2', '\x19', 
		'\x1A', '\x3', '\x2', '\x2', '\x2', '\x1A', '\x1C', '\a', '\x6', '\x2', 
		'\x2', '\x1B', '\x1D', '\a', '\b', '\x2', '\x2', '\x1C', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', '\x1C', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x1D', 
		'\x1E', '\x3', '\x2', '\x2', '\x2', '\x1E', ' ', '\a', '\x3', '\x2', '\x2', 
		'\x1F', '!', '\t', '\x2', '\x2', '\x2', ' ', '\x1F', '\x3', '\x2', '\x2', 
		'\x2', '!', '\"', '\x3', '\x2', '\x2', '\x2', '\"', ' ', '\x3', '\x2', 
		'\x2', '\x2', '\"', '#', '\x3', '\x2', '\x2', '\x2', '#', '$', '\x3', 
		'\x2', '\x2', '\x2', '$', '%', '\a', '\x4', '\x2', '\x2', '%', '\x5', 
		'\x3', '\x2', '\x2', '\x2', '&', '(', '\a', '\b', '\x2', '\x2', '\'', 
		'&', '\x3', '\x2', '\x2', '\x2', '\'', '(', '\x3', '\x2', '\x2', '\x2', 
		'(', ')', '\x3', '\x2', '\x2', '\x2', ')', '?', '\a', '\x4', '\x2', '\x2', 
		'*', ',', '\a', '\b', '\x2', '\x2', '+', '*', '\x3', '\x2', '\x2', '\x2', 
		'+', ',', '\x3', '\x2', '\x2', '\x2', ',', '-', '\x3', '\x2', '\x2', '\x2', 
		'-', '.', '\a', '\x6', '\x2', '\x2', '.', '?', '\a', '\x4', '\x2', '\x2', 
		'/', '\x31', '\a', '\b', '\x2', '\x2', '\x30', '/', '\x3', '\x2', '\x2', 
		'\x2', '\x30', '\x31', '\x3', '\x2', '\x2', '\x2', '\x31', '\x32', '\x3', 
		'\x2', '\x2', '\x2', '\x32', '\x34', '\a', '\x6', '\x2', '\x2', '\x33', 
		'\x35', '\a', '\b', '\x2', '\x2', '\x34', '\x33', '\x3', '\x2', '\x2', 
		'\x2', '\x34', '\x35', '\x3', '\x2', '\x2', '\x2', '\x35', '\x36', '\x3', 
		'\x2', '\x2', '\x2', '\x36', ':', '\t', '\x3', '\x2', '\x2', '\x37', '\x39', 
		'\t', '\x2', '\x2', '\x2', '\x38', '\x37', '\x3', '\x2', '\x2', '\x2', 
		'\x39', '<', '\x3', '\x2', '\x2', '\x2', ':', '\x38', '\x3', '\x2', '\x2', 
		'\x2', ':', ';', '\x3', '\x2', '\x2', '\x2', ';', '=', '\x3', '\x2', '\x2', 
		'\x2', '<', ':', '\x3', '\x2', '\x2', '\x2', '=', '?', '\a', '\x4', '\x2', 
		'\x2', '>', '\'', '\x3', '\x2', '\x2', '\x2', '>', '+', '\x3', '\x2', 
		'\x2', '\x2', '>', '\x30', '\x3', '\x2', '\x2', '\x2', '?', '\a', '\x3', 
		'\x2', '\x2', '\x2', '@', '\x42', '\a', '\b', '\x2', '\x2', '\x41', '@', 
		'\x3', '\x2', '\x2', '\x2', '\x41', '\x42', '\x3', '\x2', '\x2', '\x2', 
		'\x42', '\x43', '\x3', '\x2', '\x2', '\x2', '\x43', '\x44', '\a', '\x5', 
		'\x2', '\x2', '\x44', '\x45', '\a', '\x4', '\x2', '\x2', '\x45', '\t', 
		'\x3', '\x2', '\x2', '\x2', '\x46', 'H', '\a', '\b', '\x2', '\x2', 'G', 
		'\x46', '\x3', '\x2', '\x2', '\x2', 'G', 'H', '\x3', '\x2', '\x2', '\x2', 
		'H', 'I', '\x3', '\x2', '\x2', '\x2', 'I', 'M', '\a', '\a', '\x2', '\x2', 
		'J', 'L', '\t', '\x4', '\x2', '\x2', 'K', 'J', '\x3', '\x2', '\x2', '\x2', 
		'L', 'O', '\x3', '\x2', '\x2', '\x2', 'M', 'K', '\x3', '\x2', '\x2', '\x2', 
		'M', 'N', '\x3', '\x2', '\x2', '\x2', 'N', 'P', '\x3', '\x2', '\x2', '\x2', 
		'O', 'M', '\x3', '\x2', '\x2', '\x2', 'P', 'Q', '\a', '\x4', '\x2', '\x2', 
		'Q', '\v', '\x3', '\x2', '\x2', '\x2', '\x10', '\x10', '\x12', '\x18', 
		'\x1C', '\"', '\'', '+', '\x30', '\x34', ':', '>', '\x41', 'G', 'M',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace MFSH.PreParser
