using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BEGMHEEKGIFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BEGMHEEKGIFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCRUdNSEVFS0dJRi5wcm90byIpCgtCRUdNSEVFS0dJRhILCgNrZXkYASAB" + "KAkSDQoFdmFsdWUYAiABKAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BEGMHEEKGIF), BEGMHEEKGIF.Parser, new string[2] { "Key", "Value" }, null, null, null, null)
		}));
	}
}
