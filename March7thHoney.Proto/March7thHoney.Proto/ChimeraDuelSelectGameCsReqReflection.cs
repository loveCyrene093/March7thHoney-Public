using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelSelectGameCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelSelectGameCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDaGltZXJhRHVlbFNlbGVjdEdhbWVDc1JlcS5wcm90byIxChpDaGltZXJh" + "RHVlbFNlbGVjdEdhbWVDc1JlcRITCgtNQVBETkxCSEhDRBgCIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelSelectGameCsReq), ChimeraDuelSelectGameCsReq.Parser, new string[1] { "MAPDNLBHHCD" }, null, null, null, null)
		}));
	}
}
