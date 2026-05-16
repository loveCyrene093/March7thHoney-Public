using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MakeDrinkCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MakeDrinkCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRNYWtlRHJpbmtDc1JlcS5wcm90bxoRQ0lHS0JESUdHT0kucHJvdG8iSAoO" + "TWFrZURyaW5rQ3NSZXESEwoLTUdHRVBBTkpQTFAYAiABKA0SIQoLSUhETUxI" + "RkFFS0gYCCABKAsyDC5DSUdLQkRJR0dPSUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[1] { CIGKBDIGGOIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MakeDrinkCsReq), MakeDrinkCsReq.Parser, new string[2] { "MGGEPANJPLP", "IHDMLHFAEKH" }, null, null, null, null)
		}));
	}
}
