using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishSectionIdCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishSectionIdCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpGaW5pc2hTZWN0aW9uSWRDc1JlcS5wcm90byIqChRGaW5pc2hTZWN0aW9u" + "SWRDc1JlcRISCgpzZWN0aW9uX2lkGAIgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishSectionIdCsReq), FinishSectionIdCsReq.Parser, new string[1] { "SectionId" }, null, null, null, null)
		}));
	}
}
