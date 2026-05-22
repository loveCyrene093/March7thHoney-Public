using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DeleteBlacklistCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DeleteBlacklistCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpEZWxldGVCbGFja2xpc3RDc1JlcS5wcm90byIjChREZWxldGVCbGFja2xp" + "c3RDc1JlcRILCgN1aWQYCSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DeleteBlacklistCsReq), DeleteBlacklistCsReq.Parser, new string[1] { "Uid" }, null, null, null, null)
		}));
	}
}
