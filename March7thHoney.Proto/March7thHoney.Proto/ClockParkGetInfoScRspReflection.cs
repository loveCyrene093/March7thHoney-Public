using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ClockParkGetInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ClockParkGetInfoScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChtDbG9ja1BhcmtHZXRJbmZvU2NSc3AucHJvdG8aEURIQkNDTU1ITkNLLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "b3RvIpwBChVDbG9ja1BhcmtHZXRJbmZvU2NSc3ASEAoIcHJvZ3Jlc3MYASAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "KA0SEwoLQURKRUhCTExCTkgYAiADKA0SIQoLTklFQ0ZETEpQRkkYBiADKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "DC5ESEJDQ01NSE5DSxITCgtDRE5HS09GQkhMRxgIIAEoDRITCgtITE5FTUxN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "S0VDUBgMIAEoDRIPCgdyZXRjb2RlGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { DHBCCMMHNCKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ClockParkGetInfoScRsp), ClockParkGetInfoScRsp.Parser, new string[6] { "Progress", "ADJEHBLLBNH", "NIECFDLJPFI", "CDNGKOFBHLG", "HLNEMLMKECP", "Retcode" }, null, null, null, null)
		}));
	}
}
