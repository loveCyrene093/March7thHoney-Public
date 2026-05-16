using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncClientResVersionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncClientResVersionCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9TeW5jQ2xpZW50UmVzVmVyc2lvbkNzUmVxLnByb3RvIjcKGVN5bmNDbGll" + "bnRSZXNWZXJzaW9uQ3NSZXESGgoSY2xpZW50X3Jlc192ZXJzaW9uGAggASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncClientResVersionCsReq), SyncClientResVersionCsReq.Parser, new string[1] { "ClientResVersion" }, null, null, null, null)
		}));
	}
}
