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

namespace Eir.MFSH.Parser {
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
		MFSH=1, TEXTA=2, TEXTB=3, TEXTC=4, TEXTD=5, TICKTEXT=6, CR=7, APPLY=8, 
		END=9, INCOMPATIBLE=10, MACRO=11, ONCE=12, USE=13, STRING=14, MULTILINE_STRING=15, 
		OPAR=16, COMMA=17, CPAR=18, GT=19, NAME=20, MFSHCont=21, MFSHExit=22, 
		MFSHCR=23, MFSH_SPACE=24;
	public const int
		MFSHMode=1;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE", "MFSHMode"
	};

	public static readonly string[] ruleNames = {
		"MFSH", "TEXTA", "TEXTB", "TEXTC", "TEXTD", "TICKTEXT", "CR", "APPLY", 
		"END", "INCOMPATIBLE", "MACRO", "ONCE", "USE", "STRING", "MULTILINE_STRING", 
		"OPAR", "COMMA", "CPAR", "GT", "NAME", "MFSHCont", "MFSHExit", "MFSHCR", 
		"MFSH_SPACE"
	};


	public MFSHLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public MFSHLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, null, null, "'apply'", "'end'", "'incompatible'", 
		"'macro'", "'once'", "'use'", null, null, "'('", "','", "')'", "'>'", 
		null, null, "'\n'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "MFSH", "TEXTA", "TEXTB", "TEXTC", "TEXTD", "TICKTEXT", "CR", "APPLY", 
		"END", "INCOMPATIBLE", "MACRO", "ONCE", "USE", "STRING", "MULTILINE_STRING", 
		"OPAR", "COMMA", "CPAR", "GT", "NAME", "MFSHCont", "MFSHExit", "MFSHCR", 
		"MFSH_SPACE"
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
		'\x5964', '\x2', '\x1A', '\x101', '\b', '\x1', '\b', '\x1', '\x4', '\x2', 
		'\t', '\x2', '\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', 
		'\x5', '\t', '\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', 
		'\x4', '\b', '\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', 
		'\x4', '\v', '\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', 
		'\x4', '\xE', '\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', 
		'\x10', '\x4', '\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', 
		'\x13', '\t', '\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', 
		'\x15', '\x4', '\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', 
		'\x18', '\t', '\x18', '\x4', '\x19', '\t', '\x19', '\x3', '\x2', '\a', 
		'\x2', '\x36', '\n', '\x2', '\f', '\x2', '\xE', '\x2', '\x39', '\v', '\x2', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', 
		'\a', '\x3', '@', '\n', '\x3', '\f', '\x3', '\xE', '\x3', '\x43', '\v', 
		'\x3', '\x3', '\x3', '\x6', '\x3', '\x46', '\n', '\x3', '\r', '\x3', '\xE', 
		'\x3', 'G', '\x3', '\x3', '\a', '\x3', 'K', '\n', '\x3', '\f', '\x3', 
		'\xE', '\x3', 'N', '\v', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', 
		'\a', '\x4', 'S', '\n', '\x4', '\f', '\x4', '\xE', '\x4', 'V', '\v', '\x4', 
		'\x3', '\x4', '\x6', '\x4', 'Y', '\n', '\x4', '\r', '\x4', '\xE', '\x4', 
		'Z', '\x3', '\x4', '\a', '\x4', '^', '\n', '\x4', '\f', '\x4', '\xE', 
		'\x4', '\x61', '\v', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', 
		'\a', '\x5', '\x66', '\n', '\x5', '\f', '\x5', '\xE', '\x5', 'i', '\v', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\a', '\x6', 'n', '\n', 
		'\x6', '\f', '\x6', '\xE', '\x6', 'q', '\v', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\a', '\a', 'v', '\n', '\a', '\f', '\a', '\xE', '\a', 
		'y', '\v', '\a', '\x3', '\a', '\x3', '\a', '\a', '\a', '}', '\n', '\a', 
		'\f', '\a', '\xE', '\a', '\x80', '\v', '\a', '\x3', '\a', '\x5', '\a', 
		'\x83', '\n', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\a', '\xF', '\xB3', 
		'\n', '\xF', '\f', '\xF', '\xE', '\xF', '\xB6', '\v', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\a', '\x10', '\xBF', '\n', '\x10', '\f', '\x10', '\xE', 
		'\x10', '\xC2', '\v', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', 
		'\x3', '\x15', '\x6', '\x15', '\xD2', '\n', '\x15', '\r', '\x15', '\xE', 
		'\x15', '\xD3', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x6', '\x15', 
		'\xD9', '\n', '\x15', '\r', '\x15', '\xE', '\x15', '\xDA', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x6', '\x15', '\xE1', '\n', 
		'\x15', '\r', '\x15', '\xE', '\x15', '\xE2', '\x3', '\x15', '\x5', '\x15', 
		'\xE6', '\n', '\x15', '\x3', '\x16', '\x3', '\x16', '\a', '\x16', '\xEA', 
		'\n', '\x16', '\f', '\x16', '\xE', '\x16', '\xED', '\v', '\x16', '\x3', 
		'\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x17', '\x3', 
		'\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', '\x3', '\x18', '\x3', 
		'\x18', '\x3', '\x18', '\x3', '\x19', '\x6', '\x19', '\xFC', '\n', '\x19', 
		'\r', '\x19', '\xE', '\x19', '\xFD', '\x3', '\x19', '\x3', '\x19', '\x3', 
		'\xC0', '\x2', '\x1A', '\x4', '\x3', '\x6', '\x4', '\b', '\x5', '\n', 
		'\x6', '\f', '\a', '\xE', '\b', '\x10', '\t', '\x12', '\n', '\x14', '\v', 
		'\x16', '\f', '\x18', '\r', '\x1A', '\xE', '\x1C', '\xF', '\x1E', '\x10', 
		' ', '\x11', '\"', '\x12', '$', '\x13', '&', '\x14', '(', '\x15', '*', 
		'\x16', ',', '\x17', '.', '\x18', '\x30', '\x19', '\x32', '\x1A', '\x4', 
		'\x2', '\x3', '\t', '\x4', '\x2', '\v', '\v', '\"', '\"', '\x6', '\x2', 
		'\v', '\f', '\"', '\"', '%', '%', '\x62', '\x62', '\x3', '\x2', '\f', 
		'\f', '\x3', '\x3', '\f', '\f', '\x6', '\x2', '\f', '\f', '\xF', '\xF', 
		'$', '$', '^', '^', '\x4', '\x2', '\x43', '\\', '\x63', '|', '\x6', '\x2', 
		'\x30', '\x30', '\x32', ';', '\x43', '\\', '\x63', '|', '\x2', '\x114', 
		'\x2', '\x4', '\x3', '\x2', '\x2', '\x2', '\x2', '\x6', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\b', '\x3', '\x2', '\x2', '\x2', '\x2', '\n', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\f', '\x3', '\x2', '\x2', '\x2', '\x2', '\xE', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x10', '\x3', '\x2', '\x2', '\x2', 
		'\x3', '\x12', '\x3', '\x2', '\x2', '\x2', '\x3', '\x14', '\x3', '\x2', 
		'\x2', '\x2', '\x3', '\x16', '\x3', '\x2', '\x2', '\x2', '\x3', '\x18', 
		'\x3', '\x2', '\x2', '\x2', '\x3', '\x1A', '\x3', '\x2', '\x2', '\x2', 
		'\x3', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x3', '\x1E', '\x3', '\x2', 
		'\x2', '\x2', '\x3', ' ', '\x3', '\x2', '\x2', '\x2', '\x3', '\"', '\x3', 
		'\x2', '\x2', '\x2', '\x3', '$', '\x3', '\x2', '\x2', '\x2', '\x3', '&', 
		'\x3', '\x2', '\x2', '\x2', '\x3', '(', '\x3', '\x2', '\x2', '\x2', '\x3', 
		'*', '\x3', '\x2', '\x2', '\x2', '\x3', ',', '\x3', '\x2', '\x2', '\x2', 
		'\x3', '.', '\x3', '\x2', '\x2', '\x2', '\x3', '\x30', '\x3', '\x2', '\x2', 
		'\x2', '\x3', '\x32', '\x3', '\x2', '\x2', '\x2', '\x4', '\x37', '\x3', 
		'\x2', '\x2', '\x2', '\x6', '\x41', '\x3', '\x2', '\x2', '\x2', '\b', 
		'T', '\x3', '\x2', '\x2', '\x2', '\n', 'g', '\x3', '\x2', '\x2', '\x2', 
		'\f', 'o', '\x3', '\x2', '\x2', '\x2', '\xE', 'w', '\x3', '\x2', '\x2', 
		'\x2', '\x10', '\x84', '\x3', '\x2', '\x2', '\x2', '\x12', '\x88', '\x3', 
		'\x2', '\x2', '\x2', '\x14', '\x8E', '\x3', '\x2', '\x2', '\x2', '\x16', 
		'\x92', '\x3', '\x2', '\x2', '\x2', '\x18', '\x9F', '\x3', '\x2', '\x2', 
		'\x2', '\x1A', '\xA5', '\x3', '\x2', '\x2', '\x2', '\x1C', '\xAA', '\x3', 
		'\x2', '\x2', '\x2', '\x1E', '\xAE', '\x3', '\x2', '\x2', '\x2', ' ', 
		'\xB9', '\x3', '\x2', '\x2', '\x2', '\"', '\xC7', '\x3', '\x2', '\x2', 
		'\x2', '$', '\xC9', '\x3', '\x2', '\x2', '\x2', '&', '\xCB', '\x3', '\x2', 
		'\x2', '\x2', '(', '\xCD', '\x3', '\x2', '\x2', '\x2', '*', '\xE5', '\x3', 
		'\x2', '\x2', '\x2', ',', '\xE7', '\x3', '\x2', '\x2', '\x2', '.', '\xF2', 
		'\x3', '\x2', '\x2', '\x2', '\x30', '\xF6', '\x3', '\x2', '\x2', '\x2', 
		'\x32', '\xFB', '\x3', '\x2', '\x2', '\x2', '\x34', '\x36', '\t', '\x2', 
		'\x2', '\x2', '\x35', '\x34', '\x3', '\x2', '\x2', '\x2', '\x36', '\x39', 
		'\x3', '\x2', '\x2', '\x2', '\x37', '\x35', '\x3', '\x2', '\x2', '\x2', 
		'\x37', '\x38', '\x3', '\x2', '\x2', '\x2', '\x38', ':', '\x3', '\x2', 
		'\x2', '\x2', '\x39', '\x37', '\x3', '\x2', '\x2', '\x2', ':', ';', '\a', 
		'%', '\x2', '\x2', ';', '<', '\x3', '\x2', '\x2', '\x2', '<', '=', '\b', 
		'\x2', '\x2', '\x2', '=', '\x5', '\x3', '\x2', '\x2', '\x2', '>', '@', 
		'\t', '\x2', '\x2', '\x2', '?', '>', '\x3', '\x2', '\x2', '\x2', '@', 
		'\x43', '\x3', '\x2', '\x2', '\x2', '\x41', '?', '\x3', '\x2', '\x2', 
		'\x2', '\x41', '\x42', '\x3', '\x2', '\x2', '\x2', '\x42', '\x45', '\x3', 
		'\x2', '\x2', '\x2', '\x43', '\x41', '\x3', '\x2', '\x2', '\x2', '\x44', 
		'\x46', '\n', '\x3', '\x2', '\x2', '\x45', '\x44', '\x3', '\x2', '\x2', 
		'\x2', '\x46', 'G', '\x3', '\x2', '\x2', '\x2', 'G', '\x45', '\x3', '\x2', 
		'\x2', '\x2', 'G', 'H', '\x3', '\x2', '\x2', '\x2', 'H', 'L', '\x3', '\x2', 
		'\x2', '\x2', 'I', 'K', '\n', '\x4', '\x2', '\x2', 'J', 'I', '\x3', '\x2', 
		'\x2', '\x2', 'K', 'N', '\x3', '\x2', '\x2', '\x2', 'L', 'J', '\x3', '\x2', 
		'\x2', '\x2', 'L', 'M', '\x3', '\x2', '\x2', '\x2', 'M', 'O', '\x3', '\x2', 
		'\x2', '\x2', 'N', 'L', '\x3', '\x2', '\x2', '\x2', 'O', 'P', '\a', '\f', 
		'\x2', '\x2', 'P', '\a', '\x3', '\x2', '\x2', '\x2', 'Q', 'S', '\t', '\x2', 
		'\x2', '\x2', 'R', 'Q', '\x3', '\x2', '\x2', '\x2', 'S', 'V', '\x3', '\x2', 
		'\x2', '\x2', 'T', 'R', '\x3', '\x2', '\x2', '\x2', 'T', 'U', '\x3', '\x2', 
		'\x2', '\x2', 'U', 'X', '\x3', '\x2', '\x2', '\x2', 'V', 'T', '\x3', '\x2', 
		'\x2', '\x2', 'W', 'Y', '\n', '\x3', '\x2', '\x2', 'X', 'W', '\x3', '\x2', 
		'\x2', '\x2', 'Y', 'Z', '\x3', '\x2', '\x2', '\x2', 'Z', 'X', '\x3', '\x2', 
		'\x2', '\x2', 'Z', '[', '\x3', '\x2', '\x2', '\x2', '[', '_', '\x3', '\x2', 
		'\x2', '\x2', '\\', '^', '\n', '\x4', '\x2', '\x2', ']', '\\', '\x3', 
		'\x2', '\x2', '\x2', '^', '\x61', '\x3', '\x2', '\x2', '\x2', '_', ']', 
		'\x3', '\x2', '\x2', '\x2', '_', '`', '\x3', '\x2', '\x2', '\x2', '`', 
		'\x62', '\x3', '\x2', '\x2', '\x2', '\x61', '_', '\x3', '\x2', '\x2', 
		'\x2', '\x62', '\x63', '\a', '\x2', '\x2', '\x3', '\x63', '\t', '\x3', 
		'\x2', '\x2', '\x2', '\x64', '\x66', '\t', '\x2', '\x2', '\x2', '\x65', 
		'\x64', '\x3', '\x2', '\x2', '\x2', '\x66', 'i', '\x3', '\x2', '\x2', 
		'\x2', 'g', '\x65', '\x3', '\x2', '\x2', '\x2', 'g', 'h', '\x3', '\x2', 
		'\x2', '\x2', 'h', 'j', '\x3', '\x2', '\x2', '\x2', 'i', 'g', '\x3', '\x2', 
		'\x2', '\x2', 'j', 'k', '\a', '\f', '\x2', '\x2', 'k', '\v', '\x3', '\x2', 
		'\x2', '\x2', 'l', 'n', '\t', '\x2', '\x2', '\x2', 'm', 'l', '\x3', '\x2', 
		'\x2', '\x2', 'n', 'q', '\x3', '\x2', '\x2', '\x2', 'o', 'm', '\x3', '\x2', 
		'\x2', '\x2', 'o', 'p', '\x3', '\x2', '\x2', '\x2', 'p', 'r', '\x3', '\x2', 
		'\x2', '\x2', 'q', 'o', '\x3', '\x2', '\x2', '\x2', 'r', 's', '\a', '\x2', 
		'\x2', '\x3', 's', '\r', '\x3', '\x2', '\x2', '\x2', 't', 'v', '\t', '\x2', 
		'\x2', '\x2', 'u', 't', '\x3', '\x2', '\x2', '\x2', 'v', 'y', '\x3', '\x2', 
		'\x2', '\x2', 'w', 'u', '\x3', '\x2', '\x2', '\x2', 'w', 'x', '\x3', '\x2', 
		'\x2', '\x2', 'x', 'z', '\x3', '\x2', '\x2', '\x2', 'y', 'w', '\x3', '\x2', 
		'\x2', '\x2', 'z', '~', '\a', '\x62', '\x2', '\x2', '{', '}', '\n', '\x4', 
		'\x2', '\x2', '|', '{', '\x3', '\x2', '\x2', '\x2', '}', '\x80', '\x3', 
		'\x2', '\x2', '\x2', '~', '|', '\x3', '\x2', '\x2', '\x2', '~', '\x7F', 
		'\x3', '\x2', '\x2', '\x2', '\x7F', '\x82', '\x3', '\x2', '\x2', '\x2', 
		'\x80', '~', '\x3', '\x2', '\x2', '\x2', '\x81', '\x83', '\t', '\x5', 
		'\x2', '\x2', '\x82', '\x81', '\x3', '\x2', '\x2', '\x2', '\x83', '\xF', 
		'\x3', '\x2', '\x2', '\x2', '\x84', '\x85', '\a', '\xF', '\x2', '\x2', 
		'\x85', '\x86', '\x3', '\x2', '\x2', '\x2', '\x86', '\x87', '\b', '\b', 
		'\x3', '\x2', '\x87', '\x11', '\x3', '\x2', '\x2', '\x2', '\x88', '\x89', 
		'\a', '\x63', '\x2', '\x2', '\x89', '\x8A', '\a', 'r', '\x2', '\x2', '\x8A', 
		'\x8B', '\a', 'r', '\x2', '\x2', '\x8B', '\x8C', '\a', 'n', '\x2', '\x2', 
		'\x8C', '\x8D', '\a', '{', '\x2', '\x2', '\x8D', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x8E', '\x8F', '\a', 'g', '\x2', '\x2', '\x8F', '\x90', 
		'\a', 'p', '\x2', '\x2', '\x90', '\x91', '\a', '\x66', '\x2', '\x2', '\x91', 
		'\x15', '\x3', '\x2', '\x2', '\x2', '\x92', '\x93', '\a', 'k', '\x2', 
		'\x2', '\x93', '\x94', '\a', 'p', '\x2', '\x2', '\x94', '\x95', '\a', 
		'\x65', '\x2', '\x2', '\x95', '\x96', '\a', 'q', '\x2', '\x2', '\x96', 
		'\x97', '\a', 'o', '\x2', '\x2', '\x97', '\x98', '\a', 'r', '\x2', '\x2', 
		'\x98', '\x99', '\a', '\x63', '\x2', '\x2', '\x99', '\x9A', '\a', 'v', 
		'\x2', '\x2', '\x9A', '\x9B', '\a', 'k', '\x2', '\x2', '\x9B', '\x9C', 
		'\a', '\x64', '\x2', '\x2', '\x9C', '\x9D', '\a', 'n', '\x2', '\x2', '\x9D', 
		'\x9E', '\a', 'g', '\x2', '\x2', '\x9E', '\x17', '\x3', '\x2', '\x2', 
		'\x2', '\x9F', '\xA0', '\a', 'o', '\x2', '\x2', '\xA0', '\xA1', '\a', 
		'\x63', '\x2', '\x2', '\xA1', '\xA2', '\a', '\x65', '\x2', '\x2', '\xA2', 
		'\xA3', '\a', 't', '\x2', '\x2', '\xA3', '\xA4', '\a', 'q', '\x2', '\x2', 
		'\xA4', '\x19', '\x3', '\x2', '\x2', '\x2', '\xA5', '\xA6', '\a', 'q', 
		'\x2', '\x2', '\xA6', '\xA7', '\a', 'p', '\x2', '\x2', '\xA7', '\xA8', 
		'\a', '\x65', '\x2', '\x2', '\xA8', '\xA9', '\a', 'g', '\x2', '\x2', '\xA9', 
		'\x1B', '\x3', '\x2', '\x2', '\x2', '\xAA', '\xAB', '\a', 'w', '\x2', 
		'\x2', '\xAB', '\xAC', '\a', 'u', '\x2', '\x2', '\xAC', '\xAD', '\a', 
		'g', '\x2', '\x2', '\xAD', '\x1D', '\x3', '\x2', '\x2', '\x2', '\xAE', 
		'\xB4', '\a', '$', '\x2', '\x2', '\xAF', '\xB3', '\n', '\x6', '\x2', '\x2', 
		'\xB0', '\xB1', '\a', '^', '\x2', '\x2', '\xB1', '\xB3', '\v', '\x2', 
		'\x2', '\x2', '\xB2', '\xAF', '\x3', '\x2', '\x2', '\x2', '\xB2', '\xB0', 
		'\x3', '\x2', '\x2', '\x2', '\xB3', '\xB6', '\x3', '\x2', '\x2', '\x2', 
		'\xB4', '\xB2', '\x3', '\x2', '\x2', '\x2', '\xB4', '\xB5', '\x3', '\x2', 
		'\x2', '\x2', '\xB5', '\xB7', '\x3', '\x2', '\x2', '\x2', '\xB6', '\xB4', 
		'\x3', '\x2', '\x2', '\x2', '\xB7', '\xB8', '\a', '$', '\x2', '\x2', '\xB8', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '\xB9', '\xBA', '\a', '$', '\x2', 
		'\x2', '\xBA', '\xBB', '\a', '$', '\x2', '\x2', '\xBB', '\xBC', '\a', 
		'$', '\x2', '\x2', '\xBC', '\xC0', '\x3', '\x2', '\x2', '\x2', '\xBD', 
		'\xBF', '\v', '\x2', '\x2', '\x2', '\xBE', '\xBD', '\x3', '\x2', '\x2', 
		'\x2', '\xBF', '\xC2', '\x3', '\x2', '\x2', '\x2', '\xC0', '\xC1', '\x3', 
		'\x2', '\x2', '\x2', '\xC0', '\xBE', '\x3', '\x2', '\x2', '\x2', '\xC1', 
		'\xC3', '\x3', '\x2', '\x2', '\x2', '\xC2', '\xC0', '\x3', '\x2', '\x2', 
		'\x2', '\xC3', '\xC4', '\a', '$', '\x2', '\x2', '\xC4', '\xC5', '\a', 
		'$', '\x2', '\x2', '\xC5', '\xC6', '\a', '$', '\x2', '\x2', '\xC6', '!', 
		'\x3', '\x2', '\x2', '\x2', '\xC7', '\xC8', '\a', '*', '\x2', '\x2', '\xC8', 
		'#', '\x3', '\x2', '\x2', '\x2', '\xC9', '\xCA', '\a', '.', '\x2', '\x2', 
		'\xCA', '%', '\x3', '\x2', '\x2', '\x2', '\xCB', '\xCC', '\a', '+', '\x2', 
		'\x2', '\xCC', '\'', '\x3', '\x2', '\x2', '\x2', '\xCD', '\xCE', '\a', 
		'@', '\x2', '\x2', '\xCE', ')', '\x3', '\x2', '\x2', '\x2', '\xCF', '\xD1', 
		'\t', '\a', '\x2', '\x2', '\xD0', '\xD2', '\t', '\b', '\x2', '\x2', '\xD1', 
		'\xD0', '\x3', '\x2', '\x2', '\x2', '\xD2', '\xD3', '\x3', '\x2', '\x2', 
		'\x2', '\xD3', '\xD1', '\x3', '\x2', '\x2', '\x2', '\xD3', '\xD4', '\x3', 
		'\x2', '\x2', '\x2', '\xD4', '\xE6', '\x3', '\x2', '\x2', '\x2', '\xD5', 
		'\xD6', '\a', '&', '\x2', '\x2', '\xD6', '\xD8', '\t', '\a', '\x2', '\x2', 
		'\xD7', '\xD9', '\t', '\b', '\x2', '\x2', '\xD8', '\xD7', '\x3', '\x2', 
		'\x2', '\x2', '\xD9', '\xDA', '\x3', '\x2', '\x2', '\x2', '\xDA', '\xD8', 
		'\x3', '\x2', '\x2', '\x2', '\xDA', '\xDB', '\x3', '\x2', '\x2', '\x2', 
		'\xDB', '\xDC', '\x3', '\x2', '\x2', '\x2', '\xDC', '\xE6', '\a', '&', 
		'\x2', '\x2', '\xDD', '\xDE', '\a', '\'', '\x2', '\x2', '\xDE', '\xE0', 
		'\t', '\a', '\x2', '\x2', '\xDF', '\xE1', '\t', '\b', '\x2', '\x2', '\xE0', 
		'\xDF', '\x3', '\x2', '\x2', '\x2', '\xE1', '\xE2', '\x3', '\x2', '\x2', 
		'\x2', '\xE2', '\xE0', '\x3', '\x2', '\x2', '\x2', '\xE2', '\xE3', '\x3', 
		'\x2', '\x2', '\x2', '\xE3', '\xE4', '\x3', '\x2', '\x2', '\x2', '\xE4', 
		'\xE6', '\a', '\'', '\x2', '\x2', '\xE5', '\xCF', '\x3', '\x2', '\x2', 
		'\x2', '\xE5', '\xD5', '\x3', '\x2', '\x2', '\x2', '\xE5', '\xDD', '\x3', 
		'\x2', '\x2', '\x2', '\xE6', '+', '\x3', '\x2', '\x2', '\x2', '\xE7', 
		'\xEB', '\a', '\f', '\x2', '\x2', '\xE8', '\xEA', '\t', '\x2', '\x2', 
		'\x2', '\xE9', '\xE8', '\x3', '\x2', '\x2', '\x2', '\xEA', '\xED', '\x3', 
		'\x2', '\x2', '\x2', '\xEB', '\xE9', '\x3', '\x2', '\x2', '\x2', '\xEB', 
		'\xEC', '\x3', '\x2', '\x2', '\x2', '\xEC', '\xEE', '\x3', '\x2', '\x2', 
		'\x2', '\xED', '\xEB', '\x3', '\x2', '\x2', '\x2', '\xEE', '\xEF', '\a', 
		'%', '\x2', '\x2', '\xEF', '\xF0', '\x3', '\x2', '\x2', '\x2', '\xF0', 
		'\xF1', '\b', '\x16', '\x3', '\x2', '\xF1', '-', '\x3', '\x2', '\x2', 
		'\x2', '\xF2', '\xF3', '\a', '\f', '\x2', '\x2', '\xF3', '\xF4', '\x3', 
		'\x2', '\x2', '\x2', '\xF4', '\xF5', '\b', '\x17', '\x4', '\x2', '\xF5', 
		'/', '\x3', '\x2', '\x2', '\x2', '\xF6', '\xF7', '\a', '\xF', '\x2', '\x2', 
		'\xF7', '\xF8', '\x3', '\x2', '\x2', '\x2', '\xF8', '\xF9', '\b', '\x18', 
		'\x3', '\x2', '\xF9', '\x31', '\x3', '\x2', '\x2', '\x2', '\xFA', '\xFC', 
		'\t', '\x2', '\x2', '\x2', '\xFB', '\xFA', '\x3', '\x2', '\x2', '\x2', 
		'\xFC', '\xFD', '\x3', '\x2', '\x2', '\x2', '\xFD', '\xFB', '\x3', '\x2', 
		'\x2', '\x2', '\xFD', '\xFE', '\x3', '\x2', '\x2', '\x2', '\xFE', '\xFF', 
		'\x3', '\x2', '\x2', '\x2', '\xFF', '\x100', '\b', '\x19', '\x3', '\x2', 
		'\x100', '\x33', '\x3', '\x2', '\x2', '\x2', '\x19', '\x2', '\x3', '\x37', 
		'\x41', 'G', 'L', 'T', 'Z', '_', 'g', 'o', 'w', '~', '\x82', '\xB2', '\xB4', 
		'\xC0', '\xD3', '\xDA', '\xE2', '\xE5', '\xEB', '\xFD', '\x5', '\a', '\x3', 
		'\x2', '\b', '\x2', '\x2', '\x6', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Eir.MFSH.Parser
