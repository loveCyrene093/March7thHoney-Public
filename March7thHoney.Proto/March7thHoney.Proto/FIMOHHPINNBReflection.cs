using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FIMOHHPINNBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FIMOHHPINNBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGSU1PSEhQSU5OQi5wcm90bxoRTVBLSkVDTkdGUEYucHJvdG8iOAoLRklN" + "T0hIUElOTkISGgoEdHlwZRgBIAEoDjIMLk1QS0pFQ05HRlBGEg0KBWNvdW50" + "GAIgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { MPKJECNGFPFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FIMOHHPINNB), FIMOHHPINNB.Parser, new string[2] { "Type", "Count" }, null, null, null, null)
		}));
	}
}
