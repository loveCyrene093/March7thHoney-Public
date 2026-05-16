using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightSeasonTalentResetScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightSeasonTalentResetScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVHcmlkRmlnaHRTZWFzb25UYWxlbnRSZXNldFNjUnNwLnByb3RvIjIKH0dy" + "aWRGaWdodFNlYXNvblRhbGVudFJlc2V0U2NSc3ASDwoHcmV0Y29kZRgLIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSeasonTalentResetScRsp), GridFightSeasonTalentResetScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
