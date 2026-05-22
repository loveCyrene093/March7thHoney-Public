using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GKPPDJEFBPAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GKPPDJEFBPAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHS1BQREpFRkJQQS5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIlsKC0dL" + "UFBESkVGQlBBEhMKC0pBRk5DT01HQUJHGAEgASgNEiIKC0tCRUZLT05QS0dK" + "GAcgASgLMg0uSXRlbUNvc3REYXRhEhMKC0VJSUFHQUJBRkVDGAggASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GKPPDJEFBPA), GKPPDJEFBPA.Parser, new string[3] { "JAFNCOMGABG", "KBEFKONPKGJ", "EIIAGABAFEC" }, null, null, null, null)
		}));
	}
}
