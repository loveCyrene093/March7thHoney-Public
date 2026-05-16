using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SpaceZooTakeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SpaceZooTakeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdTcGFjZVpvb1Rha2VDc1JlcS5wcm90byIoChFTcGFjZVpvb1Rha2VDc1Jl" + "cRITCgtCTUxLSUJOTE5KQRgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SpaceZooTakeCsReq), SpaceZooTakeCsReq.Parser, new string[1] { "BMLKIBNLNJA" }, null, null, null, null)
		}));
	}
}
