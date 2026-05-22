using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainCakeCatchDiyLikeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainCakeCatchDiyLikeScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBUcmFpbkNha2VDYXRjaERpeUxpa2VTY1JzcC5wcm90byJCChpUcmFpbkNh" + "a2VDYXRjaERpeUxpa2VTY1JzcBIPCgdyZXRjb2RlGAYgASgNEhMKC0pOTktK" + "QUVNT0JOGA0gAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainCakeCatchDiyLikeScRsp), TrainCakeCatchDiyLikeScRsp.Parser, new string[2] { "Retcode", "JNNKJAEMOBN" }, null, null, null, null)
		}));
	}
}
