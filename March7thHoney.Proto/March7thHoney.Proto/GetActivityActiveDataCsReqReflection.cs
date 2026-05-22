using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetActivityActiveDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetActivityActiveDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBHZXRBY3Rpdml0eUFjdGl2ZURhdGFDc1JlcS5wcm90byIcChpHZXRBY3Rp" + "dml0eUFjdGl2ZURhdGFDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetActivityActiveDataCsReq), GetActivityActiveDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
