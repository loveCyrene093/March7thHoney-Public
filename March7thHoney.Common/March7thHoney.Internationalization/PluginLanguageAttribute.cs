using System;
using March7thHoney.Enums.Language;

namespace March7thHoney.Internationalization;

[AttributeUsage(AttributeTargets.Class)]
public class PluginLanguageAttribute : Attribute
{
	public ProgramLanguageTypeEnum LanguageType { get; }

	public PluginLanguageAttribute(ProgramLanguageTypeEnum languageType)
	{
		LanguageType = languageType;
		base._002Ector();
	}
}
