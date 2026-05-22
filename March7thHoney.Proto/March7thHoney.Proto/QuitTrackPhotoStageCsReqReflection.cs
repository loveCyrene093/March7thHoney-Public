using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class QuitTrackPhotoStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static QuitTrackPhotoStageCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5RdWl0VHJhY2tQaG90b1N0YWdlQ3NSZXEucHJvdG8iLAoYUXVpdFRyYWNr" + "UGhvdG9TdGFnZUNzUmVxEhAKCHN0YWdlX2lkGAcgASgNQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(QuitTrackPhotoStageCsReq), QuitTrackPhotoStageCsReq.Parser, new string[1] { "StageId" }, null, null, null, null)
		}));
	}
}
