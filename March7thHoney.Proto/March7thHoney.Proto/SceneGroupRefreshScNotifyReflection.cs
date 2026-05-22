using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneGroupRefreshScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneGroupRefreshScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch9TY2VuZUdyb3VwUmVmcmVzaFNjTm90aWZ5LnByb3RvGhZHcm91cFJlZnJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "c2hJbmZvLnByb3RvInIKGVNjZW5lR3JvdXBSZWZyZXNoU2NOb3RpZnkSLQoS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Z3JvdXBfcmVmcmVzaF9saXN0GAIgAygLMhEuR3JvdXBSZWZyZXNoSW5mbxIU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "CgxkaW1lbnNpb25faWQYBCABKA0SEAoIZmxvb3JfaWQYCyABKA1CFqoCE01h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { GroupRefreshInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneGroupRefreshScNotify), SceneGroupRefreshScNotify.Parser, new string[3] { "GroupRefreshList", "DimensionId", "FloorId" }, null, null, null, null)
		}));
	}
}
