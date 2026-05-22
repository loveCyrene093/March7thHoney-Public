using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IdleLiveDoGachaCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IdleLiveDoGachaCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpJZGxlTGl2ZURvR2FjaGFDc1JlcS5wcm90byIrChRJZGxlTGl2ZURvR2Fj" + "aGFDc1JlcRITCgtnYWNoYV9jb3VudBgLIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IdleLiveDoGachaCsReq), IdleLiveDoGachaCsReq.Parser, new string[1] { "GachaCount" }, null, null, null, null)
		}));
	}
}
