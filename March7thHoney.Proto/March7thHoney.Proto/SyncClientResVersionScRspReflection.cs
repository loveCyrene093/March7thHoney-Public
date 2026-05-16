using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncClientResVersionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncClientResVersionScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9TeW5jQ2xpZW50UmVzVmVyc2lvblNjUnNwLnByb3RvIkgKGVN5bmNDbGll" + "bnRSZXNWZXJzaW9uU2NSc3ASGgoSY2xpZW50X3Jlc192ZXJzaW9uGAMgASgN" + "Eg8KB3JldGNvZGUYByABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncClientResVersionScRsp), SyncClientResVersionScRsp.Parser, new string[2] { "ClientResVersion", "Retcode" }, null, null, null, null)
		}));
	}
}
