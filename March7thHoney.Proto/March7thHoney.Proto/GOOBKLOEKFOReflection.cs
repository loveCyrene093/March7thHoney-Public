using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GOOBKLOEKFOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GOOBKLOEKFOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHT09CS0xPRUtGTy5wcm90byJMCgtHT09CS0xPRUtGTxITCgtFTUZITEJC" + "T0NGSxgBIAEoDRITCgtMSkRJR05ER0NGShgFIAEoDRITCgtKS0NHQ0FNSUZJ" + "QRgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GOOBKLOEKFO), GOOBKLOEKFO.Parser, new string[3] { "EMFHLBBOCFK", "LJDIGNDGCFJ", "JKCGCAMIFIA" }, null, null, null, null)
		}));
	}
}
