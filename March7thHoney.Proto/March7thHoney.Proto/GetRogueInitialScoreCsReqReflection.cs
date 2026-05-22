using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueInitialScoreCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueInitialScoreCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HZXRSb2d1ZUluaXRpYWxTY29yZUNzUmVxLnByb3RvIhsKGUdldFJvZ3Vl" + "SW5pdGlhbFNjb3JlQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueInitialScoreCsReq), GetRogueInitialScoreCsReq.Parser, null, null, null, null, null)
		}));
	}
}
