using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingGetDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingGetDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDaGVuTGluZ0dldERhdGFDc1JlcS5wcm90byIWChRDaGVuTGluZ0dldERh" + "dGFDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingGetDataCsReq), ChenLingGetDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
