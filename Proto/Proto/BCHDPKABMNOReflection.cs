using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BCHDPKABMNOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BCHDPKABMNOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQ0hEUEtBQk1OTy5wcm90bxoRSVBJTUVHQ1BCR00ucHJvdG8iRQoLQkNI" + "RFBLQUJNTk8SIQoLTktKSEtNQkxJQkwYAyADKAsyDC5JUElNRUdDUEJHTRIT" + "CgtGRUFNT0tCTElBQxgHIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { IPIMEGCPBGMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BCHDPKABMNO), BCHDPKABMNO.Parser, new string[2] { "NKJHKMBLIBL", "FEAMOKBLIAC" }, null, null, null, null)
		}));
	}
}
