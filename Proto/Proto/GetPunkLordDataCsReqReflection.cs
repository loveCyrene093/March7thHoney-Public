using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPunkLordDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPunkLordDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRQdW5rTG9yZERhdGFDc1JlcS5wcm90byIWChRHZXRQdW5rTG9yZERh" + "dGFDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPunkLordDataCsReq), GetPunkLordDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
