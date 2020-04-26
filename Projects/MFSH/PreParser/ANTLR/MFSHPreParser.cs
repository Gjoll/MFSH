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
		PROFILE=1, COLON=2, EOL=3, TEXT=4, LB=5, WS=6, CR=7;
	public const int
		RULE_text = 0, RULE_profile = 1, RULE_fsh = 2, RULE_mfsh = 3;
	public static readonly string[] ruleNames = {
		"text", "profile", "fsh", "mfsh"
	};

	private static readonly string[] _LiteralNames = {
		null, null, "':'", "'\n'", null, "'#'", null, "'\r'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "PROFILE", "COLON", "EOL", "TEXT", "LB", "WS", "CR"
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
		public FshContext[] fsh() {
			return GetRuleContexts<FshContext>();
		}
		public FshContext fsh(int i) {
			return GetRuleContext<FshContext>(i);
		}
		public MfshContext[] mfsh() {
			return GetRuleContexts<MfshContext>();
		}
		public MfshContext mfsh(int i) {
			return GetRuleContext<MfshContext>(i);
		}
		public ProfileContext[] profile() {
			return GetRuleContexts<ProfileContext>();
		}
		public ProfileContext profile(int i) {
			return GetRuleContext<ProfileContext>(i);
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
			State = 13;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << PROFILE) | (1L << COLON) | (1L << EOL) | (1L << TEXT) | (1L << LB) | (1L << WS))) != 0)) {
				{
				State = 11;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,0,Context) ) {
				case 1:
					{
					State = 8; fsh();
					}
					break;
				case 2:
					{
					State = 9; mfsh();
					}
					break;
				case 3:
					{
					State = 10; profile();
					}
					break;
				}
				}
				State = 15;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 16; Match(Eof);
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
		public ITerminalNode PROFILE() { return GetToken(MFSHPreParser.PROFILE, 0); }
		public ITerminalNode EOL() { return GetToken(MFSHPreParser.EOL, 0); }
		public ITerminalNode[] TEXT() { return GetTokens(MFSHPreParser.TEXT); }
		public ITerminalNode TEXT(int i) {
			return GetToken(MFSHPreParser.TEXT, i);
		}
		public ITerminalNode[] WS() { return GetTokens(MFSHPreParser.WS); }
		public ITerminalNode WS(int i) {
			return GetToken(MFSHPreParser.WS, i);
		}
		public ITerminalNode[] LB() { return GetTokens(MFSHPreParser.LB); }
		public ITerminalNode LB(int i) {
			return GetToken(MFSHPreParser.LB, i);
		}
		public ProfileContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_profile; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHPreParserVisitor<TResult> typedVisitor = visitor as IMFSHPreParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProfile(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProfileContext profile() {
		ProfileContext _localctx = new ProfileContext(Context, State);
		EnterRule(_localctx, 2, RULE_profile);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 18; Match(PROFILE);
			State = 20;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WS) {
				{
				State = 19; Match(WS);
				}
			}

			{
			State = 22; Match(TEXT);
			State = 26;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << TEXT) | (1L << LB) | (1L << WS))) != 0)) {
				{
				{
				State = 23;
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
				State = 28;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
			State = 29; Match(EOL);
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
		public ITerminalNode EOL() { return GetToken(MFSHPreParser.EOL, 0); }
		public ITerminalNode[] WS() { return GetTokens(MFSHPreParser.WS); }
		public ITerminalNode WS(int i) {
			return GetToken(MFSHPreParser.WS, i);
		}
		public ITerminalNode[] TEXT() { return GetTokens(MFSHPreParser.TEXT); }
		public ITerminalNode TEXT(int i) {
			return GetToken(MFSHPreParser.TEXT, i);
		}
		public ITerminalNode[] COLON() { return GetTokens(MFSHPreParser.COLON); }
		public ITerminalNode COLON(int i) {
			return GetToken(MFSHPreParser.COLON, i);
		}
		public ITerminalNode[] LB() { return GetTokens(MFSHPreParser.LB); }
		public ITerminalNode LB(int i) {
			return GetToken(MFSHPreParser.LB, i);
		}
		public FshContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fsh; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMFSHPreParserVisitor<TResult> typedVisitor = visitor as IMFSHPreParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFsh(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FshContext fsh() {
		FshContext _localctx = new FshContext(Context, State);
		EnterRule(_localctx, 4, RULE_fsh);
		int _la;
		try {
			State = 48;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,8,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 32;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==WS) {
					{
					State = 31; Match(WS);
					}
				}

				State = 41;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==COLON || _la==TEXT) {
					{
					State = 34;
					_la = TokenStream.LA(1);
					if ( !(_la==COLON || _la==TEXT) ) {
					ErrorHandler.RecoverInline(this);
					}
					else {
						ErrorHandler.ReportMatch(this);
					    Consume();
					}
					State = 38;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << COLON) | (1L << TEXT) | (1L << LB) | (1L << WS))) != 0)) {
						{
						{
						State = 35;
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
						State = 40;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					}
				}

				State = 43; Match(EOL);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 45;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==WS) {
					{
					State = 44; Match(WS);
					}
				}

				State = 47; Match(EOL);
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
		EnterRule(_localctx, 6, RULE_mfsh);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 51;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WS) {
				{
				State = 50; Match(WS);
				}
			}

			State = 53; Match(LB);
			State = 57;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << TEXT) | (1L << LB) | (1L << WS))) != 0)) {
				{
				{
				State = 54;
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
				State = 59;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 60; Match(EOL);
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
		'\x5964', '\x3', '\t', '\x41', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\a', '\x2', '\xE', '\n', '\x2', '\f', 
		'\x2', '\xE', '\x2', '\x11', '\v', '\x2', '\x3', '\x2', '\x3', '\x2', 
		'\x3', '\x3', '\x3', '\x3', '\x5', '\x3', '\x17', '\n', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\a', '\x3', '\x1B', '\n', '\x3', '\f', '\x3', '\xE', 
		'\x3', '\x1E', '\v', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', 
		'\x5', '\x4', '#', '\n', '\x4', '\x3', '\x4', '\x3', '\x4', '\a', '\x4', 
		'\'', '\n', '\x4', '\f', '\x4', '\xE', '\x4', '*', '\v', '\x4', '\x5', 
		'\x4', ',', '\n', '\x4', '\x3', '\x4', '\x3', '\x4', '\x5', '\x4', '\x30', 
		'\n', '\x4', '\x3', '\x4', '\x5', '\x4', '\x33', '\n', '\x4', '\x3', '\x5', 
		'\x5', '\x5', '\x36', '\n', '\x5', '\x3', '\x5', '\x3', '\x5', '\a', '\x5', 
		':', '\n', '\x5', '\f', '\x5', '\xE', '\x5', '=', '\v', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x2', '\x2', '\x6', '\x2', '\x4', 
		'\x6', '\b', '\x2', '\x5', '\x3', '\x2', '\x6', '\b', '\x4', '\x2', '\x4', 
		'\x4', '\x6', '\x6', '\x4', '\x2', '\x4', '\x4', '\x6', '\b', '\x2', 'H', 
		'\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x4', '\x14', '\x3', '\x2', 
		'\x2', '\x2', '\x6', '\x32', '\x3', '\x2', '\x2', '\x2', '\b', '\x35', 
		'\x3', '\x2', '\x2', '\x2', '\n', '\xE', '\x5', '\x6', '\x4', '\x2', '\v', 
		'\xE', '\x5', '\b', '\x5', '\x2', '\f', '\xE', '\x5', '\x4', '\x3', '\x2', 
		'\r', '\n', '\x3', '\x2', '\x2', '\x2', '\r', '\v', '\x3', '\x2', '\x2', 
		'\x2', '\r', '\f', '\x3', '\x2', '\x2', '\x2', '\xE', '\x11', '\x3', '\x2', 
		'\x2', '\x2', '\xF', '\r', '\x3', '\x2', '\x2', '\x2', '\xF', '\x10', 
		'\x3', '\x2', '\x2', '\x2', '\x10', '\x12', '\x3', '\x2', '\x2', '\x2', 
		'\x11', '\xF', '\x3', '\x2', '\x2', '\x2', '\x12', '\x13', '\a', '\x2', 
		'\x2', '\x3', '\x13', '\x3', '\x3', '\x2', '\x2', '\x2', '\x14', '\x16', 
		'\a', '\x3', '\x2', '\x2', '\x15', '\x17', '\a', '\b', '\x2', '\x2', '\x16', 
		'\x15', '\x3', '\x2', '\x2', '\x2', '\x16', '\x17', '\x3', '\x2', '\x2', 
		'\x2', '\x17', '\x18', '\x3', '\x2', '\x2', '\x2', '\x18', '\x1C', '\a', 
		'\x6', '\x2', '\x2', '\x19', '\x1B', '\t', '\x2', '\x2', '\x2', '\x1A', 
		'\x19', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x1E', '\x3', '\x2', '\x2', 
		'\x2', '\x1C', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x1C', '\x1D', '\x3', 
		'\x2', '\x2', '\x2', '\x1D', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x1E', 
		'\x1C', '\x3', '\x2', '\x2', '\x2', '\x1F', ' ', '\a', '\x5', '\x2', '\x2', 
		' ', '\x5', '\x3', '\x2', '\x2', '\x2', '!', '#', '\a', '\b', '\x2', '\x2', 
		'\"', '!', '\x3', '\x2', '\x2', '\x2', '\"', '#', '\x3', '\x2', '\x2', 
		'\x2', '#', '+', '\x3', '\x2', '\x2', '\x2', '$', '(', '\t', '\x3', '\x2', 
		'\x2', '%', '\'', '\t', '\x4', '\x2', '\x2', '&', '%', '\x3', '\x2', '\x2', 
		'\x2', '\'', '*', '\x3', '\x2', '\x2', '\x2', '(', '&', '\x3', '\x2', 
		'\x2', '\x2', '(', ')', '\x3', '\x2', '\x2', '\x2', ')', ',', '\x3', '\x2', 
		'\x2', '\x2', '*', '(', '\x3', '\x2', '\x2', '\x2', '+', '$', '\x3', '\x2', 
		'\x2', '\x2', '+', ',', '\x3', '\x2', '\x2', '\x2', ',', '-', '\x3', '\x2', 
		'\x2', '\x2', '-', '\x33', '\a', '\x5', '\x2', '\x2', '.', '\x30', '\a', 
		'\b', '\x2', '\x2', '/', '.', '\x3', '\x2', '\x2', '\x2', '/', '\x30', 
		'\x3', '\x2', '\x2', '\x2', '\x30', '\x31', '\x3', '\x2', '\x2', '\x2', 
		'\x31', '\x33', '\a', '\x5', '\x2', '\x2', '\x32', '\"', '\x3', '\x2', 
		'\x2', '\x2', '\x32', '/', '\x3', '\x2', '\x2', '\x2', '\x33', '\a', '\x3', 
		'\x2', '\x2', '\x2', '\x34', '\x36', '\a', '\b', '\x2', '\x2', '\x35', 
		'\x34', '\x3', '\x2', '\x2', '\x2', '\x35', '\x36', '\x3', '\x2', '\x2', 
		'\x2', '\x36', '\x37', '\x3', '\x2', '\x2', '\x2', '\x37', ';', '\a', 
		'\a', '\x2', '\x2', '\x38', ':', '\t', '\x2', '\x2', '\x2', '\x39', '\x38', 
		'\x3', '\x2', '\x2', '\x2', ':', '=', '\x3', '\x2', '\x2', '\x2', ';', 
		'\x39', '\x3', '\x2', '\x2', '\x2', ';', '<', '\x3', '\x2', '\x2', '\x2', 
		'<', '>', '\x3', '\x2', '\x2', '\x2', '=', ';', '\x3', '\x2', '\x2', '\x2', 
		'>', '?', '\a', '\x5', '\x2', '\x2', '?', '\t', '\x3', '\x2', '\x2', '\x2', 
		'\r', '\r', '\xF', '\x16', '\x1C', '\"', '(', '+', '/', '\x32', '\x35', 
		';',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace MFSH.PreParser
