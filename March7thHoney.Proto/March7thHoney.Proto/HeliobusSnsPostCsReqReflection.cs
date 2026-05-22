using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusSnsPostCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusSnsPostCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpIZWxpb2J1c1Nuc1Bvc3RDc1JlcS5wcm90byJVChRIZWxpb2J1c1Nuc1Bv" + "c3RDc1JlcRITCgtJTEVNTUtQR1BORBgDIAEoDRITCgtDREtFREZQRUZJShgI" + "IAEoDRITCgtIRk9LTk9ERklKSRgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusSnsPostCsReq), HeliobusSnsPostCsReq.Parser, new string[3] { "ILEMMKPGPND", "CDKEDFPEFIJ", "HFOKNODFIJI" }, null, null, null, null)
		}));
	}
}
