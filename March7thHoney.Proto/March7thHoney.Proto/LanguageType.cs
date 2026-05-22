using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum LanguageType
{
	[OriginalName("LANGUAGE_NONE")]
	LanguageNone,
	[OriginalName("LANGUAGE_SC")]
	LanguageSc,
	[OriginalName("LANGUAGE_TC")]
	LanguageTc,
	[OriginalName("LANGUAGE_EN")]
	LanguageEn,
	[OriginalName("LANGUAGE_KR")]
	LanguageKr,
	[OriginalName("LANGUAGE_JP")]
	LanguageJp,
	[OriginalName("LANGUAGE_FR")]
	LanguageFr,
	[OriginalName("LANGUAGE_DE")]
	LanguageDe,
	[OriginalName("LANGUAGE_ES")]
	LanguageEs,
	[OriginalName("LANGUAGE_PT")]
	LanguagePt,
	[OriginalName("LANGUAGE_RU")]
	LanguageRu,
	[OriginalName("LANGUAGE_TH")]
	LanguageTh,
	[OriginalName("LANGUAGE_VI")]
	LanguageVi,
	[OriginalName("LANGUAGE_ID")]
	LanguageId
}
