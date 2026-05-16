using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JLPGIGPCIAGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JLPGIGPCIAGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKTFBHSUdQQ0lBRy5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIjEKC0pM" + "UEdJR1BDSUFHEiIKC0VCTUtCREpNQUFGGAsgASgLMg0uSXRlbUNvc3REYXRh" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JLPGIGPCIAG), JLPGIGPCIAG.Parser, new string[1] { "EBMKBDJMAAF" }, null, null, null, null)
		}));
	}
}
