using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusSnsLikeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusSnsLikeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpIZWxpb2J1c1Nuc0xpa2VDc1JlcS5wcm90byIrChRIZWxpb2J1c1Nuc0xp" + "a2VDc1JlcRITCgtDREtFREZQRUZJShgLIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusSnsLikeCsReq), HeliobusSnsLikeCsReq.Parser, new string[1] { "CDKEDFPEFIJ" }, null, null, null, null)
		}));
	}
}
