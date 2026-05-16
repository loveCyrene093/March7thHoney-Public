using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BKABOBIHOCNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BKABOBIHOCNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCS0FCT0JJSE9DTi5wcm90bxoRQ0FFQUJISk5MTUkucHJvdG8iWgoLQktB" + "Qk9CSUhPQ04SIQoLS0RMTENGTUxNTkQYByABKAsyDC5DQUVBQkhKTkxNSRIT" + "CgtBRkdOTERJTUJHQhgKIAEoCBITCgtQSE9QQkpGTU5EQxgNIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { CAEABHJNLMIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BKABOBIHOCN), BKABOBIHOCN.Parser, new string[3] { "KDLLCFMLMND", "AFGNLDIMBGB", "PHOPBJFMNDC" }, null, null, null, null)
		}));
	}
}
