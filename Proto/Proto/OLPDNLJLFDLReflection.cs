using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OLPDNLJLFDLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OLPDNLJLFDLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPTFBETkxKTEZETC5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJCCgtPTFBE" + "TkxKTEZETBIgCgthdmF0YXJfdHlwZRgIIAEoDjILLkF2YXRhclR5cGUSEQoJ" + "YXZhdGFyX2lkGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OLPDNLJLFDL), OLPDNLJLFDL.Parser, new string[2] { "AvatarType", "AvatarId" }, null, null, null, null)
		}));
	}
}
