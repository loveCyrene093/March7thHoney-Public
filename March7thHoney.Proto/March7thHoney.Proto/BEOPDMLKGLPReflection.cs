using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BEOPDMLKGLPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BEOPDMLKGLPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCRU9QRE1MS0dMUC5wcm90byI0CgtCRU9QRE1MS0dMUBITCgtMQUdHTUtH" + "TUdQQhgNIAMoDRIQCghsZXZlbF9pZBgPIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BEOPDMLKGLP), BEOPDMLKGLP.Parser, new string[2] { "LAGGMKGMGPB", "LevelId" }, null, null, null, null)
		}));
	}
}
