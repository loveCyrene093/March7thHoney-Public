using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FLLEBEICKCEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FLLEBEICKCEReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFGTExFQkVJQ0tDRS5wcm90bxoRTUJLTUxKQUJDQkUucHJvdG8ilAIKC0ZM";
		buffer[1] = "TEVCRUlDS0NFEg0KBWxldmVsGAEgASgNEgsKA2V4cBgDIAEoDRITCgtOQUpD";
		buffer[2] = "UE9QSkdMQhgEIAEoBRINCgVpbmRleBgFIAEoDRITCgtNTExHRU9JTkpPRxgG";
		buffer[3] = "IAEoDRIcCgZzdGF0dXMYByABKA4yDC5NQktNTEpBQkNCRRIRCgl1bmlxdWVf";
		buffer[4] = "aWQYCCABKA0SEwoLTExISkFHR0VHT0sYCSABKA0SCgoCaHAYCiABKAUSEwoL";
		buffer[5] = "UE5DTkdNRkJBTkQYCyABKA0SEwoLRERHRU9PTEhBUEcYDCABKA0SHwoXZ3Jp";
		buffer[6] = "ZF9maWdodF9lcXVpcG1lbnRfaWQYDiABKA0SEwoLRUxFQkdOSEVJTUwYDyAB";
		buffer[7] = "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MBKMLJABCBEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FLLEBEICKCE), FLLEBEICKCE.Parser, new string[13]
			{
				"Level", "Exp", "NAJCPOPJGLB", "Index", "MLLGEOINJOG", "Status", "UniqueId", "LLHJAGGEGOK", "Hp", "PNCNGMFBAND",
				"DDGEOOLHAPG", "GridFightEquipmentId", "ELEBGNHEIML"
			}, null, null, null, null)
		}));
	}
}
