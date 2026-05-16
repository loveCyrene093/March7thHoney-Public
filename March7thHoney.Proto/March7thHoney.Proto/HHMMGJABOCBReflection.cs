using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HHMMGJABOCBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HHMMGJABOCBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFISE1NR0pBQk9DQi5wcm90bxoRSVBIRkRFTENOQkQucHJvdG8iRQoLSEhN" + "TUdKQUJPQ0ISEwoLUEVOTE1FSUpJRksYAiABKA0SIQoLRkJIR1BQQ0tFSUMY" + "ByADKAsyDC5JUEhGREVMQ05CREIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { IPHFDELCNBDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HHMMGJABOCB), HHMMGJABOCB.Parser, new string[2] { "PENLMEIJIFK", "FBHGPPCKEIC" }, null, null, null, null)
		}));
	}
}
