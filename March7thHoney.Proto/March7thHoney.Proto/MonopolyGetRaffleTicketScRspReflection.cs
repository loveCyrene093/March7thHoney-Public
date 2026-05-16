using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyGetRaffleTicketScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyGetRaffleTicketScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiJNb25vcG9seUdldFJhZmZsZVRpY2tldFNjUnNwLnByb3RvGhFQTkRPS09M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RVBMQy5wcm90byJnChxNb25vcG9seUdldFJhZmZsZVRpY2tldFNjUnNwEg8K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "B3JldGNvZGUYBSABKA0SEwoLTUJNSUNDSkVCSkIYCiABKA0SIQoLRUxORk5N";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Sk1BSUwYDSADKAsyDC5QTkRPS09MRVBMQ0IWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { PNDOKOLEPLCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGetRaffleTicketScRsp), MonopolyGetRaffleTicketScRsp.Parser, new string[3] { "Retcode", "MBMICCJEBJB", "ELNFNMJMAIL" }, null, null, null, null)
		}));
	}
}
