using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GMONEHJIKMAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GMONEHJIKMAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHTU9ORUhKSUtNQS5wcm90bxoLUmVsaWMucHJvdG8iJQoLR01PTkVISklL" + "TUESFgoGcmVsaWNzGAkgAygLMgYuUmVsaWNCFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { RelicReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GMONEHJIKMA), GMONEHJIKMA.Parser, new string[1] { "Relics" }, null, null, null, null)
		}));
	}
}
