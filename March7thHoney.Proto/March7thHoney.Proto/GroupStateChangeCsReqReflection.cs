using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GroupStateChangeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GroupStateChangeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHcm91cFN0YXRlQ2hhbmdlQ3NSZXEucHJvdG8aFEdyb3VwU3RhdGVJbmZv" + "LnByb3RvIlcKFUdyb3VwU3RhdGVDaGFuZ2VDc1JlcRITCgtpbnRlcmFjdF9p" + "ZBgBIAEoBBIpChBncm91cF9zdGF0ZV9pbmZvGAsgASgLMg8uR3JvdXBTdGF0" + "ZUluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { GroupStateInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GroupStateChangeCsReq), GroupStateChangeCsReq.Parser, new string[2] { "InteractId", "GroupStateInfo" }, null, null, null, null)
		}));
	}
}
