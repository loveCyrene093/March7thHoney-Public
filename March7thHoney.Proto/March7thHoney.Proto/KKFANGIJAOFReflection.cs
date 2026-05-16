using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KKFANGIJAOFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KKFANGIJAOFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLS0ZBTkdJSkFPRi5wcm90bxoRREVDQU9IT05OSkcucHJvdG8iMAoLS0tG" + "QU5HSUpBT0YSIQoLRFBDQk1KR0JNR1AYDSABKAsyDC5ERUNBT0hPTk5KR0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { DECAOHONNJGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KKFANGIJAOF), KKFANGIJAOF.Parser, new string[1] { "DPCBMJGBMGP" }, null, null, null, null)
		}));
	}
}
