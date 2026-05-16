using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EntityBuffChangeInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EntityBuffChangeInfoReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChpFbnRpdHlCdWZmQ2hhbmdlSW5mby5wcm90bxoOQnVmZkluZm8ucHJvdG8a";
		buffer[1] = "H1NjZW5lRW50aXR5QnVmZkNoYW5nZVR5cGUucHJvdG8ivQEKFEVudGl0eUJ1";
		buffer[2] = "ZmZDaGFuZ2VJbmZvEhEKCWVudGl0eV9pZBgDIAEoDRIWCg5jYXN0X2VudGl0";
		buffer[3] = "eV9pZBgEIAEoDRIqCgZyZWFzb24YDCABKA4yGi5TY2VuZUVudGl0eUJ1ZmZD";
		buffer[4] = "aGFuZ2VUeXBlEiUKEGJ1ZmZfY2hhbmdlX2luZm8YCyABKAsyCS5CdWZmSW5m";
		buffer[5] = "b0gAEhgKDnJlbW92ZV9idWZmX2lkGA4gASgNSABCDQoLQlBJSEZBSkNMT0NC";
		buffer[6] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			BuffInfoReflection.Descriptor,
			SceneEntityBuffChangeTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EntityBuffChangeInfo), EntityBuffChangeInfo.Parser, new string[5] { "EntityId", "CastEntityId", "Reason", "BuffChangeInfo", "RemoveBuffId" }, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}
