using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueCommonDialogueDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueCommonDialogueDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVHZXRSb2d1ZUNvbW1vbkRpYWxvZ3VlRGF0YVNjUnNwLnByb3RvGhFKSUJN" + "SkNCTkRLSy5wcm90byJVCh9HZXRSb2d1ZUNvbW1vbkRpYWxvZ3VlRGF0YVNj" + "UnNwEiEKC0pPS0FFRU1KTE1LGAQgAygLMgwuSklCTUpDQk5ES0sSDwoHcmV0" + "Y29kZRgGIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { JIBMJCBNDKKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueCommonDialogueDataScRsp), GetRogueCommonDialogueDataScRsp.Parser, new string[2] { "JOKAEEMJLMK", "Retcode" }, null, null, null, null)
		}));
	}
}
