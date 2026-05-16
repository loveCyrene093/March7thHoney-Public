using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PNDIINAHJAFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PNDIINAHJAFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQTkRJSU5BSEpBRi5wcm90bxoRSkxGSktJRERLQkcucHJvdG8iRAoLUE5E" + "SUlOQUhKQUYSEQoJdW5pcXVlX2lkGAwgASgNEiIKC0RQRUxFSUlBS0FBGOIL" + "IAEoCzIMLkpMRkpLSURES0JHQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[1] { JLFJKIDDKBGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PNDIINAHJAF), PNDIINAHJAF.Parser, new string[2] { "UniqueId", "DPELEIIAKAA" }, null, null, null, null)
		}));
	}
}
