using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightPermanentTalentResetScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightPermanentTalentResetScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihHcmlkRmlnaHRQZXJtYW5lbnRUYWxlbnRSZXNldFNjUnNwLnByb3RvIjUK" + "IkdyaWRGaWdodFBlcm1hbmVudFRhbGVudFJlc2V0U2NSc3ASDwoHcmV0Y29k" + "ZRgEIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightPermanentTalentResetScRsp), GridFightPermanentTalentResetScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
