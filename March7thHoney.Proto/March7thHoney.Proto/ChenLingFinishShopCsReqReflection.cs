using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingFinishShopCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingFinishShopCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1DaGVuTGluZ0ZpbmlzaFNob3BDc1JlcS5wcm90byIZChdDaGVuTGluZ0Zp" + "bmlzaFNob3BDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingFinishShopCsReq), ChenLingFinishShopCsReq.Parser, null, null, null, null, null)
		}));
	}
}
