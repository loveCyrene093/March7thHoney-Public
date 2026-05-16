using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesGetBusinessDayInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesGetBusinessDayInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiZQbGFuZXRGZXNHZXRCdXNpbmVzc0RheUluZm9TY1JzcC5wcm90bxoRUEJH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "TUtORUdPUEsucHJvdG8iawogUGxhbmV0RmVzR2V0QnVzaW5lc3NEYXlJbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "U2NSc3ASEwoLQUxJR0VGS01NR0gYASABKAMSDwoHcmV0Y29kZRgMIAEoDRIh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "CgtPQURFSk9NS0tQRhgOIAEoCzIMLlBCR01LTkVHT1BLQhaqAhNNYXJjaDd0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { PBGMKNEGOPKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesGetBusinessDayInfoScRsp), PlanetFesGetBusinessDayInfoScRsp.Parser, new string[3] { "ALIGEFKMMGH", "Retcode", "OADEJOMKKPF" }, null, null, null, null)
		}));
	}
}
