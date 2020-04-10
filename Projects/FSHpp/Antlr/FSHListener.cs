//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from FSH.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace FSHpp {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="FSHParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IFSHListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.doc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDoc([NotNull] FSHParser.DocContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.doc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDoc([NotNull] FSHParser.DocContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.entity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEntity([NotNull] FSHParser.EntityContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.entity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEntity([NotNull] FSHParser.EntityContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlias([NotNull] FSHParser.AliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlias([NotNull] FSHParser.AliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.profile"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProfile([NotNull] FSHParser.ProfileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.profile"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProfile([NotNull] FSHParser.ProfileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.extension"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExtension([NotNull] FSHParser.ExtensionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.extension"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExtension([NotNull] FSHParser.ExtensionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.sdMetadata"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSdMetadata([NotNull] FSHParser.SdMetadataContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.sdMetadata"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSdMetadata([NotNull] FSHParser.SdMetadataContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.sdRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSdRule([NotNull] FSHParser.SdRuleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.sdRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSdRule([NotNull] FSHParser.SdRuleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.instance"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstance([NotNull] FSHParser.InstanceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.instance"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstance([NotNull] FSHParser.InstanceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.instanceMetadata"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstanceMetadata([NotNull] FSHParser.InstanceMetadataContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.instanceMetadata"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstanceMetadata([NotNull] FSHParser.InstanceMetadataContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.invariant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInvariant([NotNull] FSHParser.InvariantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.invariant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInvariant([NotNull] FSHParser.InvariantContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.invariantMetadata"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInvariantMetadata([NotNull] FSHParser.InvariantMetadataContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.invariantMetadata"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInvariantMetadata([NotNull] FSHParser.InvariantMetadataContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.valueSet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValueSet([NotNull] FSHParser.ValueSetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.valueSet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValueSet([NotNull] FSHParser.ValueSetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.vsMetadata"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVsMetadata([NotNull] FSHParser.VsMetadataContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.vsMetadata"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVsMetadata([NotNull] FSHParser.VsMetadataContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.codeSystem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCodeSystem([NotNull] FSHParser.CodeSystemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.codeSystem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCodeSystem([NotNull] FSHParser.CodeSystemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.csMetadata"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCsMetadata([NotNull] FSHParser.CsMetadataContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.csMetadata"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCsMetadata([NotNull] FSHParser.CsMetadataContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.ruleSet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRuleSet([NotNull] FSHParser.RuleSetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.ruleSet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRuleSet([NotNull] FSHParser.RuleSetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.mapping"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMapping([NotNull] FSHParser.MappingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.mapping"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMapping([NotNull] FSHParser.MappingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.mappingMetadata"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMappingMetadata([NotNull] FSHParser.MappingMetadataContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.mappingMetadata"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMappingMetadata([NotNull] FSHParser.MappingMetadataContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.parent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParent([NotNull] FSHParser.ParentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.parent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParent([NotNull] FSHParser.ParentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterId([NotNull] FSHParser.IdContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitId([NotNull] FSHParser.IdContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.title"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTitle([NotNull] FSHParser.TitleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.title"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTitle([NotNull] FSHParser.TitleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.description"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDescription([NotNull] FSHParser.DescriptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.description"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDescription([NotNull] FSHParser.DescriptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] FSHParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] FSHParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.xpath"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXpath([NotNull] FSHParser.XpathContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.xpath"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXpath([NotNull] FSHParser.XpathContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.severity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSeverity([NotNull] FSHParser.SeverityContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.severity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSeverity([NotNull] FSHParser.SeverityContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.instanceOf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstanceOf([NotNull] FSHParser.InstanceOfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.instanceOf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstanceOf([NotNull] FSHParser.InstanceOfContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.usage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUsage([NotNull] FSHParser.UsageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.usage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUsage([NotNull] FSHParser.UsageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.mixins"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMixins([NotNull] FSHParser.MixinsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.mixins"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMixins([NotNull] FSHParser.MixinsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.source"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSource([NotNull] FSHParser.SourceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.source"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSource([NotNull] FSHParser.SourceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTarget([NotNull] FSHParser.TargetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTarget([NotNull] FSHParser.TargetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.cardRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCardRule([NotNull] FSHParser.CardRuleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.cardRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCardRule([NotNull] FSHParser.CardRuleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.flagRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFlagRule([NotNull] FSHParser.FlagRuleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.flagRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFlagRule([NotNull] FSHParser.FlagRuleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.valueSetRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValueSetRule([NotNull] FSHParser.ValueSetRuleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.valueSetRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValueSetRule([NotNull] FSHParser.ValueSetRuleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.fixedValueRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFixedValueRule([NotNull] FSHParser.FixedValueRuleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.fixedValueRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFixedValueRule([NotNull] FSHParser.FixedValueRuleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.containsRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterContainsRule([NotNull] FSHParser.ContainsRuleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.containsRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitContainsRule([NotNull] FSHParser.ContainsRuleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.onlyRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOnlyRule([NotNull] FSHParser.OnlyRuleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.onlyRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOnlyRule([NotNull] FSHParser.OnlyRuleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.obeysRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObeysRule([NotNull] FSHParser.ObeysRuleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.obeysRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObeysRule([NotNull] FSHParser.ObeysRuleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.caretValueRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCaretValueRule([NotNull] FSHParser.CaretValueRuleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.caretValueRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCaretValueRule([NotNull] FSHParser.CaretValueRuleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.mappingRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMappingRule([NotNull] FSHParser.MappingRuleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.mappingRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMappingRule([NotNull] FSHParser.MappingRuleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.macroRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMacroRule([NotNull] FSHParser.MacroRuleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.macroRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMacroRule([NotNull] FSHParser.MacroRuleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.vsComponent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVsComponent([NotNull] FSHParser.VsComponentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.vsComponent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVsComponent([NotNull] FSHParser.VsComponentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.vsConceptComponent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVsConceptComponent([NotNull] FSHParser.VsConceptComponentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.vsConceptComponent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVsConceptComponent([NotNull] FSHParser.VsConceptComponentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.vsFilterComponent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVsFilterComponent([NotNull] FSHParser.VsFilterComponentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.vsFilterComponent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVsFilterComponent([NotNull] FSHParser.VsFilterComponentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.vsComponentFrom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVsComponentFrom([NotNull] FSHParser.VsComponentFromContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.vsComponentFrom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVsComponentFrom([NotNull] FSHParser.VsComponentFromContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.vsFromSystem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVsFromSystem([NotNull] FSHParser.VsFromSystemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.vsFromSystem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVsFromSystem([NotNull] FSHParser.VsFromSystemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.vsFromValueset"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVsFromValueset([NotNull] FSHParser.VsFromValuesetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.vsFromValueset"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVsFromValueset([NotNull] FSHParser.VsFromValuesetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.vsFilterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVsFilterList([NotNull] FSHParser.VsFilterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.vsFilterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVsFilterList([NotNull] FSHParser.VsFilterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.vsFilterDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVsFilterDefinition([NotNull] FSHParser.VsFilterDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.vsFilterDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVsFilterDefinition([NotNull] FSHParser.VsFilterDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.vsFilterOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVsFilterOperator([NotNull] FSHParser.VsFilterOperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.vsFilterOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVsFilterOperator([NotNull] FSHParser.VsFilterOperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.vsFilterValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVsFilterValue([NotNull] FSHParser.VsFilterValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.vsFilterValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVsFilterValue([NotNull] FSHParser.VsFilterValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPath([NotNull] FSHParser.PathContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPath([NotNull] FSHParser.PathContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.paths"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPaths([NotNull] FSHParser.PathsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.paths"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPaths([NotNull] FSHParser.PathsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.caretPath"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCaretPath([NotNull] FSHParser.CaretPathContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.caretPath"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCaretPath([NotNull] FSHParser.CaretPathContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.flag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFlag([NotNull] FSHParser.FlagContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.flag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFlag([NotNull] FSHParser.FlagContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.strength"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStrength([NotNull] FSHParser.StrengthContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.strength"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStrength([NotNull] FSHParser.StrengthContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValue([NotNull] FSHParser.ValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValue([NotNull] FSHParser.ValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterItem([NotNull] FSHParser.ItemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitItem([NotNull] FSHParser.ItemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.code"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCode([NotNull] FSHParser.CodeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.code"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCode([NotNull] FSHParser.CodeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.concept"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConcept([NotNull] FSHParser.ConceptContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.concept"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConcept([NotNull] FSHParser.ConceptContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.quantity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuantity([NotNull] FSHParser.QuantityContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.quantity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuantity([NotNull] FSHParser.QuantityContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.ratio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRatio([NotNull] FSHParser.RatioContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.ratio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRatio([NotNull] FSHParser.RatioContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.reference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReference([NotNull] FSHParser.ReferenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.reference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReference([NotNull] FSHParser.ReferenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.ratioPart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRatioPart([NotNull] FSHParser.RatioPartContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.ratioPart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRatioPart([NotNull] FSHParser.RatioPartContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.bool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBool([NotNull] FSHParser.BoolContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.bool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBool([NotNull] FSHParser.BoolContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FSHParser.targetType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTargetType([NotNull] FSHParser.TargetTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FSHParser.targetType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTargetType([NotNull] FSHParser.TargetTypeContext context);
}
} // namespace FSHpp
