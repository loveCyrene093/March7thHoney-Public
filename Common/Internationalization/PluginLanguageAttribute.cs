using System;
using March7thHoney.Enums.Language;

namespace March7thHoney.Internationalization;

[AttributeUsage(AttributeTargets.Class)]
public class PluginLanguageAttribute(ProgramLanguageTypeEnum languageType) : Attribute
{
	public ProgramLanguageTypeEnum LanguageType { get; } = languageType;
}
