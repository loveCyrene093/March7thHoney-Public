using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RemoveStuffFromAreaScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RemoveStuffFromAreaScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZW1vdmVTdHVmZkZyb21BcmVhU2NSc3AucHJvdG8iQAoYUmVtb3ZlU3R1" + "ZmZGcm9tQXJlYVNjUnNwEhMKC0dLRkVHSUJHRUdJGAYgASgNEg8KB3JldGNv" + "ZGUYDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RemoveStuffFromAreaScRsp), RemoveStuffFromAreaScRsp.Parser, new string[2] { "GKFEGIBGEGI", "Retcode" }, null, null, null, null)
		}));
	}
}
