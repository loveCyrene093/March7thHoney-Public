using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DeleteFriendScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DeleteFriendScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdEZWxldGVGcmllbmRTY1JzcC5wcm90byIxChFEZWxldGVGcmllbmRTY1Jz" + "cBILCgN1aWQYAiABKA0SDwoHcmV0Y29kZRgPIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DeleteFriendScRsp), DeleteFriendScRsp.Parser, new string[2] { "Uid", "Retcode" }, null, null, null, null)
		}));
	}
}
