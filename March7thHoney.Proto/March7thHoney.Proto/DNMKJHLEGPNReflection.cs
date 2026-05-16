using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DNMKJHLEGPNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DNMKJHLEGPNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFETk1LSkhMRUdQTi5wcm90byIiCgtETk1LSkhMRUdQThITCgtGQUlQT0NJ" + "QUZPRBgBIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DNMKJHLEGPN), DNMKJHLEGPN.Parser, new string[1] { "FAIPOCIAFOD" }, null, null, null, null)
		}));
	}
}
