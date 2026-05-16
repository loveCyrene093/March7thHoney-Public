using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DEEMOEKEECMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DEEMOEKEECMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFERUVNT0VLRUVDTS5wcm90byJMCgtERUVNT0VLRUVDTRITCgtQRU5MTUVJ" + "SklGSxgBIAEoDRITCgtFRkxMUFBMQ0tCQhgHIAEoBBITCgtNUEdGR0tEQkFI" + "ThgMIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DEEMOEKEECM), DEEMOEKEECM.Parser, new string[3] { "PENLMEIJIFK", "EFLLPPLCKBB", "MPGFGKDBAHN" }, null, null, null, null)
		}));
	}
}
