using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HHIPKINNCAPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HHIPKINNCAPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFISElQS0lOTkNBUC5wcm90byI3CgtISElQS0lOTkNBUBITCgtJQk5FTEFK" + "Sk9BTxgBIAEoDRITCgtOR0FHSE1ETFBHRhgCIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HHIPKINNCAP), HHIPKINNCAP.Parser, new string[2] { "IBNELAJJOAO", "NGAGHMDLPGF" }, null, null, null, null)
		}));
	}
}
