using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SummonPetScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SummonPetScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRTdW1tb25QZXRTY1JzcC5wcm90byJMCg5TdW1tb25QZXRTY1JzcBIVCg1z" + "ZWxlY3RfcGV0X2lkGA0gASgNEg8KB3JldGNvZGUYDiABKA0SEgoKY3VyX3Bl" + "dF9pZBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SummonPetScRsp), SummonPetScRsp.Parser, new string[3] { "SelectPetId", "Retcode", "CurPetId" }, null, null, null, null)
		}));
	}
}
