using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BHHNMHDDIDDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BHHNMHDDIDDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCSEhOTUhERElERC5wcm90byI3CgtCSEhOTUhERElERBITCgtFSUlBR0FC" + "QUZFQxgJIAEoDRITCgtKQUZOQ09NR0FCRxgNIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BHHNMHDDIDD), BHHNMHDDIDD.Parser, new string[2] { "EIIAGABAFEC", "JAFNCOMGABG" }, null, null, null, null)
		}));
	}
}
