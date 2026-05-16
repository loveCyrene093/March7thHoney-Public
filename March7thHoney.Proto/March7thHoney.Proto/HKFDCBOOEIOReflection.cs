using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HKFDCBOOEIOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HKFDCBOOEIOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIS0ZEQ0JPT0VJTy5wcm90bxoXTG9iYnlJbnRlcmFjdFR5cGUucHJvdG8i" + "SwoLSEtGRENCT09FSU8SEwoLdGVsZXBvcnRfaWQYAiABKA0SJwoLSEdJQUdK" + "TUhET0IYAyABKA4yEi5Mb2JieUludGVyYWN0VHlwZUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { LobbyInteractTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HKFDCBOOEIO), HKFDCBOOEIO.Parser, new string[2] { "TeleportId", "HGIAGJMHDOB" }, null, null, null, null)
		}));
	}
}
