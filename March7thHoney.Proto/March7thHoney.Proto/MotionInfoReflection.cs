using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MotionInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MotionInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChBNb3Rpb25JbmZvLnByb3RvGgxWZWN0b3IucHJvdG8iOAoKTW90aW9uSW5m" + "bxIUCgNwb3MYByABKAsyBy5WZWN0b3ISFAoDcm90GAggASgLMgcuVmVjdG9y" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { VectorReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MotionInfo), MotionInfo.Parser, new string[2] { "Pos", "Rot" }, null, null, null, null)
		}));
	}
}
