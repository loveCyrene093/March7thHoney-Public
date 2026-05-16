using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IPPACOOGLPKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IPPACOOGLPKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJUFBBQ09PR0xQSy5wcm90bxoRSUVBQ01ERkRMQkYucHJvdG8iRQoLSVBQ" + "QUNPT0dMUEsSIQoLcmV0dXJuX2RhdGEYCiABKAsyDC5JRUFDTURGRExCRhIT" + "CgtNR01GRU5JT1BITxgLIAEoCUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { IEACMDFDLBFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IPPACOOGLPK), IPPACOOGLPK.Parser, new string[2] { "ReturnData", "MGMFENIOPHO" }, null, null, null, null)
		}));
	}
}
