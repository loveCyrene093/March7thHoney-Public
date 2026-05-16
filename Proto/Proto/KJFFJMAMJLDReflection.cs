using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KJFFJMAMJLDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KJFFJMAMJLDReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFLSkZGSk1BTUpMRC5wcm90byKrAQoLS0pGRkpNQU1KTEQSDwoHcm9sZV9p";
		buffer[1] = "ZBgBIAEoDRIOCgZkYW1hZ2UYAiABKAESEwoLQk9JRUdQQVBIT1AYBSABKAES";
		buffer[2] = "MgoLQUZOQU9JRkNLRk4YBiADKAsyHS5LSkZGSk1BTUpMRC5BRk5BT0lGQ0tG";
		buffer[3] = "TkVudHJ5GjIKEEFGTkFPSUZDS0ZORW50cnkSCwoDa2V5GAEgASgNEg0KBXZh";
		buffer[4] = "bHVlGAIgASgBOgI4AUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KJFFJMAMJLD), KJFFJMAMJLD.Parser, new string[4] { "RoleId", "Damage", "BOIEGPAPHOP", "AFNAOIFCKFN" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
