using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingSelectPolicyCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingSelectPolicyCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9DaGVuTGluZ1NlbGVjdFBvbGljeUNzUmVxLnByb3RvIjAKGUNoZW5MaW5n" + "U2VsZWN0UG9saWN5Q3NSZXESEwoLREdJSU9HSEhBQUYYByABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingSelectPolicyCsReq), ChenLingSelectPolicyCsReq.Parser, new string[1] { "DGIIOGHHAAF" }, null, null, null, null)
		}));
	}
}
