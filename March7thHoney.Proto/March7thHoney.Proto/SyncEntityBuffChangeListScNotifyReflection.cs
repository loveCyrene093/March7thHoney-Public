using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncEntityBuffChangeListScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncEntityBuffChangeListScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiZTeW5jRW50aXR5QnVmZkNoYW5nZUxpc3RTY05vdGlmeS5wcm90bxoaRW50";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "aXR5QnVmZkNoYW5nZUluZm8ucHJvdG8iWgogU3luY0VudGl0eUJ1ZmZDaGFu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Z2VMaXN0U2NOb3RpZnkSNgoXZW50aXR5X2J1ZmZfY2hhbmdlX2xpc3QYCiAD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "KAsyFS5FbnRpdHlCdWZmQ2hhbmdlSW5mb0IWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { EntityBuffChangeInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncEntityBuffChangeListScNotify), SyncEntityBuffChangeListScNotify.Parser, new string[1] { "EntityBuffChangeList" }, null, null, null, null)
		}));
	}
}
