using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetPersonalCardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetPersonalCardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTZXRQZXJzb25hbENhcmRDc1JlcS5wcm90byIiChRTZXRQZXJzb25hbENh" + "cmRDc1JlcRIKCgJpZBgHIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetPersonalCardCsReq), SetPersonalCardCsReq.Parser, new string[1] { "Id" }, null, null, null, null)
		}));
	}
}
