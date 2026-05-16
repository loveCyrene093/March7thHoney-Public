using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IAMLOJCIKIHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IAMLOJCIKIHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJQU1MT0pDSUtJSC5wcm90byIqCgtJQU1MT0pDSUtJSBINCgV2YWx1ZRgK" + "IAEoBRIMCgR0eXBlGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IAMLOJCIKIH), IAMLOJCIKIH.Parser, new string[2] { "Value", "Type" }, null, null, null, null)
		}));
	}
}
