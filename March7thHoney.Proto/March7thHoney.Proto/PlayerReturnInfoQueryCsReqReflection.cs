using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerReturnInfoQueryCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerReturnInfoQueryCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBQbGF5ZXJSZXR1cm5JbmZvUXVlcnlDc1JlcS5wcm90byIxChpQbGF5ZXJS" + "ZXR1cm5JbmZvUXVlcnlDc1JlcRITCgtBQ0JOSEpLRkZNUBgDIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerReturnInfoQueryCsReq), PlayerReturnInfoQueryCsReq.Parser, new string[1] { "ACBNHJKFFMP" }, null, null, null, null)
		}));
	}
}
