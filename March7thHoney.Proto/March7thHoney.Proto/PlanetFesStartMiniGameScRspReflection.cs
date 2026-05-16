using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesStartMiniGameScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesStartMiniGameScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "CiFQbGFuZXRGZXNTdGFydE1pbmlHYW1lU2NSc3AucHJvdG8aEUdJRk5PS0xL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "Q0dILnByb3RvGhFITExDREJMQ0lQSy5wcm90bxoRSk9KTEFDREJQTkEucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "dG8ikgEKG1BsYW5ldEZlc1N0YXJ0TWluaUdhbWVTY1JzcBIhCgtPSUFQSEJC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "RFBITBgEIAEoCzIMLkpPSkxBQ0RCUE5BEg8KB3JldGNvZGUYBSABKA0SIQoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "RUZCQU1HSkRBRUgYCCABKAsyDC5HSUZOT0tMS0NHSBIcCgZyZXdhcmQYCSAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "KAsyDC5ITExDREJMQ0lQS0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[3]
		{
			GIFNOKLKCGHReflection.Descriptor,
			HLLCDBLCIPKReflection.Descriptor,
			JOJLACDBPNAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesStartMiniGameScRsp), PlanetFesStartMiniGameScRsp.Parser, new string[4] { "OIAPHBBDPHL", "Retcode", "EFBAMGJDAEH", "Reward" }, null, null, null, null)
		}));
	}
}
