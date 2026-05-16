using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyGiveUpCurContentScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyGiveUpCurContentScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNNb25vcG9seUdpdmVVcEN1ckNvbnRlbnRTY1JzcC5wcm90byJECh1Nb25v" + "cG9seUdpdmVVcEN1ckNvbnRlbnRTY1JzcBISCgpjb250ZW50X2lkGAUgASgN" + "Eg8KB3JldGNvZGUYDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGiveUpCurContentScRsp), MonopolyGiveUpCurContentScRsp.Parser, new string[2] { "ContentId", "Retcode" }, null, null, null, null)
		}));
	}
}
