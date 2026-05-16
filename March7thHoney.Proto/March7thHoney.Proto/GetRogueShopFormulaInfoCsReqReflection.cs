using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueShopFormulaInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueShopFormulaInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJHZXRSb2d1ZVNob3BGb3JtdWxhSW5mb0NzUmVxLnByb3RvIlYKHEdldFJv" + "Z3VlU2hvcEZvcm11bGFJbmZvQ3NSZXESEwoLTk9LTk5NUE1HR04YBiABKAgS" + "IQoZaW50ZXJhY3RlZF9wcm9wX2VudGl0eV9pZBgNIAEoDUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueShopFormulaInfoCsReq), GetRogueShopFormulaInfoCsReq.Parser, new string[2] { "NOKNNMPMGGN", "InteractedPropEntityId" }, null, null, null, null)
		}));
	}
}
