using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelChangeLineupCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelChangeLineupCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJDaGltZXJhRHVlbENoYW5nZUxpbmV1cENzUmVxLnByb3RvIl0KHENoaW1l" + "cmFEdWVsQ2hhbmdlTGluZXVwQ3NSZXESEwoLR0FHSkFFT09ERUgYAiABKA0S" + "EwoLTUVLTElLTEdBRkkYBiADKA0SEwoLTExETktNTElNTFAYDiABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelChangeLineupCsReq), ChimeraDuelChangeLineupCsReq.Parser, new string[3] { "GAGJAEOODEH", "MEKLIKLGAFI", "LLDNKMLIMLP" }, null, null, null, null)
		}));
	}
}
