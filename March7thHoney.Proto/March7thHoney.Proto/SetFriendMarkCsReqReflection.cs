using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetFriendMarkCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetFriendMarkCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTZXRGcmllbmRNYXJrQ3NSZXEucHJvdG8iRgoSU2V0RnJpZW5kTWFya0Nz" + "UmVxEg4KBnJlYXNvbhgDIAEoDRITCgtLQk5LTkFIR1BIRxgHIAEoCBILCgN1" + "aWQYCCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetFriendMarkCsReq), SetFriendMarkCsReq.Parser, new string[3] { "Reason", "KBNKNAHGPHG", "Uid" }, null, null, null, null)
		}));
	}
}
