using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightEliteBranchActionInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightEliteBranchActionInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRHcmlkRmlnaHRFbGl0ZUJyYW5jaEFjdGlvbkluZm8ucHJvdG8iSgoeR3Jp" + "ZEZpZ2h0RWxpdGVCcmFuY2hBY3Rpb25JbmZvEhMKC0VPT1BPRkNDSEFBGAkg" + "ASgNEhMKC0ZDSFBKS0FJQkhCGAogASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightEliteBranchActionInfo), GridFightEliteBranchActionInfo.Parser, new string[2] { "EOOPOFCCHAA", "FCHPJKAIBHB" }, null, null, null, null)
		}));
	}
}
