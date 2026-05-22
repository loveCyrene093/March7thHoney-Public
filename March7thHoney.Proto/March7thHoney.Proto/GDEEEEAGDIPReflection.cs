using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GDEEEEAGDIPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GDEEEEAGDIPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHREVFRUVBR0RJUC5wcm90bxoRQ0dMQU5IQU1PTU0ucHJvdG8iRgoLR0RF" + "RUVFQUdESVASFAoMcGFzc2VuZ2VyX2lkGAogASgNEiEKC0lPSExERE5FTEJQ" + "GAsgAygLMgwuQ0dMQU5IQU1PTU1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[1] { CGLANHAMOMMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GDEEEEAGDIP), GDEEEEAGDIP.Parser, new string[2] { "PassengerId", "IOHLDDNELBP" }, null, null, null, null)
		}));
	}
}
