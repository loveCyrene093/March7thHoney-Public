using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesGetFriendRankingInfoListScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesGetFriendRankingInfoListScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CixQbGFuZXRGZXNHZXRGcmllbmRSYW5raW5nSW5mb0xpc3RTY1JzcC5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "bxoRRkZGS0ZLSEhFT0cucHJvdG8iXAomUGxhbmV0RmVzR2V0RnJpZW5kUmFu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "a2luZ0luZm9MaXN0U2NSc3ASDwoHcmV0Y29kZRgGIAEoDRIhCgtLTk5JQUVC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "TUhHTRgIIAEoCzIMLkZGRktGS0hIRU9HQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { FFFKFKHHEOGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesGetFriendRankingInfoListScRsp), PlanetFesGetFriendRankingInfoListScRsp.Parser, new string[2] { "Retcode", "KNNIAEBMHGM" }, null, null, null, null)
		}));
	}
}
