using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PMNAALFCNMIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PMNAALFCNMIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQTU5BQUxGQ05NSS5wcm90byJbCgtQTU5BQUxGQ05NSRITCgtQRU5MTUVJ" + "SklGSxgBIAEoDRITCgtHRUZHT0lHSkhGShgCIAEoBBINCgVsZXZlbBgEIAEo" + "DRITCgtNT09PUEFNQk9GSxgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PMNAALFCNMI), PMNAALFCNMI.Parser, new string[4] { "PENLMEIJIFK", "GEFGOIGJHFJ", "Level", "MOOOPAMBOFK" }, null, null, null, null)
		}));
	}
}
