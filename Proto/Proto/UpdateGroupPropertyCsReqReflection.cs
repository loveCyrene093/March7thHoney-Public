using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateGroupPropertyCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateGroupPropertyCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch5VcGRhdGVHcm91cFByb3BlcnR5Q3NSZXEucHJvdG8ikwEKGFVwZGF0ZUdy";
		buffer[1] = "b3VwUHJvcGVydHlDc1JlcRIUCgxkaW1lbnNpb25faWQYBCABKA0SEwoLQU9C";
		buffer[2] = "QUJPR0hGS0oYBSABKAUSEAoIZ3JvdXBfaWQYBiABKA0SEwoLRUxOQ0pGRkpG";
		buffer[3] = "SUgYByABKAkSEwoLaW50ZXJhY3RfaWQYDCABKAQSEAoIZmxvb3JfaWQYDyAB";
		buffer[4] = "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateGroupPropertyCsReq), UpdateGroupPropertyCsReq.Parser, new string[6] { "DimensionId", "AOBABOGHFKJ", "GroupId", "ELNCJFFJFIH", "InteractId", "FloorId" }, null, null, null, null)
		}));
	}
}
