using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KPNJMMPJDKGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KPNJMMPJDKGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLUE5KTU1QSkRLRy5wcm90byIiCgtLUE5KTU1QSkRLRxITCgtOTEdMQkxE" + "RUtDUBgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KPNJMMPJDKG), KPNJMMPJDKG.Parser, new string[1] { "NLGLBLDEKCP" }, null, null, null, null)
		}));
	}
}
