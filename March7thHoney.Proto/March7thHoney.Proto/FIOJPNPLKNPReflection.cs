using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FIOJPNPLKNPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FIOJPNPLKNPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGSU9KUE5QTEtOUC5wcm90bxoRTktQSkNBQk5MS0wucHJvdG8iRQoLRklP" + "SlBOUExLTlASIQoLSFBPS09ISkRESE8YDCABKA4yDC5OS1BKQ0FCTkxLTBIT" + "CgtIRkpORE9BSURPUBgNIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { NKPJCABNLKLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FIOJPNPLKNP), FIOJPNPLKNP.Parser, new string[2] { "HPOKOHJDDHO", "HFJNDOAIDOP" }, null, null, null, null)
		}));
	}
}
