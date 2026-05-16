using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesClientStatusCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesClientStatusCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBQbGFuZXRGZXNDbGllbnRTdGF0dXNDc1JlcS5wcm90byIxChpQbGFuZXRG" + "ZXNDbGllbnRTdGF0dXNDc1JlcRITCgtIQ0JFREVDTEFJQxgBIAEoCEIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesClientStatusCsReq), PlanetFesClientStatusCsReq.Parser, new string[1] { "HCBEDECLAIC" }, null, null, null, null)
		}));
	}
}
