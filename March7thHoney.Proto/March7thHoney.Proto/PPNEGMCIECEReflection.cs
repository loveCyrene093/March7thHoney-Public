using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PPNEGMCIECEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PPNEGMCIECEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQUE5FR01DSUVDRS5wcm90byJMCgtQUE5FR01DSUVDRRITCgtMTUdEQkJB" + "S0ZEQRgBIAEoBRITCgtNSktBSEVJRUROTxgCIAEoBRITCgtKUEpHRkpESEpE" + "RBgDIAEoBUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PPNEGMCIECE), PPNEGMCIECE.Parser, new string[3] { "LMGDBBAKFDA", "MJKAHEIEDNO", "JPJGFJDHJDD" }, null, null, null, null)
		}));
	}
}
