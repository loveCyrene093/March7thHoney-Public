using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishTutorialCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishTutorialCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlGaW5pc2hUdXRvcmlhbENzUmVxLnByb3RvGhhUdXRvcmlhbEZpbmlzaFR5" + "cGUucHJvdG8iVAoTRmluaXNoVHV0b3JpYWxDc1JlcRITCgt0dXRvcmlhbF9p" + "ZBgFIAEoDRIoCgtOR0pLSUlJSkJJQhgLIAEoDjITLlR1dG9yaWFsRmluaXNo" + "VHlwZUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { TutorialFinishTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishTutorialCsReq), FinishTutorialCsReq.Parser, new string[2] { "TutorialId", "NGJKIIIJBIB" }, null, null, null, null)
		}));
	}
}
