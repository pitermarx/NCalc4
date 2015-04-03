//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\phmarques\Documents\GitHub\NCalc2\NCalc2\NCalc2.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace NCalc2.Grammar {

using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using NCalc2.Expressions;


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="INCalc2Listener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public partial class NCalc2BaseListener : INCalc2Listener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="NCalc2Parser.orExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrExpr([NotNull] NCalc2Parser.OrExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="NCalc2Parser.orExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrExpr([NotNull] NCalc2Parser.OrExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="NCalc2Parser.multExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultExpr([NotNull] NCalc2Parser.MultExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="NCalc2Parser.multExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultExpr([NotNull] NCalc2Parser.MultExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="NCalc2Parser.bitXorExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBitXorExpr([NotNull] NCalc2Parser.BitXorExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="NCalc2Parser.bitXorExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBitXorExpr([NotNull] NCalc2Parser.BitXorExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="NCalc2Parser.shiftExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShiftExpr([NotNull] NCalc2Parser.ShiftExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="NCalc2Parser.shiftExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShiftExpr([NotNull] NCalc2Parser.ShiftExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="NCalc2Parser.bitOrExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBitOrExpr([NotNull] NCalc2Parser.BitOrExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="NCalc2Parser.bitOrExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBitOrExpr([NotNull] NCalc2Parser.BitOrExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="NCalc2Parser.eqExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEqExpr([NotNull] NCalc2Parser.EqExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="NCalc2Parser.eqExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEqExpr([NotNull] NCalc2Parser.EqExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="NCalc2Parser.unaryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryExpr([NotNull] NCalc2Parser.UnaryExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="NCalc2Parser.unaryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryExpr([NotNull] NCalc2Parser.UnaryExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="NCalc2Parser.primaryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryExpr([NotNull] NCalc2Parser.PrimaryExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="NCalc2Parser.primaryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryExpr([NotNull] NCalc2Parser.PrimaryExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="NCalc2Parser.addExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddExpr([NotNull] NCalc2Parser.AddExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="NCalc2Parser.addExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddExpr([NotNull] NCalc2Parser.AddExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="NCalc2Parser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr([NotNull] NCalc2Parser.ExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="NCalc2Parser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr([NotNull] NCalc2Parser.ExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="NCalc2Parser.id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterId([NotNull] NCalc2Parser.IdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="NCalc2Parser.id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitId([NotNull] NCalc2Parser.IdContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="NCalc2Parser.bitAndExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBitAndExpr([NotNull] NCalc2Parser.BitAndExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="NCalc2Parser.bitAndExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBitAndExpr([NotNull] NCalc2Parser.BitAndExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="NCalc2Parser.relExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelExpr([NotNull] NCalc2Parser.RelExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="NCalc2Parser.relExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelExpr([NotNull] NCalc2Parser.RelExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="NCalc2Parser.value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValue([NotNull] NCalc2Parser.ValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="NCalc2Parser.value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValue([NotNull] NCalc2Parser.ValueContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="NCalc2Parser.ncalc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNcalc([NotNull] NCalc2Parser.NcalcContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="NCalc2Parser.ncalc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNcalc([NotNull] NCalc2Parser.NcalcContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="NCalc2Parser.andExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAndExpr([NotNull] NCalc2Parser.AndExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="NCalc2Parser.andExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAndExpr([NotNull] NCalc2Parser.AndExprContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace NCalc2.Grammar
