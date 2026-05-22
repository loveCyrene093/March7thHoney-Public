using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GNBKKPOLLAAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GNBKKPOLLAAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHTkJLS1BPTExBQS5wcm90byIiCgtHTkJLS1BPTExBQRITCgtDSEVIRUxQ" + "TUFJQRgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GNBKKPOLLAA), GNBKKPOLLAA.Parser, new string[1] { "CHEHELPMAIA" }, null, null, null, null)
		}));
	}
}
