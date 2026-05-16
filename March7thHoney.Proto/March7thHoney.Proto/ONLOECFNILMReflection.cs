using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ONLOECFNILMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ONLOECFNILMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPTkxPRUNGTklMTS5wcm90byIgCgtPTkxPRUNGTklMTRIRCgllbnRpdHlf" + "aWQYCCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ONLOECFNILM), ONLOECFNILM.Parser, new string[1] { "EntityId" }, null, null, null, null)
		}));
	}
}
