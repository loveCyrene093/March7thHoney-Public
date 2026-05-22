using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakePunkLordPointRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakePunkLordPointRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiJUYWtlUHVua0xvcmRQb2ludFJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dC5wcm90byJuChxUYWtlUHVua0xvcmRQb2ludFJld2FyZFNjUnNwEhkKBnJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "d2FyZBgEIAEoCzIJLkl0ZW1MaXN0Eg0KBWxldmVsGAYgASgNEg8KB3JldGNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ZGUYCiABKA0SEwoLT0lOTUVORlBPRFAYDyABKAhCFqoCE01hcmNoN3RoSG9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakePunkLordPointRewardScRsp), TakePunkLordPointRewardScRsp.Parser, new string[4] { "Reward", "Level", "Retcode", "OINMENFPODP" }, null, null, null, null)
		}));
	}
}
