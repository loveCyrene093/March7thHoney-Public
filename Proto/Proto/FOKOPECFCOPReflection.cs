using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FOKOPECFCOPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FOKOPECFCOPReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFGT0tPUEVDRkNPUC5wcm90bxoRQUVJTUlOQ09GSEYucHJvdG8ijwEKC0ZP";
		buffer[1] = "S09QRUNGQ09QEg0KBWxldmVsGAIgASgNEiEKC0JPREFQT0xGQURGGAUgAygL";
		buffer[2] = "MgwuQUVJTUlOQ09GSEYSEwoLRU5OR05BTUVCSkMYBiABKA0SEwoLS0RGTUlG";
		buffer[3] = "S0FMS0gYByABKA0SDwoHYXJlYV9pZBgLIAEoDRITCgtHUE9OSEpISE1CQhgN";
		buffer[4] = "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { AEIMINCOFHFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FOKOPECFCOP), FOKOPECFCOP.Parser, new string[6] { "Level", "BODAPOLFADF", "ENNGNAMEBJC", "KDFMIFKALKH", "AreaId", "GPONHJHHMBB" }, null, null, null, null)
		}));
	}
}
