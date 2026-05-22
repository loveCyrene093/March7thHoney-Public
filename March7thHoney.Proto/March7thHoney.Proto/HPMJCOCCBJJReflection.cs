using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HPMJCOCCBJJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HPMJCOCCBJJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIUE1KQ09DQ0JKSi5wcm90bxoRUElOQkpOTENJQUgucHJvdG8iMAoLSFBN" + "SkNPQ0NCSkoSIQoLQ0NOSElISEdCRFAYDiABKAsyDC5QSU5CSk5MQ0lBSEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { PINBJNLCIAHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HPMJCOCCBJJ), HPMJCOCCBJJ.Parser, new string[1] { "CCNHIHHGBDP" }, null, null, null, null)
		}));
	}
}
