using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeadFrameInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeadFrameInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNIZWFkRnJhbWVJbmZvLnByb3RvIksKDUhlYWRGcmFtZUluZm8SGgoSaGVh" + "ZF9mcmFtZV9pdGVtX2lkGAkgASgNEh4KFmhlYWRfZnJhbWVfZXhwaXJlX3Rp" + "bWUYDCABKANCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeadFrameInfo), HeadFrameInfo.Parser, new string[2] { "HeadFrameItemId", "HeadFrameExpireTime" }, null, null, null, null)
		}));
	}
}
