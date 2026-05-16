using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetTutorialGuideScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetTutorialGuideScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRUdXRvcmlhbEd1aWRlU2NSc3AucHJvdG8aE1R1dG9yaWFsR3VpZGUu" + "cHJvdG8iVQoVR2V0VHV0b3JpYWxHdWlkZVNjUnNwEg8KB3JldGNvZGUYAiAB" + "KA0SKwoTdHV0b3JpYWxfZ3VpZGVfbGlzdBgKIAMoCzIOLlR1dG9yaWFsR3Vp" + "ZGVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { TutorialGuideReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetTutorialGuideScRsp), GetTutorialGuideScRsp.Parser, new string[2] { "Retcode", "TutorialGuideList" }, null, null, null, null)
		}));
	}
}
