using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyTakeBuildLevelAwardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyTakeBuildLevelAwardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CihUcmFpblBhcnR5VGFrZUJ1aWxkTGV2ZWxBd2FyZFNjUnNwLnByb3RvGg5J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dGVtTGlzdC5wcm90byJoCiJUcmFpblBhcnR5VGFrZUJ1aWxkTGV2ZWxBd2Fy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ZFNjUnNwEhwKCWl0ZW1fbGlzdBgKIAEoCzIJLkl0ZW1MaXN0Eg8KB3JldGNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ZGUYCyABKA0SEwoLSEJMT0hPRktLS08YDyABKA1CFqoCE01hcmNoN3RoSG9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyTakeBuildLevelAwardScRsp), TrainPartyTakeBuildLevelAwardScRsp.Parser, new string[3] { "ItemList", "Retcode", "HBLOHOFKKKO" }, null, null, null, null)
		}));
	}
}
