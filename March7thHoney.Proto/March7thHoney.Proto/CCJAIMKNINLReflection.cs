using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CCJAIMKNINLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CCJAIMKNINLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDQ0pBSU1LTklOTC5wcm90bxoRSUxMQk5LRkJOQlAucHJvdG8iMAoLQ0NK" + "QUlNS05JTkwSIQoLSEVNT0NNSkFCUEEYDyABKAsyDC5JTExCTktGQk5CUEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ILLBNKFBNBPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CCJAIMKNINL), CCJAIMKNINL.Parser, new string[1] { "HEMOCMJABPA" }, null, null, null, null)
		}));
	}
}
