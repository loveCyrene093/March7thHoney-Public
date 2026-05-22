using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ExpeditionInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ExpeditionInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRFeHBlZGl0aW9uSW5mby5wcm90byIcCg5FeHBlZGl0aW9uSW5mbxIKCgJp" + "ZBgIIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ExpeditionInfo), ExpeditionInfo.Parser, new string[1] { "Id" }, null, null, null, null)
		}));
	}
}
