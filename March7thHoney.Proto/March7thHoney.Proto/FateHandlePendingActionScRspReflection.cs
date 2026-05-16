using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateHandlePendingActionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateHandlePendingActionScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJGYXRlSGFuZGxlUGVuZGluZ0FjdGlvblNjUnNwLnByb3RvIkcKHEZhdGVI" + "YW5kbGVQZW5kaW5nQWN0aW9uU2NSc3ASFgoOcXVldWVfcG9zaXRpb24YDSAB" + "KA0SDwoHcmV0Y29kZRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateHandlePendingActionScRsp), FateHandlePendingActionScRsp.Parser, new string[2] { "QueuePosition", "Retcode" }, null, null, null, null)
		}));
	}
}
