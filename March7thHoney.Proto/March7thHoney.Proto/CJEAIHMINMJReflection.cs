using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CJEAIHMINMJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CJEAIHMINMJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDSkVBSUhNSU5NSi5wcm90byINCgtDSkVBSUhNSU5NSkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CJEAIHMINMJ), CJEAIHMINMJ.Parser, null, null, null, null, null)
		}));
	}
}
