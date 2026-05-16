using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NNKJBNNANJKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NNKJBNNANJKReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFOTktKQk5OQU5KSy5wcm90bxoRQU1ETUhKUFBDTkYucHJvdG8aEVBMR0RL";
		buffer[1] = "RkZORElCLnByb3RvIqgBCgtOTktKQk5OQU5KSxIUCgx0dXJuX2NvdW50ZXIY";
		buffer[2] = "ASABKA0SEwoLUEVCR05GUEdKTUEYAiABKA0SEwoLSUxQUEZPQVBJSU0YAyAB";
		buffer[3] = "KA0SIQoLSkZKUEpJSkxBT0cYBCADKAsyDC5QTEdES0ZGTkRJQhIhCgtLREFC";
		buffer[4] = "S05ESE1KTBgFIAMoCzIMLkFNRE1ISlBQQ05GEhMKC0dHRUZHTEJNTUtQGAYg";
		buffer[5] = "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			AMDMHJPPCNFReflection.Descriptor,
			PLGDKFFNDIBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NNKJBNNANJK), NNKJBNNANJK.Parser, new string[6] { "TurnCounter", "PEBGNFPGJMA", "ILPPFOAPIIM", "JFJPJIJLAOG", "KDABKNDHMJL", "GGEFGLBMMKP" }, null, null, null, null)
		}));
	}
}
