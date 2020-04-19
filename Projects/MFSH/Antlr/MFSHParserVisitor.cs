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
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="MFSHParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IMFSHParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.document"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDocument([NotNull] MFSHParser.DocumentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.fsh"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFsh([NotNull] MFSHParser.FshContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.mCommands"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMCommands([NotNull] MFSHParser.MCommandsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.mModeStart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMModeStart([NotNull] MFSHParser.MModeStartContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.mModeEnd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMModeEnd([NotNull] MFSHParser.MModeEndContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.mCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMCommand([NotNull] MFSHParser.MCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.mInclude"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMInclude([NotNull] MFSHParser.MIncludeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.mUse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMUse([NotNull] MFSHParser.MUseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.mMacro"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMMacro([NotNull] MFSHParser.MMacroContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.mApply"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMApply([NotNull] MFSHParser.MApplyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.mEnd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMEnd([NotNull] MFSHParser.MEndContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.mString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMString([NotNull] MFSHParser.MStringContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.mlString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMlString([NotNull] MFSHParser.MlStringContext context);
}
} // namespace MFSH
