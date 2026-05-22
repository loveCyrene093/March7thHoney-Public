using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightPortalBuffActionResultReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightPortalBuffActionResultReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVHcmlkRmlnaHRQb3J0YWxCdWZmQWN0aW9uUmVzdWx0LnByb3RvIkAKH0dy" + "aWRGaWdodFBvcnRhbEJ1ZmZBY3Rpb25SZXN1bHQSHQoVc2VsZWN0X3BvcnRh" + "bF9idWZmX2lkGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightPortalBuffActionResult), GridFightPortalBuffActionResult.Parser, new string[1] { "SelectPortalBuffId" }, null, null, null, null)
		}));
	}
}
