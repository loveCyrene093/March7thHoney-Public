using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPlayerBoardDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPlayerBoardDataScRspReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 0) = "Ch1HZXRQbGF5ZXJCb2FyZERhdGFTY1JzcC5wcm90bxoWRGlzcGxheUF2YXRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 1) = "clZlYy5wcm90bxoTSGVhZEZyYW1lSW5mby5wcm90bxoSSGVhZEljb25EYXRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 2) = "LnByb3RvIskCChdHZXRQbGF5ZXJCb2FyZERhdGFTY1JzcBIcChRjdXJyZW50";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 3) = "X2hlYWRfaWNvbl9pZBgCIAEoDRIgChhjdXJyZW50X3BlcnNvbmFsX2NhcmRf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 4) = "aWQYAyABKA0SJwoPaGVhZF9mcmFtZV9pbmZvGAQgASgLMg4uSGVhZEZyYW1l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 5) = "SW5mbxIRCglzaWduYXR1cmUYBiABKAkSIwobdW5sb2NrZWRfcGVyc29uYWxf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 6) = "Y2FyZF9saXN0GAcgAygNEg8KB3JldGNvZGUYCCABKA0SLgoXdW5sb2NrZWRf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 7) = "aGVhZF9pY29uX2xpc3QYCSADKAsyDS5IZWFkSWNvbkRhdGESHQoVYXNzaXN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 8) = "X2F2YXRhcl9pZF9saXN0GA4gAygNEi0KEmRpc3BsYXlfYXZhdGFyX3ZlYxgP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 9) = "IAEoCzIRLkRpc3BsYXlBdmF0YXJWZWNCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 10) = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray11<string>, string>(in buffer, 11))), new FileDescriptor[3]
		{
			DisplayAvatarVecReflection.Descriptor,
			HeadFrameInfoReflection.Descriptor,
			HeadIconDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPlayerBoardDataScRsp), GetPlayerBoardDataScRsp.Parser, new string[9] { "CurrentHeadIconId", "CurrentPersonalCardId", "HeadFrameInfo", "Signature", "UnlockedPersonalCardList", "Retcode", "UnlockedHeadIconList", "AssistAvatarIdList", "DisplayAvatarVec" }, null, null, null, null)
		}));
	}
}
