using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyMoveScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyMoveScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChdNb25vcG9seU1vdmVTY1JzcC5wcm90bxoRQUFIQkVDSUNPRU4ucHJvdG8a";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "EUlNRFBBSU9PSE1GLnByb3RvImoKEU1vbm9wb2x5TW92ZVNjUnNwEiEKC0xL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "T0lISE1CSE9GGAsgAygLMgwuQUFIQkVDSUNPRU4SDwoHcmV0Y29kZRgMIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "DRIhCgtBTU1KRUNIUEdQRRgPIAEoCzIMLklNRFBBSU9PSE1GQhaqAhNNYXJj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			AAHBECICOENReflection.Descriptor,
			IMDPAIOOHMFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyMoveScRsp), MonopolyMoveScRsp.Parser, new string[3] { "LKOIHHMBHOF", "Retcode", "AMMJECHPGPE" }, null, null, null, null)
		}));
	}
}
