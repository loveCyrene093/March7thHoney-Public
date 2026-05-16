using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MPCLDCFCMEFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MPCLDCFCMEFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNUENMRENGQ01FRi5wcm90byINCgtNUENMRENGQ01FRkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MPCLDCFCMEF), MPCLDCFCMEF.Parser, null, null, null, null, null)
		}));
	}
}
