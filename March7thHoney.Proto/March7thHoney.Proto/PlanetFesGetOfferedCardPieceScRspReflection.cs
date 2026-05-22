using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesGetOfferedCardPieceScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesGetOfferedCardPieceScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "CidQbGFuZXRGZXNHZXRPZmZlcmVkQ2FyZFBpZWNlU2NSc3AucHJvdG8aEUZC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "Qk1ERkRPRUVGLnByb3RvGhFIQk1ORkdQS0VDSC5wcm90byK5AQohUGxhbmV0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "RmVzR2V0T2ZmZXJlZENhcmRQaWVjZVNjUnNwEhMKC0NBT0JMREFKT0hLGAMg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "ASgDEg8KB3JldGNvZGUYByABKA0SEwoLSkZITUNERkRBQkkYCCABKAgSEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "UEhBTEtESEhQUEIYCSABKAQSIQoLQ0dPTUNQRUJCSUEYCyADKAsyDC5GQkJN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "REZET0VFRhIhCgtDTEZQQk5HS0xBQRgMIAMoCzIMLkhCTU5GR1BLRUNIQhaq";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			FBBMDFDOEEFReflection.Descriptor,
			HBMNFGPKECHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesGetOfferedCardPieceScRsp), PlanetFesGetOfferedCardPieceScRsp.Parser, new string[6] { "CAOBLDAJOHK", "Retcode", "JFHMCDFDABI", "PHALKDHHPPB", "CGOMCPEBBIA", "CLFPBNGKLAA" }, null, null, null, null)
		}));
	}
}
