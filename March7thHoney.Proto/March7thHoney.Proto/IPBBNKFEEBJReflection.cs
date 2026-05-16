using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IPBBNKFEEBJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IPBBNKFEEBJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJUEJCTktGRUVCSi5wcm90byIiCgtJUEJCTktGRUVCShITCgtDR0RPQkFP" + "QUhNQhgDIAEoCUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IPBBNKFEEBJ), IPBBNKFEEBJ.Parser, new string[1] { "CGDOBAOAHMB" }, null, null, null, null)
		}));
	}
}
