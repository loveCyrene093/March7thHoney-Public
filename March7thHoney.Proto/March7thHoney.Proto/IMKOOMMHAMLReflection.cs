using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IMKOOMMHAMLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IMKOOMMHAMLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJTUtPT01NSEFNTC5wcm90bxoRRkRMQ0ZGUENIQk4ucHJvdG8iLgoLSU1L" + "T09NTUhBTUwSHwoJYnVmZl9saXN0GA0gAygLMgwuRkRMQ0ZGUENIQk5CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { FDLCFFPCHBNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IMKOOMMHAML), IMKOOMMHAML.Parser, new string[1] { "BuffList" }, null, null, null, null)
		}));
	}
}
