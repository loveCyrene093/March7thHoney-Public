using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GDMIIBNJJEJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GDMIIBNJJEJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHRE1JSUJOSkpFSi5wcm90byIeCgtHRE1JSUJOSkpFShIPCgdyZXRjb2Rl" + "GAogASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GDMIIBNJJEJ), GDMIIBNJJEJ.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
