using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DynamicValuesReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DynamicValuesReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNEeW5hbWljVmFsdWVzLnByb3RvIisKDUR5bmFtaWNWYWx1ZXMSCwoDa2V5" + "GAcgASgJEg0KBXZhbHVlGA4gASgCQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DynamicValues), DynamicValues.Parser, new string[2] { "Key", "Value" }, null, null, null, null)
		}));
	}
}
