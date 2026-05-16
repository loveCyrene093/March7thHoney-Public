using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BAAHIGNNCIAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BAAHIGNNCIAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQUFISUdOTkNJQS5wcm90byJ2CgtCQUFISUdOTkNJQRITCgtGUEtNS0pF" + "RkxERRgBIAEoDRITCgtIQURHQVBMQkVNTxgCIAEoARITCgtDR09BQkdLQ0JF" + "RhgLIAEoDRITCgtFTkhPSU1MSUJKThgMIAEoDRITCgtNRUdDQUdOSE1JRRgN" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BAAHIGNNCIA), BAAHIGNNCIA.Parser, new string[5] { "FPKMKJEFLDE", "HADGAPLBEMO", "CGOABGKCBEF", "ENHOIMLIBJN", "MEGCAGNHMIE" }, null, null, null, null)
		}));
	}
}
