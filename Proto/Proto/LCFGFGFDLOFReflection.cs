using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LCFGFGFDLOFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LCFGFGFDLOFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMQ0ZHRkdGRExPRi5wcm90bxoOSXRlbUxpc3QucHJvdG8iOQoLTENGR0ZH" + "RkRMT0YSDwoHcmV0Y29kZRgKIAEoDRIZCgZyZXdhcmQYCyABKAsyCS5JdGVt" + "TGlzdEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LCFGFGFDLOF), LCFGFGFDLOF.Parser, new string[2] { "Retcode", "Reward" }, null, null, null, null)
		}));
	}
}
