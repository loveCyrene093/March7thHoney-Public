using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicSmartWearDeletePinRelicCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicSmartWearDeletePinRelicCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CidSZWxpY1NtYXJ0V2VhckRlbGV0ZVBpblJlbGljQ3NSZXEucHJvdG8aEU5I";
		buffer[1] = "Rk9HRFBCT0hOLnByb3RvIm4KIVJlbGljU21hcnRXZWFyRGVsZXRlUGluUmVs";
		buffer[2] = "aWNDc1JlcRITCgtPUENQSElDRU9PRhgDIAEoCBIRCglhdmF0YXJfaWQYBiAB";
		buffer[3] = "KA0SIQoLREhDTk1JQUlCR0YYCyADKAsyDC5OSEZPR0RQQk9ITkIWqgITTWFy";
		buffer[4] = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { NHFOGDPBOHNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicSmartWearDeletePinRelicCsReq), RelicSmartWearDeletePinRelicCsReq.Parser, new string[3] { "OPCPHICEOOF", "AvatarId", "DHCNMIAIBGF" }, null, null, null, null)
		}));
	}
}
