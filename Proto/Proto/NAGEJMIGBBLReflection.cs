using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NAGEJMIGBBLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NAGEJMIGBBLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQUdFSk1JR0JCTC5wcm90bxoRSkNQUEVCR0VLSEMucHJvdG8iWgoLTkFH" + "RUpNSUdCQkwSEwoLQ0tHTEZJTk9EQkwYASABKA0SEwoLREVOTU1GSkRDRUQY" + "AiABKA0SIQoLTEZEREhCQUxNR04YAyADKAsyDC5KQ1BQRUJHRUtIQ0IWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { JCPPEBGEKHCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NAGEJMIGBBL), NAGEJMIGBBL.Parser, new string[3] { "CKGLFINODBL", "DENMMFJDCED", "LFDDHBALMGN" }, null, null, null, null)
		}));
	}
}
