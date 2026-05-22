using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetChessRogueStoryInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetChessRogueStoryInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHZXRDaGVzc1JvZ3VlU3RvcnlJbmZvQ3NSZXEucHJvdG8iHQobR2V0Q2hl" + "c3NSb2d1ZVN0b3J5SW5mb0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetChessRogueStoryInfoCsReq), GetChessRogueStoryInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
