using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DHKCDCCHLHPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DHKCDCCHLHPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFESEtDRENDSExIUC5wcm90byJSCgtESEtDRENDSExIUBITCgtBT09NRU1D" + "Q1BFTRgEIAMoDRIKCgJpZBgFIAEoDRIQCghwYW5lbF9pZBgHIAEoDRIQCghw" + "cm9ncmVzcxgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DHKCDCCHLHP), DHKCDCCHLHP.Parser, new string[4] { "AOOMEMCCPEM", "Id", "PanelId", "Progress" }, null, null, null, null)
		}));
	}
}
