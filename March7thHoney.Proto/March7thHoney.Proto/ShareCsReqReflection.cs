using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ShareCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ShareCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChBTaGFyZUNzUmVxLnByb3RvIiEKClNoYXJlQ3NSZXESEwoLS0xMUE9BS0RE" + "SFAYAiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ShareCsReq), ShareCsReq.Parser, new string[1] { "KLLPOAKDDHP" }, null, null, null, null)
		}));
	}
}
