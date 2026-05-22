using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LCFDGFOCHOJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LCFDGFOCHOJReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFMQ0ZER0ZPQ0hPSi5wcm90bxoRQkFIS1BFR0lOQkIucHJvdG8aEUdLREVL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "SktPSUpOLnByb3RvGhFPTVBPREVMQ0hGRC5wcm90byKLAQoLTENGREdGT0NI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "T0oSIQoLREJBRUFIQkFKUE0YAiADKAsyDC5CQUhLUEVHSU5CQhIhCgtHT0NG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "S0xLSEJERhgGIAMoCzIMLkdLREVLSktPSUpOEhMKC0hKS0FQQkVNRU9PGAsg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "ASgEEiEKC2F2YXRhcl9saXN0GAwgAygLMgwuT01QT0RFTENIRkRCFqoCE01h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[3]
		{
			BAHKPEGINBBReflection.Descriptor,
			GKDEKJKOIJNReflection.Descriptor,
			OMPODELCHFDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LCFDGFOCHOJ), LCFDGFOCHOJ.Parser, new string[4] { "DBAEAHBAJPM", "GOCFKLKHBDF", "HJKAPBEMEOO", "AvatarList" }, null, null, null, null)
		}));
	}
}
