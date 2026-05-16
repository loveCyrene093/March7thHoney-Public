using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AOOLDKDFOBOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AOOLDKDFOBOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBT09MREtERk9CTy5wcm90bxoRQU1LQUdLRk9GQk4ucHJvdG8aEUZGTElN" + "TE1GQUJQLnByb3RvIk4KC0FPT0xES0RGT0JPEhwKBnNvdXJjZRgIIAEoDjIM" + "LkZGTElNTE1GQUJQEiEKC0pQUEdGTEpIREhLGA4gASgLMgwuQU1LQUdLRk9G" + "Qk5CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[2]
		{
			AMKAGKFOFBNReflection.Descriptor,
			FFLIMLMFABPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AOOLDKDFOBO), AOOLDKDFOBO.Parser, new string[2] { "Source", "JPPGFLJHDHK" }, null, null, null, null)
		}));
	}
}
