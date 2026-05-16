using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BBHPOJJLFECReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BBHPOJJLFECReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQkhQT0pKTEZFQy5wcm90byJhCgtCQkhQT0pKTEZFQxITCgtBS0FHQUFN" + "T0pDRhgEIAEoDRITCgtCSExBQk1JT0RHTxgJIAMoDRITCgtKR0FJUEhDSUpI" + "QhgMIAMoDRITCgtJRUFJTE9DTUtOThgNIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BBHPOJJLFEC), BBHPOJJLFEC.Parser, new string[4] { "AKAGAAMOJCF", "BHLABMIODGO", "JGAIPHCIJHB", "IEAILOCMKNN" }, null, null, null, null)
		}));
	}
}
