using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IBFCJBCKENIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IBFCJBCKENIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJQkZDSkJDS0VOSS5wcm90byJeCgtJQkZDSkJDS0VOSRITCgtHQkhMTkRP" + "T0xMRxgCIAEoDRIQCghjdXJfZnVuZBgJIAEoDRITCgtHS0ZFR0lCR0VHSRgM" + "IAEoDRITCgtET0JDRkRFSU1LQRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IBFCJBCKENI), IBFCJBCKENI.Parser, new string[4] { "GBHLNDOOLLG", "CurFund", "GKFEGIBGEGI", "DOBCFDEIMKA" }, null, null, null, null)
		}));
	}
}
