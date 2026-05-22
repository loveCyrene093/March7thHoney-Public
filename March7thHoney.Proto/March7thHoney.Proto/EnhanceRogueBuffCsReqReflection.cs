using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnhanceRogueBuffCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnhanceRogueBuffCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtFbmhhbmNlUm9ndWVCdWZmQ3NSZXEucHJvdG8iLQoVRW5oYW5jZVJvZ3Vl" + "QnVmZkNzUmVxEhQKDG1hemVfYnVmZl9pZBgBIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnhanceRogueBuffCsReq), EnhanceRogueBuffCsReq.Parser, new string[1] { "MazeBuffId" }, null, null, null, null)
		}));
	}
}
