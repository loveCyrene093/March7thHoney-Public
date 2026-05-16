using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JDPPGCIEHKFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JDPPGCIEHKFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKRFBQR0NJRUhLRi5wcm90byIiCgtKRFBQR0NJRUhLRhITCgtOTU5PQ0pE" + "SktPRxgBIAEoCUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JDPPGCIEHKF), JDPPGCIEHKF.Parser, new string[1] { "NMNOCJDJKOG" }, null, null, null, null)
		}));
	}
}
