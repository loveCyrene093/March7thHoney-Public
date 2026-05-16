using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChestInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChestInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg9DaGVzdEluZm8ucHJvdG8aD0NoZXN0VHlwZS5wcm90byJSCglDaGVzdElu" + "Zm8SEQoJZXhpc3RfbnVtGAQgASgNEhIKCm9wZW5lZF9udW0YBSABKA0SHgoK" + "Y2hlc3RfdHlwZRgHIAEoDjIKLkNoZXN0VHlwZUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ChestTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChestInfo), ChestInfo.Parser, new string[3] { "ExistNum", "OpenedNum", "ChestType" }, null, null, null, null)
		}));
	}
}
