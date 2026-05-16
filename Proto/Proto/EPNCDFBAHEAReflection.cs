using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EPNCDFBAHEAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EPNCDFBAHEAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFUE5DREZCQUhFQS5wcm90bxoYTWlzc2lvbkN1c3RvbVZhbHVlLnByb3Rv" + "Ij0KC0VQTkNERkJBSEVBEi4KEWN1c3RvbV92YWx1ZV9saXN0GAsgAygLMhMu" + "TWlzc2lvbkN1c3RvbVZhbHVlQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[1] { MissionCustomValueReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EPNCDFBAHEA), EPNCDFBAHEA.Parser, new string[1] { "CustomValueList" }, null, null, null, null)
		}));
	}
}
