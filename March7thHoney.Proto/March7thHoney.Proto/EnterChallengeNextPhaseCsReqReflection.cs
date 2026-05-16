using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterChallengeNextPhaseCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterChallengeNextPhaseCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJFbnRlckNoYWxsZW5nZU5leHRQaGFzZUNzUmVxLnByb3RvIh4KHEVudGVy" + "Q2hhbGxlbmdlTmV4dFBoYXNlQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterChallengeNextPhaseCsReq), EnterChallengeNextPhaseCsReq.Parser, null, null, null, null, null)
		}));
	}
}
