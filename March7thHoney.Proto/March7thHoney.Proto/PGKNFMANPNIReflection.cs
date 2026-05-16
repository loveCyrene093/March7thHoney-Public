using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PGKNFMANPNIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PGKNFMANPNIReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFQR0tORk1BTlBOSS5wcm90bxoRRkxDUEFQT0pCR1AucHJvdG8aEUxHTUlC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "TENBRUZBLnByb3RvIp4BCgtQR0tORk1BTlBOSRITCgtPQk9KT0lIRENHSxgB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "IAEoDRITCgtQTU1ERkZGTkZJTxgCIAEoDRIPCgdyb29tX2lkGAMgASgNEiEK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "C0VMSUdKREhKRUFDGAQgASgLMgwuTEdNSUJMQ0FFRkESEwoLTEhFTkRPT0dC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "Q0sYByABKA0SHAoGc3RhdHVzGAsgASgOMgwuRkxDUEFQT0pCR1BCFqoCE01h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			FLCPAPOJBGPReflection.Descriptor,
			LGMIBLCAEFAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PGKNFMANPNI), PGKNFMANPNI.Parser, new string[6] { "OBOJOIHDCGK", "PMMDFFFNFIO", "RoomId", "ELIGJDHJEAC", "LHENDOOGBCK", "Status" }, null, null, null, null)
		}));
	}
}
