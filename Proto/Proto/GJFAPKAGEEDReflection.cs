using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GJFAPKAGEEDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GJFAPKAGEEDReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFHSkZBUEtBR0VFRC5wcm90bxoRTU1ETkNNTU9LUE8ucHJvdG8iwgEKC0dK";
		buffer[1] = "RkFQS0FHRUVEEjIKC0hCTkhDRU9LSUJKGAMgAygLMh0uR0pGQVBLQUdFRUQu";
		buffer[2] = "SEJOSENFT0tJQkpFbnRyeRIhCgtNS0hESU5ER0hNRBgGIAEoDjIMLk1NRE5D";
		buffer[3] = "TU1PS1BPEhMKC1BORkJISEJMQUZIGAsgASgNEhMKC0JBTU5NRU5HS0ZHGA0g";
		buffer[4] = "ASgNGjIKEEhCTkhDRU9LSUJKRW50cnkSCwoDa2V5GAEgASgJEg0KBXZhbHVl";
		buffer[5] = "GAIgASgBOgI4AUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MMDNCMMOKPOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GJFAPKAGEED), GJFAPKAGEED.Parser, new string[4] { "HBNHCEOKIBJ", "MKHDINDGHMD", "PNFBHHBLAFH", "BAMNMENGKFG" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
