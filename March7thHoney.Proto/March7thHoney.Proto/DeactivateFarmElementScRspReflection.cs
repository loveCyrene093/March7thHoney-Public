using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DeactivateFarmElementScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DeactivateFarmElementScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBEZWFjdGl2YXRlRmFybUVsZW1lbnRTY1JzcC5wcm90byJAChpEZWFjdGl2" + "YXRlRmFybUVsZW1lbnRTY1JzcBIPCgdyZXRjb2RlGAMgASgNEhEKCWVudGl0" + "eV9pZBgIIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DeactivateFarmElementScRsp), DeactivateFarmElementScRsp.Parser, new string[2] { "Retcode", "EntityId" }, null, null, null, null)
		}));
	}
}
