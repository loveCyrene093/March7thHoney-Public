using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetStuffToAreaCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetStuffToAreaCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlTZXRTdHVmZlRvQXJlYUNzUmVxLnByb3RvGhFKRkZPTklEUE5EQS5wcm90" + "byJaChNTZXRTdHVmZlRvQXJlYUNzUmVxEhMKC0dLRkVHSUJHRUdJGAIgASgN" + "EhMKC1BFR0VMTkhHTUpBGAcgASgNEhkKA3BvcxgIIAEoDjIMLkpGRk9OSURQ" + "TkRBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { JFFONIDPNDAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetStuffToAreaCsReq), SetStuffToAreaCsReq.Parser, new string[3] { "GKFEGIBGEGI", "PEGELNHGMJA", "Pos" }, null, null, null, null)
		}));
	}
}
