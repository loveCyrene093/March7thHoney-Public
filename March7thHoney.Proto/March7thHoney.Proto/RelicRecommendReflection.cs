using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicRecommendReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicRecommendReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRSZWxpY1JlY29tbWVuZC5wcm90bxoRTU5HSUlKUE1KQkUucHJvdG8iMwoO" + "UmVsaWNSZWNvbW1lbmQSIQoLUEVERkdFTUVPTksYByADKAsyDC5NTkdJSUpQ" + "TUpCRUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { MNGIIJPMJBEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicRecommend), RelicRecommend.Parser, new string[1] { "PEDFGEMEONK" }, null, null, null, null)
		}));
	}
}
