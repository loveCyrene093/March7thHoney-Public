using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BNPJCNDIPOMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BNPJCNDIPOMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCTlBKQ05ESVBPTS5wcm90bxoSRmF0ZUJ1ZmZEYXRhLnByb3RvIkYKC0JO" + "UEpDTkRJUE9NEhMKC0RCUE5EQ0RFQ0tEGAMgAygNEiIKC0dEQ0dCSUVGSUdP" + "GAUgAygLMg0uRmF0ZUJ1ZmZEYXRhQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[1] { FateBuffDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BNPJCNDIPOM), BNPJCNDIPOM.Parser, new string[2] { "DBPNDCDECKD", "GDCGBIEFIGO" }, null, null, null, null)
		}));
	}
}
