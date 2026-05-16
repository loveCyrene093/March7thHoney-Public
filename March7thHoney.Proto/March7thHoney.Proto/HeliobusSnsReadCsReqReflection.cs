using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusSnsReadCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusSnsReadCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpIZWxpb2J1c1Nuc1JlYWRDc1JlcS5wcm90byIrChRIZWxpb2J1c1Nuc1Jl" + "YWRDc1JlcRITCgtDREtFREZQRUZJShgDIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusSnsReadCsReq), HeliobusSnsReadCsReq.Parser, new string[1] { "CDKEDFPEFIJ" }, null, null, null, null)
		}));
	}
}
