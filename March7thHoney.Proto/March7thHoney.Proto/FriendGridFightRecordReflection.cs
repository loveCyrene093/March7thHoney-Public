using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FriendGridFightRecordReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FriendGridFightRecordReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtGcmllbmRHcmlkRmlnaHRSZWNvcmQucHJvdG8iLAoVRnJpZW5kR3JpZEZp" + "Z2h0UmVjb3JkEhMKC2RpdmlzaW9uX2lkGAggASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FriendGridFightRecord), FriendGridFightRecord.Parser, new string[1] { "DivisionId" }, null, null, null, null)
		}));
	}
}
