using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class COBPAMNPPNHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static COBPAMNPPNHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDT0JQQU1OUFBOSC5wcm90bxoRSVBIRkRFTENOQkQucHJvdG8iRQoLQ09C" + "UEFNTlBQTkgSEwoLUEVOTE1FSUpJRksYBSABKA0SIQoLRU1BTUZKR0dNQUEY" + "ByABKAsyDC5JUEhGREVMQ05CREIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { IPHFDELCNBDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(COBPAMNPPNH), COBPAMNPPNH.Parser, new string[2] { "PENLMEIJIFK", "EMAMFJGGMAA" }, null, null, null, null)
		}));
	}
}
