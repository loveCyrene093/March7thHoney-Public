using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EPPJHNIHAFLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EPPJHNIHAFLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFUFBKSE5JSEFGTC5wcm90bxoRSUNPTU1DQUpETEkucHJvdG8iSAoLRVBQ" + "SkhOSUhBRkwSIQoLSlBQR0ZMSkhESEsYBSABKAsyDC5JQ09NTUNBSkRMSRIW" + "Cg5xdWV1ZV9wb3NpdGlvbhgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[1] { ICOMMCAJDLIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EPPJHNIHAFL), EPPJHNIHAFL.Parser, new string[2] { "JPPGFLJHDHK", "QueuePosition" }, null, null, null, null)
		}));
	}
}
