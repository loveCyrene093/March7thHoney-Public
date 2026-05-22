using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TextJoinQueryCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TextJoinQueryCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhUZXh0Sm9pblF1ZXJ5Q3NSZXEucHJvdG8iLwoSVGV4dEpvaW5RdWVyeUNz" + "UmVxEhkKEXRleHRfam9pbl9pZF9saXN0GA0gAygNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TextJoinQueryCsReq), TextJoinQueryCsReq.Parser, new string[1] { "TextJoinIdList" }, null, null, null, null)
		}));
	}
}
