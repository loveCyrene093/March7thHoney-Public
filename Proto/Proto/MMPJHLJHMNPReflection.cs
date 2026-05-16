using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MMPJHLJHMNPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MMPJHLJHMNPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNTVBKSExKSE1OUC5wcm90byJJCgtNTVBKSExKSE1OUBITCgtESFBITENI" + "UEtGTBgEIAEoDRITCgtJTk9NRkZBSUVPQRgHIAEoDRIQCghncm91cF9pZBgK" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MMPJHLJHMNP), MMPJHLJHMNP.Parser, new string[3] { "DHPHLCHPKFL", "INOMFFAIEOA", "GroupId" }, null, null, null, null)
		}));
	}
}
