using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CCKCCKHEFFBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CCKCCKHEFFBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDQ0tDQ0tIRUZGQi5wcm90bxoRTUFDSkJJQUZOT0kucHJvdG8iRQoLQ0NL" + "Q0NLSEVGRkISEwoLTkNGSEdJQkNFQkcYASABKA0SIQoLRklQSURHS1BGSEEY" + "AiADKAsyDC5NQUNKQklBRk5PSUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { MACJBIAFNOIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CCKCCKHEFFB), CCKCCKHEFFB.Parser, new string[2] { "NCFHGIBCEBG", "FIPIDGKPFHA" }, null, null, null, null)
		}));
	}
}
