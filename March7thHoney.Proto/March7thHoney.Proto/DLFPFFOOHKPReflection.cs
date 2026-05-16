using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DLFPFFOOHKPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DLFPFFOOHKPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFETEZQRkZPT0hLUC5wcm90bxoRSExKTUNJQk9CSk8ucHJvdG8aD1NwQmFy" + "SW5mby5wcm90byJRCgtETEZQRkZPT0hLUBIaCgR0eXBlGAEgASgOMgwuSExK" + "TUNJQk9CSk8SCgoCaWQYAiABKA0SGgoGc3BfYmFyGAMgASgLMgouU3BCYXJJ" + "bmZvQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[2]
		{
			HLJMCIBOBJOReflection.Descriptor,
			SpBarInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DLFPFFOOHKP), DLFPFFOOHKP.Parser, new string[3] { "Type", "Id", "SpBar" }, null, null, null, null)
		}));
	}
}
