using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueMagicQueryCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueMagicQueryCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpSb2d1ZU1hZ2ljUXVlcnlDc1JlcS5wcm90byIWChRSb2d1ZU1hZ2ljUXVl" + "cnlDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicQueryCsReq), RogueMagicQueryCsReq.Parser, null, null, null, null, null)
		}));
	}
}
