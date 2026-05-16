using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncTaskCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncTaskCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNTeW5jVGFza0NzUmVxLnByb3RvIhwKDVN5bmNUYXNrQ3NSZXESCwoDa2V5" + "GAIgASgJQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncTaskCsReq), SyncTaskCsReq.Parser, new string[1] { "Key" }, null, null, null, null)
		}));
	}
}
