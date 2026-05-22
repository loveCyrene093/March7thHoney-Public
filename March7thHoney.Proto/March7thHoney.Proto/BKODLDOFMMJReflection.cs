using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BKODLDOFMMJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BKODLDOFMMJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCS09ETERPRk1NSi5wcm90byI3CgtCS09ETERPRk1NShITCgtFSUNFQkpQ" + "TUhNQxgBIAEoDRITCgtESEhHTEdKQkRNShgPIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BKODLDOFMMJ), BKODLDOFMMJ.Parser, new string[2] { "EICEBJPMHMC", "DHHGLGJBDMJ" }, null, null, null, null)
		}));
	}
}
