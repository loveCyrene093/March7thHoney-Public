using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SpaceZooBornCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SpaceZooBornCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdTcGFjZVpvb0Jvcm5Dc1JlcS5wcm90byI9ChFTcGFjZVpvb0Jvcm5Dc1Jl" + "cRITCgtNQVBCS0NHRkxHSxgFIAMoDRITCgtGSkpFSEdQSERBTxgKIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SpaceZooBornCsReq), SpaceZooBornCsReq.Parser, new string[2] { "MAPBKCGFLGK", "FJJEHGPHDAO" }, null, null, null, null)
		}));
	}
}
