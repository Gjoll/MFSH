//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from MFSHLexer.g4 by ANTLR 4.8

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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class MFSHLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		MSTART=1, LINE=2, BLANKLINE=3, LASTLINE=4, CR=5, Err=6, MINCLUDE=7, MUSE=8, 
		MMACRO=9, MEND=10, MAPPLY=11, MMODEEND=12, MSTRING=13, MOPAR=14, MCOMMA=15, 
		MCPAR=16, MPNAME=17, MWS=18, MCR=19, MErr=20;
	public const int
		MFSH=1;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE", "MFSH"
	};

	public static readonly string[] ruleNames = {
		"SPACE", "MSTART", "LINE", "BLANKLINE", "LASTLINE", "CR", "Err", "MINCLUDE", 
		"MUSE", "MMACRO", "MEND", "MAPPLY", "MMODEEND", "MSTRING", "MOPAR", "MCOMMA", 
		"MCPAR", "MPNAME", "MWS", "MCR", "MErr"
	};


	public MFSHLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public MFSHLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, null, "'include'", "'use'", "'macro'", 
		"'end'", "'apply'", null, null, "'('", "','", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "MSTART", "LINE", "BLANKLINE", "LASTLINE", "CR", "Err", "MINCLUDE", 
		"MUSE", "MMACRO", "MEND", "MAPPLY", "MMODEEND", "MSTRING", "MOPAR", "MCOMMA", 
		"MCPAR", "MPNAME", "MWS", "MCR", "MErr"
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

	public override string GrammarFileName { get { return "MFSHLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static MFSHLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x16', '\xB6', '\b', '\x1', '\b', '\x1', '\x4', '\x2', 
		'\t', '\x2', '\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', 
		'\x5', '\t', '\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', 
		'\x4', '\b', '\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', 
		'\x4', '\v', '\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', 
		'\x4', '\xE', '\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', 
		'\x10', '\x4', '\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', 
		'\x13', '\t', '\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', 
		'\x15', '\x4', '\x16', '\t', '\x16', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x3', '\a', '\x3', '\x32', '\n', '\x3', '\f', '\x3', '\xE', '\x3', '\x35', 
		'\v', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x4', '\a', '\x4', '<', '\n', '\x4', '\f', '\x4', '\xE', '\x4', '?', 
		'\v', '\x4', '\x3', '\x4', '\x3', '\x4', '\a', '\x4', '\x43', '\n', '\x4', 
		'\f', '\x4', '\xE', '\x4', '\x46', '\v', '\x4', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x5', '\a', '\x5', 'K', '\n', '\x5', '\f', '\x5', '\xE', '\x5', 
		'N', '\v', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x6', '\x6', 
		'S', '\n', '\x6', '\r', '\x6', '\xE', '\x6', 'T', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', 
		'\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\a', '\xE', '}', '\n', 
		'\xE', '\f', '\xE', '\xE', '\xE', '\x80', '\v', '\xE', '\x3', '\xE', '\x3', 
		'\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\a', '\xF', 
		'\x88', '\n', '\xF', '\f', '\xF', '\xE', '\xF', '\x8B', '\v', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x6', 
		'\x13', '\x97', '\n', '\x13', '\r', '\x13', '\xE', '\x13', '\x98', '\x3', 
		'\x13', '\x3', '\x13', '\x3', '\x13', '\x6', '\x13', '\x9E', '\n', '\x13', 
		'\r', '\x13', '\xE', '\x13', '\x9F', '\x3', '\x13', '\x3', '\x13', '\x3', 
		'\x13', '\x3', '\x13', '\x6', '\x13', '\xA6', '\n', '\x13', '\r', '\x13', 
		'\xE', '\x13', '\xA7', '\x3', '\x13', '\x5', '\x13', '\xAB', '\n', '\x13', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', 
		'\x2', '\x2', '\x17', '\x4', '\x2', '\x6', '\x3', '\b', '\x4', '\n', '\x5', 
		'\f', '\x6', '\xE', '\a', '\x10', '\b', '\x12', '\t', '\x14', '\n', '\x16', 
		'\v', '\x18', '\f', '\x1A', '\r', '\x1C', '\xE', '\x1E', '\xF', ' ', '\x10', 
		'\"', '\x11', '$', '\x12', '&', '\x13', '(', '\x14', '*', '\x15', ',', 
		'\x16', '\x4', '\x2', '\x3', '\t', '\x4', '\x2', '\v', '\v', '\"', '\"', 
		'\x5', '\x2', '\v', '\f', '\"', '\"', '%', '%', '\x3', '\x2', '\f', '\f', 
		'\x3', '\x2', '%', '%', '\x3', '\x2', '$', '$', '\x4', '\x2', '\x43', 
		'\\', '\x63', '|', '\x5', '\x2', '\x32', ';', '\x43', '\\', '\x63', '|', 
		'\x2', '\xBF', '\x2', '\x6', '\x3', '\x2', '\x2', '\x2', '\x2', '\b', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\n', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\f', '\x3', '\x2', '\x2', '\x2', '\x2', '\xE', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x10', '\x3', '\x2', '\x2', '\x2', '\x3', '\x12', '\x3', '\x2', 
		'\x2', '\x2', '\x3', '\x14', '\x3', '\x2', '\x2', '\x2', '\x3', '\x16', 
		'\x3', '\x2', '\x2', '\x2', '\x3', '\x18', '\x3', '\x2', '\x2', '\x2', 
		'\x3', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x3', '\x1C', '\x3', '\x2', 
		'\x2', '\x2', '\x3', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x3', ' ', '\x3', 
		'\x2', '\x2', '\x2', '\x3', '\"', '\x3', '\x2', '\x2', '\x2', '\x3', '$', 
		'\x3', '\x2', '\x2', '\x2', '\x3', '&', '\x3', '\x2', '\x2', '\x2', '\x3', 
		'(', '\x3', '\x2', '\x2', '\x2', '\x3', '*', '\x3', '\x2', '\x2', '\x2', 
		'\x3', ',', '\x3', '\x2', '\x2', '\x2', '\x4', '.', '\x3', '\x2', '\x2', 
		'\x2', '\x6', '\x33', '\x3', '\x2', '\x2', '\x2', '\b', '=', '\x3', '\x2', 
		'\x2', '\x2', '\n', 'L', '\x3', '\x2', '\x2', '\x2', '\f', 'R', '\x3', 
		'\x2', '\x2', '\x2', '\xE', 'X', '\x3', '\x2', '\x2', '\x2', '\x10', '\\', 
		'\x3', '\x2', '\x2', '\x2', '\x12', '^', '\x3', '\x2', '\x2', '\x2', '\x14', 
		'\x66', '\x3', '\x2', '\x2', '\x2', '\x16', 'j', '\x3', '\x2', '\x2', 
		'\x2', '\x18', 'p', '\x3', '\x2', '\x2', '\x2', '\x1A', 't', '\x3', '\x2', 
		'\x2', '\x2', '\x1C', 'z', '\x3', '\x2', '\x2', '\x2', '\x1E', '\x85', 
		'\x3', '\x2', '\x2', '\x2', ' ', '\x8E', '\x3', '\x2', '\x2', '\x2', '\"', 
		'\x90', '\x3', '\x2', '\x2', '\x2', '$', '\x92', '\x3', '\x2', '\x2', 
		'\x2', '&', '\xAA', '\x3', '\x2', '\x2', '\x2', '(', '\xAC', '\x3', '\x2', 
		'\x2', '\x2', '*', '\xB0', '\x3', '\x2', '\x2', '\x2', ',', '\xB4', '\x3', 
		'\x2', '\x2', '\x2', '.', '/', '\t', '\x2', '\x2', '\x2', '/', '\x5', 
		'\x3', '\x2', '\x2', '\x2', '\x30', '\x32', '\x5', '\x4', '\x2', '\x2', 
		'\x31', '\x30', '\x3', '\x2', '\x2', '\x2', '\x32', '\x35', '\x3', '\x2', 
		'\x2', '\x2', '\x33', '\x31', '\x3', '\x2', '\x2', '\x2', '\x33', '\x34', 
		'\x3', '\x2', '\x2', '\x2', '\x34', '\x36', '\x3', '\x2', '\x2', '\x2', 
		'\x35', '\x33', '\x3', '\x2', '\x2', '\x2', '\x36', '\x37', '\a', '%', 
		'\x2', '\x2', '\x37', '\x38', '\x3', '\x2', '\x2', '\x2', '\x38', '\x39', 
		'\b', '\x3', '\x2', '\x2', '\x39', '\a', '\x3', '\x2', '\x2', '\x2', ':', 
		'<', '\x5', '\x4', '\x2', '\x2', ';', ':', '\x3', '\x2', '\x2', '\x2', 
		'<', '?', '\x3', '\x2', '\x2', '\x2', '=', ';', '\x3', '\x2', '\x2', '\x2', 
		'=', '>', '\x3', '\x2', '\x2', '\x2', '>', '@', '\x3', '\x2', '\x2', '\x2', 
		'?', '=', '\x3', '\x2', '\x2', '\x2', '@', '\x44', '\n', '\x3', '\x2', 
		'\x2', '\x41', '\x43', '\n', '\x4', '\x2', '\x2', '\x42', '\x41', '\x3', 
		'\x2', '\x2', '\x2', '\x43', '\x46', '\x3', '\x2', '\x2', '\x2', '\x44', 
		'\x42', '\x3', '\x2', '\x2', '\x2', '\x44', '\x45', '\x3', '\x2', '\x2', 
		'\x2', '\x45', 'G', '\x3', '\x2', '\x2', '\x2', '\x46', '\x44', '\x3', 
		'\x2', '\x2', '\x2', 'G', 'H', '\a', '\f', '\x2', '\x2', 'H', '\t', '\x3', 
		'\x2', '\x2', '\x2', 'I', 'K', '\x5', '\x4', '\x2', '\x2', 'J', 'I', '\x3', 
		'\x2', '\x2', '\x2', 'K', 'N', '\x3', '\x2', '\x2', '\x2', 'L', 'J', '\x3', 
		'\x2', '\x2', '\x2', 'L', 'M', '\x3', '\x2', '\x2', '\x2', 'M', 'O', '\x3', 
		'\x2', '\x2', '\x2', 'N', 'L', '\x3', '\x2', '\x2', '\x2', 'O', 'P', '\a', 
		'\f', '\x2', '\x2', 'P', '\v', '\x3', '\x2', '\x2', '\x2', 'Q', 'S', '\x5', 
		'\x4', '\x2', '\x2', 'R', 'Q', '\x3', '\x2', '\x2', '\x2', 'S', 'T', '\x3', 
		'\x2', '\x2', '\x2', 'T', 'R', '\x3', '\x2', '\x2', '\x2', 'T', 'U', '\x3', 
		'\x2', '\x2', '\x2', 'U', 'V', '\x3', '\x2', '\x2', '\x2', 'V', 'W', '\b', 
		'\x6', '\x3', '\x2', 'W', '\r', '\x3', '\x2', '\x2', '\x2', 'X', 'Y', 
		'\a', '\xF', '\x2', '\x2', 'Y', 'Z', '\x3', '\x2', '\x2', '\x2', 'Z', 
		'[', '\b', '\a', '\x3', '\x2', '[', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\\', ']', '\v', '\x2', '\x2', '\x2', ']', '\x11', '\x3', '\x2', '\x2', 
		'\x2', '^', '_', '\a', 'k', '\x2', '\x2', '_', '`', '\a', 'p', '\x2', 
		'\x2', '`', '\x61', '\a', '\x65', '\x2', '\x2', '\x61', '\x62', '\a', 
		'n', '\x2', '\x2', '\x62', '\x63', '\a', 'w', '\x2', '\x2', '\x63', '\x64', 
		'\a', '\x66', '\x2', '\x2', '\x64', '\x65', '\a', 'g', '\x2', '\x2', '\x65', 
		'\x13', '\x3', '\x2', '\x2', '\x2', '\x66', 'g', '\a', 'w', '\x2', '\x2', 
		'g', 'h', '\a', 'u', '\x2', '\x2', 'h', 'i', '\a', 'g', '\x2', '\x2', 
		'i', '\x15', '\x3', '\x2', '\x2', '\x2', 'j', 'k', '\a', 'o', '\x2', '\x2', 
		'k', 'l', '\a', '\x63', '\x2', '\x2', 'l', 'm', '\a', '\x65', '\x2', '\x2', 
		'm', 'n', '\a', 't', '\x2', '\x2', 'n', 'o', '\a', 'q', '\x2', '\x2', 
		'o', '\x17', '\x3', '\x2', '\x2', '\x2', 'p', 'q', '\a', 'g', '\x2', '\x2', 
		'q', 'r', '\a', 'p', '\x2', '\x2', 'r', 's', '\a', '\x66', '\x2', '\x2', 
		's', '\x19', '\x3', '\x2', '\x2', '\x2', 't', 'u', '\a', '\x63', '\x2', 
		'\x2', 'u', 'v', '\a', 'r', '\x2', '\x2', 'v', 'w', '\a', 'r', '\x2', 
		'\x2', 'w', 'x', '\a', 'n', '\x2', '\x2', 'x', 'y', '\a', '{', '\x2', 
		'\x2', 'y', '\x1B', '\x3', '\x2', '\x2', '\x2', 'z', '~', '\a', '\f', 
		'\x2', '\x2', '{', '}', '\x5', '\x4', '\x2', '\x2', '|', '{', '\x3', '\x2', 
		'\x2', '\x2', '}', '\x80', '\x3', '\x2', '\x2', '\x2', '~', '|', '\x3', 
		'\x2', '\x2', '\x2', '~', '\x7F', '\x3', '\x2', '\x2', '\x2', '\x7F', 
		'\x81', '\x3', '\x2', '\x2', '\x2', '\x80', '~', '\x3', '\x2', '\x2', 
		'\x2', '\x81', '\x82', '\n', '\x5', '\x2', '\x2', '\x82', '\x83', '\x3', 
		'\x2', '\x2', '\x2', '\x83', '\x84', '\b', '\xE', '\x4', '\x2', '\x84', 
		'\x1D', '\x3', '\x2', '\x2', '\x2', '\x85', '\x89', '\a', '$', '\x2', 
		'\x2', '\x86', '\x88', '\n', '\x6', '\x2', '\x2', '\x87', '\x86', '\x3', 
		'\x2', '\x2', '\x2', '\x88', '\x8B', '\x3', '\x2', '\x2', '\x2', '\x89', 
		'\x87', '\x3', '\x2', '\x2', '\x2', '\x89', '\x8A', '\x3', '\x2', '\x2', 
		'\x2', '\x8A', '\x8C', '\x3', '\x2', '\x2', '\x2', '\x8B', '\x89', '\x3', 
		'\x2', '\x2', '\x2', '\x8C', '\x8D', '\a', '$', '\x2', '\x2', '\x8D', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '\x8E', '\x8F', '\a', '*', '\x2', 
		'\x2', '\x8F', '!', '\x3', '\x2', '\x2', '\x2', '\x90', '\x91', '\a', 
		'.', '\x2', '\x2', '\x91', '#', '\x3', '\x2', '\x2', '\x2', '\x92', '\x93', 
		'\a', '+', '\x2', '\x2', '\x93', '%', '\x3', '\x2', '\x2', '\x2', '\x94', 
		'\x96', '\t', '\a', '\x2', '\x2', '\x95', '\x97', '\t', '\b', '\x2', '\x2', 
		'\x96', '\x95', '\x3', '\x2', '\x2', '\x2', '\x97', '\x98', '\x3', '\x2', 
		'\x2', '\x2', '\x98', '\x96', '\x3', '\x2', '\x2', '\x2', '\x98', '\x99', 
		'\x3', '\x2', '\x2', '\x2', '\x99', '\xAB', '\x3', '\x2', '\x2', '\x2', 
		'\x9A', '\x9B', '\a', '&', '\x2', '\x2', '\x9B', '\x9D', '\t', '\a', '\x2', 
		'\x2', '\x9C', '\x9E', '\t', '\b', '\x2', '\x2', '\x9D', '\x9C', '\x3', 
		'\x2', '\x2', '\x2', '\x9E', '\x9F', '\x3', '\x2', '\x2', '\x2', '\x9F', 
		'\x9D', '\x3', '\x2', '\x2', '\x2', '\x9F', '\xA0', '\x3', '\x2', '\x2', 
		'\x2', '\xA0', '\xA1', '\x3', '\x2', '\x2', '\x2', '\xA1', '\xAB', '\a', 
		'&', '\x2', '\x2', '\xA2', '\xA3', '\a', '\'', '\x2', '\x2', '\xA3', '\xA5', 
		'\t', '\a', '\x2', '\x2', '\xA4', '\xA6', '\t', '\b', '\x2', '\x2', '\xA5', 
		'\xA4', '\x3', '\x2', '\x2', '\x2', '\xA6', '\xA7', '\x3', '\x2', '\x2', 
		'\x2', '\xA7', '\xA5', '\x3', '\x2', '\x2', '\x2', '\xA7', '\xA8', '\x3', 
		'\x2', '\x2', '\x2', '\xA8', '\xA9', '\x3', '\x2', '\x2', '\x2', '\xA9', 
		'\xAB', '\a', '\'', '\x2', '\x2', '\xAA', '\x94', '\x3', '\x2', '\x2', 
		'\x2', '\xAA', '\x9A', '\x3', '\x2', '\x2', '\x2', '\xAA', '\xA2', '\x3', 
		'\x2', '\x2', '\x2', '\xAB', '\'', '\x3', '\x2', '\x2', '\x2', '\xAC', 
		'\xAD', '\t', '\x3', '\x2', '\x2', '\xAD', '\xAE', '\x3', '\x2', '\x2', 
		'\x2', '\xAE', '\xAF', '\b', '\x14', '\x3', '\x2', '\xAF', ')', '\x3', 
		'\x2', '\x2', '\x2', '\xB0', '\xB1', '\a', '\xF', '\x2', '\x2', '\xB1', 
		'\xB2', '\x3', '\x2', '\x2', '\x2', '\xB2', '\xB3', '\b', '\x15', '\x3', 
		'\x2', '\xB3', '+', '\x3', '\x2', '\x2', '\x2', '\xB4', '\xB5', '\v', 
		'\x2', '\x2', '\x2', '\xB5', '-', '\x3', '\x2', '\x2', '\x2', '\xF', '\x2', 
		'\x3', '\x33', '=', '\x44', 'L', 'T', '~', '\x89', '\x98', '\x9F', '\xA7', 
		'\xAA', '\x5', '\a', '\x3', '\x2', '\b', '\x2', '\x2', '\x6', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace MFSH
