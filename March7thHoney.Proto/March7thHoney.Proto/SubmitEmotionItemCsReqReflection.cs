using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SubmitEmotionItemCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SubmitEmotionItemCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxTdWJtaXRFbW90aW9uSXRlbUNzUmVxLnByb3RvGg5JdGVtTGlzdC5wcm90" + "byJeChZTdWJtaXRFbW90aW9uSXRlbUNzUmVxEhMKC0FJTE9NQklNSUNCGAwg" + "ASgNEhwKCWl0ZW1fbGlzdBgOIAEoCzIJLkl0ZW1MaXN0EhEKCXNjcmlwdF9p" + "ZBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SubmitEmotionItemCsReq), SubmitEmotionItemCsReq.Parser, new string[3] { "AILOMBIMICB", "ItemList", "ScriptId" }, null, null, null, null)
		}));
	}
}
