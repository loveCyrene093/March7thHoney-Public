using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LDAAPHCJENLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LDAAPHCJENLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMREFBUEhDSkVOTC5wcm90byJhCgtMREFBUEhDSkVOTBITCgtMREdKTERB" + "TkpKTBgBIAEoDRITCgtBSU5HSEhPQkVIUBgCIAEoBRITCgtES0VDQUdHQUZI" + "RBgDIAEoBRITCgtMS01FREhDQkRISxgEIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LDAAPHCJENL), LDAAPHCJENL.Parser, new string[4] { "LDGJLDANJJL", "AINGHHOBEHP", "DKECAGGAFHD", "LKMEDHCBDHK" }, null, null, null, null)
		}));
	}
}
