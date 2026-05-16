using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HBIKLIPBJNOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HBIKLIPBJNOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQklLTElQQkpOTy5wcm90byIiCgtIQklLTElQQkpOTxITCgtkaWFsb2d1" + "ZV9pZBgJIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HBIKLIPBJNO), HBIKLIPBJNO.Parser, new string[1] { "DialogueId" }, null, null, null, null)
		}));
	}
}
