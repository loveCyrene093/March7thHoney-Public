using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AddBlacklistCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AddBlacklistCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdBZGRCbGFja2xpc3RDc1JlcS5wcm90byIgChFBZGRCbGFja2xpc3RDc1Jl" + "cRILCgN1aWQYAyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AddBlacklistCsReq), AddBlacklistCsReq.Parser, new string[1] { "Uid" }, null, null, null, null)
		}));
	}
}
