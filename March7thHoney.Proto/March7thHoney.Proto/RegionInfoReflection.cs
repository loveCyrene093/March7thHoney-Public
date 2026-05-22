using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RegionInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RegionInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChBSZWdpb25JbmZvLnByb3RvIo8BCgpSZWdpb25JbmZvEgwKBG5hbWUYASAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "KAkSDQoFdGl0bGUYAiABKAkSFAoMZGlzcGF0Y2hfdXJsGAMgASgJEhAKCGVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "dl90eXBlGAQgASgJEhQKDGRpc3BsYXlfbmFtZRgFIAEoCRIRCglzdG9wX2Rl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "c2MYBiABKAkSEwoLTVBESUxPTkpERUgYByABKAlCFqoCE01hcmNoN3RoSG9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RegionInfo), RegionInfo.Parser, new string[7] { "Name", "Title", "DispatchUrl", "EnvType", "DisplayName", "StopDesc", "MPDILONJDEH" }, null, null, null, null)
		}));
	}
}
