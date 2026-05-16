using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OEMNHGMPMPDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OEMNHGMPMPDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPRU1OSEdNUE1QRC5wcm90bxoRRE9HR0lETklOSlAucHJvdG8iMAoLT0VN" + "TkhHTVBNUEQSIQoLRU5QR0FHQk1IT0UYCCABKAsyDC5ET0dHSUROSU5KUEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { DOGGIDNINJPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OEMNHGMPMPD), OEMNHGMPMPD.Parser, new string[1] { "ENPGAGBMHOE" }, null, null, null, null)
		}));
	}
}
