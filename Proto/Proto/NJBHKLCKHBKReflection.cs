using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NJBHKLCKHBKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NJBHKLCKHBKReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFOSkJIS0xDS0hCSy5wcm90bxoRSElCQkJKQkVOSEMucHJvdG8aDFZlY3Rv";
		buffer[1] = "ci5wcm90byKSAQoLTkpCSEtMQ0tIQksSCgoCaWQYASABKA0SEwoLUElKTUtI";
		buffer[2] = "TURIQUUYBSABKAgSEwoLQklBR0lGSUtETkEYCSABKA0SHAoLQkxMTERDTU9B";
		buffer[3] = "QUkYCiADKAsyBy5WZWN0b3ISDAoEdXVpZBgNIAEoCRIhCgtDUEVNTElBR0JL";
		buffer[4] = "QhgOIAEoCzIMLkhJQkJCSkJFTkhDQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[5] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			HIBBBJBENHCReflection.Descriptor,
			VectorReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NJBHKLCKHBK), NJBHKLCKHBK.Parser, new string[6] { "Id", "PIJMKHMDHAE", "BIAGIFIKDNA", "BLLLDCMOAAI", "Uuid", "CPEMLIAGBKB" }, null, null, null, null)
		}));
	}
}
