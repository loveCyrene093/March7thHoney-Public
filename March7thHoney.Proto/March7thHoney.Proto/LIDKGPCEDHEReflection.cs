using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LIDKGPCEDHEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LIDKGPCEDHEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMSURLR1BDRURIRS5wcm90bxoRR05MTUVOS0JITEUucHJvdG8iMAoLTElE" + "S0dQQ0VESEUSIQoLRlBLQURKQkRCUE8YCiABKAsyDC5HTkxNRU5LQkhMRUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GNLMENKBHLEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LIDKGPCEDHE), LIDKGPCEDHE.Parser, new string[1] { "FPKADJBDBPO" }, null, null, null, null)
		}));
	}
}
