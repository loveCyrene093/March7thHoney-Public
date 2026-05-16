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
		buffer[0] = "ChFQR0tORk1BTlBOSS5wcm90bxoRRkxDUEFQT0pCR1AucHJvdG8aEUxHTUlC";
		buffer[1] = "TENBRUZBLnByb3RvIp4BCgtQR0tORk1BTlBOSRITCgtPQk9KT0lIRENHSxgB";
		buffer[2] = "IAEoDRITCgtQTU1ERkZGTkZJTxgCIAEoDRIPCgdyb29tX2lkGAMgASgNEiEK";
		buffer[3] = "C0VMSUdKREhKRUFDGAQgASgLMgwuTEdNSUJMQ0FFRkESEwoLTEhFTkRPT0dC";
		buffer[4] = "Q0sYByABKA0SHAoGc3RhdHVzGAsgASgOMgwuRkxDUEFQT0pCR1BCFqoCE01h";
		buffer[5] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			FLCPAPOJBGPReflection.Descriptor,
			LGMIBLCAEFAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PGKNFMANPNI), PGKNFMANPNI.Parser, new string[6] { "OBOJOIHDCGK", "PMMDFFFNFIO", "RoomId", "ELIGJDHJEAC", "LHENDOOGBCK", "Status" }, null, null, null, null)
		}));
	}
}
