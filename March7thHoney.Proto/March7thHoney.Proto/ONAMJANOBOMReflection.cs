using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ONAMJANOBOMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ONAMJANOBOMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPTkFNSkFOT0JPTS5wcm90bxoRSkFGUE1MTE9HREkucHJvdG8iMAoLT05B" + "TUpBTk9CT00SIQoLUEhHTEZIRERBQ00YASADKAsyDC5KQUZQTUxMT0dESUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { JAFPMLLOGDIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ONAMJANOBOM), ONAMJANOBOM.Parser, new string[1] { "PHGLFHDDACM" }, null, null, null, null)
		}));
	}
}
