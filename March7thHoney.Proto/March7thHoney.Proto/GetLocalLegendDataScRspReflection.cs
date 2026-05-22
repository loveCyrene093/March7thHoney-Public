using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetLocalLegendDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetLocalLegendDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXRMb2NhbExlZ2VuZERhdGFTY1JzcC5wcm90bxoRTU1QSkhMSkhNTlAu" + "cHJvdG8iUQoXR2V0TG9jYWxMZWdlbmREYXRhU2NSc3ASDwoHcmV0Y29kZRgC" + "IAEoDRIlCg9sZXZlbF9kYXRhX2xpc3QYBiADKAsyDC5NTVBKSExKSE1OUEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { MMPJHLJHMNPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetLocalLegendDataScRsp), GetLocalLegendDataScRsp.Parser, new string[2] { "Retcode", "LevelDataList" }, null, null, null, null)
		}));
	}
}
