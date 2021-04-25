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
	var installDir = Environment.GetEnvironmentVariable("SolastaInstallDir");

	var assembly = Assembly.LoadFile(Path.Combine(installDir, @"Solasta_Data\Managed\Assembly-CSharp.dll"));

	var types = GetDerivedTypes(assembly, typeof(BaseDefinition));

	types.Select(t => new { Type = t.type.Name, Base = t.baseType.Name }).Dump();

	foreach (var t in types.OrderBy(t => t.type.Name))
	{
		CreateExtensions(t.type, true);
	}
}

IEnumerable<(Type type, Type baseType)> GetDerivedTypes(Assembly assembly, Type baseType)
{
	var types = assembly.GetTypes()
		.Where(t => t.BaseType?.Name == baseType.Name)
		.Select(t => (type: t, baseType))
		.OrderBy(t => t.type.Name)
		.ToList();

	return types.Concat(types.SelectMany(t => GetDerivedTypes(assembly, t.type)));
}

IEnumerable<Type> GetTypesEndingIn(Assembly assembly, string suffix)
{
	return assembly.GetTypes()
		.Where(t => t.BaseType?.Name?.EndsWith(suffix, StringComparison.OrdinalIgnoreCase) ?? false)
		.OrderBy(t => t.Name)
		.ToList();
}

void CreateExtensions(Type t, bool createFiles = false)
{
	var sf = SyntaxFactory.CompilationUnit()
		.AddUsings(
			GetUsingSyntax("SolastaModApi.Infrastructure"),
			GetUsingSyntax("AK.Wwise"),
			GetUsingSyntax("UnityEngine"),
			GetUsingSyntax("UnityEngine.AddressableAssets"),
			GetUsingSyntax("System"),
			GetUsingSyntax("System.Text"),
			GetUsingSyntax("TA.AI"),
			GetUsingSyntax("TA"),
			GetUsingSyntax("System.Collections.Generic"),
			GetUsingSyntax("UnityEngine.Rendering.PostProcessing"),
			GetUsingSyntax("static ActionDefinitions"),
			GetUsingSyntax("static TA.AI.DecisionPackageDefinition"),
			GetUsingSyntax("static TA.AI.DecisionDefinition"),
			GetUsingSyntax("static RuleDefinitions"),
			GetUsingSyntax("static BanterDefinitions"),
			GetUsingSyntax("static Gui"),
			GetUsingSyntax("static BestiaryDefinitions"),
			GetUsingSyntax("static CursorDefinitions"),
			GetUsingSyntax("static AnimationDefinitions"),
			GetUsingSyntax("static CharacterClassDefinition"),
			GetUsingSyntax("static CampaignDefinition"),
			GetUsingSyntax("static GameCampaignDefinitions"),
			GetUsingSyntax("static TooltipDefinitions"),
			GetUsingSyntax("static BaseBlueprint"),
			GetUsingSyntax("static MorphotypeElementDefinition")
			);

	var cd = ClassDeclaration($"{t.Name}Extensions")
		.AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword));

	var privateFields = t
		.GetFields(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.NonPublic)
		.Select(f => new { f.Name, FieldInfo = f, f.FieldType, Type = SimplifyType(f.FieldType) });

	var writeablePublicProperties = t
		.GetProperties(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public)
		.Where(pg => pg.CanWrite)
		.Select(pg => new { pg.Name, pg.PropertyType, Type = SimplifyType(pg.PropertyType) });

	var readablePublicProperties = t
		.GetProperties(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public)
		.Where(pg => pg.CanRead)
		.Select(pg => new { pg.Name, Type = SimplifyType(pg.PropertyType) });

	var readablePublicPropertiesByName = readablePublicProperties
		.Select(pp => pp.Name)
		.ToHashSet(StringComparer.OrdinalIgnoreCase);

	var readablePublicPropertiesByType = readablePublicProperties
		.Select(pp => pp.Type)
		.ToHashSet(StringComparer.OrdinalIgnoreCase);

	var writeablePublicPropertiesByName = writeablePublicProperties
		.Select(pp => pp.Name)
		.ToHashSet(StringComparer.OrdinalIgnoreCase);

	var writeablePublicPropertiesByType = writeablePublicProperties
		.Select(pp => pp.Type)
		.ToHashSet(StringComparer.OrdinalIgnoreCase);

	var privateFieldsThatNeedReader = privateFields
		.Where(f => !f.FieldType.IsGenericType)
		.Where(f => !readablePublicPropertiesByName.Contains(f.Name))
		.Where(f => !readablePublicPropertiesByType.Contains(f.Type));

	var privateFieldsThatNeedWriter = privateFields
		//.Where(f => !f.FieldType.IsGenericType)
		.Where(f => !writeablePublicPropertiesByName.Contains(f.Name))
		.Where(f => !writeablePublicPropertiesByType.Contains(f.Type));

	var methods = privateFieldsThatNeedWriter
		.OrderBy(ftnw => ftnw.Name)
		.Select(f =>
			MethodDeclaration(ParseTypeName("void"), $"Set{GetPropertyNameForField(f.FieldInfo)}")
		   .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword))
		   .AddParameterListParameters(
		   		GetThisParameterFromType(t), GetParameterFromField(f.FieldInfo))
		   .WithBody(Block(ParseStatement($"definition.SetField(\"{f.Name}\", value);")))
		);

	if (methods.Any())
	{
		cd = cd.AddMembers(methods.ToArray());

		// namespace
		var ns = SyntaxFactory
			.NamespaceDeclaration(ParseName("SolastaModApi.BuilderHelpers.DefinitionExtensions"))
			.AddMembers(cd);

		var path = $@"C:\Users\passp\Source\Repos\SolastaModApi\SolastaModApi\DefinitionExtensions\{t.Name}Extension.cs";

		var code = sf.AddMembers(ns)
			.NormalizeWhitespace()
			.ToFullString();

		code.Dump();

		if (createFiles)
		{
			File.WriteAllText(path, code);
		}
	}

	UsingDirectiveSyntax GetUsingSyntax(string name) { return UsingDirective(ParseName(name)); }

	string GetPropertyNameForField(FieldInfo f)
	{
		var type = SimplifyType(f.FieldType);
		if (readablePublicPropertiesByName.Contains(type))
		{
			return Capitalize(type);
		}
		return Capitalize(f.Name);
	}

	string Capitalize(string name)
	{
		if (name.Length <= 1) return name;

		var sb = new StringBuilder(name);
		sb[0] = char.ToUpperInvariant(sb[0]);
		return sb.ToString();
	}

	string SimplifyType(Type t)
	{
		if (t.IsGenericType)
		{
			var name = t.Name.Replace("`1", "").Replace("`2", "");
			return $"{name}<{string.Join(",", t.GenericTypeArguments.Select(ft1 => SimplifyName(ft1)))}>";
		}

		return SimplifyName(t);
	}

	string SimplifyName(Type t)
	{
		if (t.FullName.Contains("+"))
		{
			return t.FullName.Replace("+", ".");
		}

		return t.Name;
	}

	ParameterSyntax GetThisParameterFromType(Type t)
	{
		return Parameter(Identifier("definition")).WithType(ParseTypeName(t.Name)).AddModifiers(Token(SyntaxKind.ThisKeyword));
	}

	ParameterSyntax GetParameterFromField(FieldInfo f)
	{
		return Parameter(Identifier("value")).WithType(ParseTypeName(SimplifyType(f.FieldType)));
	}
}