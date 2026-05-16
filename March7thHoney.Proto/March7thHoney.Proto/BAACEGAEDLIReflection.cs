using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BAACEGAEDLIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BAACEGAEDLIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQUFDRUdBRURMSS5wcm90bxoRQ0pQRk5BRkxBUEQucHJvdG8iRQoLQkFB" + "Q0VHQUVETEkSEwoLSU1CT0tHRklBQ0EYAiABKA0SIQoLTERLR0pCQUxHS0MY" + "CSABKAsyDC5DSlBGTkFGTEFQREIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { CJPFNAFLAPDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BAACEGAEDLI), BAACEGAEDLI.Parser, new string[2] { "IMBOKGFIACA", "LDKGJBALGKC" }, null, null, null, null)
		}));
	}
}
