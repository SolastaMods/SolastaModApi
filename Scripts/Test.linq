<Query Kind="Program">
  <Reference>D:\Program Files (x86)\SteamLibrary\steamapps\common\Slasta_COTM\Solasta_Data\Managed\Assembly-CSharp.dll</Reference>
  <NuGetReference>Microsoft.CodeAnalysis.CSharp</NuGetReference>
  <Namespace>Microsoft.CodeAnalysis</Namespace>
  <Namespace>Microsoft.CodeAnalysis.CSharp</Namespace>
  <Namespace>Microsoft.CodeAnalysis.CSharp.Syntax</Namespace>
  <Namespace>System.Globalization</Namespace>
</Query>

using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

void Main()
{
	var cd = ClassDeclaration($"TestExtensions")
		.AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword));

	var method =
		MethodDeclaration(ParseTypeName($"T"), $"SetTest")
		   .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword))
		   .AddTypeParameterListParameters(TypeParameter(Identifier("T")))
		   .AddParameterListParameters(
			   Parameter(Identifier("definition")).WithType(ParseTypeName("T")).AddModifiers(Token(SyntaxKind.ThisKeyword)),
				Parameter(Identifier("value")).WithType(ParseTypeName("int"))
			)
			.AddConstraintClauses(TypeParameterConstraintClause("T").WithConstraints(GetSL()))
			.WithBody(Block(ParseStatement($"definition.SetField(\"test\", value);"), ParseStatement("return definition;")));

	cd = cd.AddMembers(method);

	// namespace
	var ns = SyntaxFactory
		.NamespaceDeclaration(ParseName("MyNS"))
		.AddMembers(cd);

	var cu = SyntaxFactory.CompilationUnit();

	var code = cu.AddMembers(ns)
		.NormalizeWhitespace()
		.ToFullString();

	// hack because I can't make .WithConstraints work
	//		code = code.Replace("where T :", $"where T : {t.Name}");

	code.Dump();
}

SeparatedSyntaxList<TypeParameterConstraintSyntax> GetSL()
{
	var list = SeparatedList<TypeParameterConstraintSyntax>();
	list.Add(TypeConstraint(ParseTypeName($"Test")));
	return list;
}

