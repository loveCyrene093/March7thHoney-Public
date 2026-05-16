using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AEOEFOILEBPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AEOEFOILEBPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBRU9FRk9JTEVCUC5wcm90byJeCgtBRU9FRk9JTEVCUBITCgtEQUNPS0ZD" + "Qk1CSRgBIAEoDRITCgtCR0FETERFSElJQhgGIAEoDRIQCghwYW5lbF9pZBgI" + "IAEoDRITCgtDRk9GT0NLSkdDRxgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AEOEFOILEBP), AEOEFOILEBP.Parser, new string[4] { "DACOKFCBMBI", "BGADLDEHIIB", "PanelId", "CFOFOCKJGCG" }, null, null, null, null)
		}));
	}
}
