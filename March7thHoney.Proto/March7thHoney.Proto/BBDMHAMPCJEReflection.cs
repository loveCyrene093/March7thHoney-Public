using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BBDMHAMPCJEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BBDMHAMPCJEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQkRNSEFNUENKRS5wcm90bxoOSXRlbUxpc3QucHJvdG8iYwoLQkJETUhB" + "TVBDSkUSGQoGcmV3YXJkGAcgASgLMgkuSXRlbUxpc3QSEwoLRUhMSUZIUElM" + "UEcYCSABKA0SEwoLTkZPRElCSUlHTU8YDSABKAgSDwoHcmV0Y29kZRgOIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BBDMHAMPCJE), BBDMHAMPCJE.Parser, new string[4] { "Reward", "EHLIFHPILPG", "NFODIBIIGMO", "Retcode" }, null, null, null, null)
		}));
	}
}
