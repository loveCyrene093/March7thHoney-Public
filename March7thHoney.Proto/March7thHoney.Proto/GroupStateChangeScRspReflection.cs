using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GroupStateChangeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GroupStateChangeScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHcm91cFN0YXRlQ2hhbmdlU2NSc3AucHJvdG8aFEdyb3VwU3RhdGVJbmZv" + "LnByb3RvIlMKFUdyb3VwU3RhdGVDaGFuZ2VTY1JzcBIpChBncm91cF9zdGF0" + "ZV9pbmZvGAwgASgLMg8uR3JvdXBTdGF0ZUluZm8SDwoHcmV0Y29kZRgNIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GroupStateInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GroupStateChangeScRsp), GroupStateChangeScRsp.Parser, new string[2] { "GroupStateInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
