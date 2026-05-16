using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateMainMissionCustomValueCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateMainMissionCustomValueCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidVcGRhdGVNYWluTWlzc2lvbkN1c3RvbVZhbHVlQ3NSZXEucHJvdG8iYAoh" + "VXBkYXRlTWFpbk1pc3Npb25DdXN0b21WYWx1ZUNzUmVxEhMKC0RMQ0xESUFP" + "SU1LGAQgASgJEg0KBXZhbHVlGAUgASgNEhcKD21haW5fbWlzc2lvbl9pZBgM" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateMainMissionCustomValueCsReq), UpdateMainMissionCustomValueCsReq.Parser, new string[3] { "DLCLDIAOIMK", "Value", "MainMissionId" }, null, null, null, null)
		}));
	}
}
