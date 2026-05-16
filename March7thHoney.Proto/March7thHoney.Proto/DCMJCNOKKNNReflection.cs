using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DCMJCNOKKNNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DCMJCNOKKNNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEQ01KQ05PS0tOTi5wcm90bxoVQWxsZXlFdmVudFN0YXRlLnByb3RvIlUK" + "C0RDTUpDTk9LS05OEhAKCGV2ZW50X2lkGAcgASgNEh8KBXN0YXRlGAwgASgO" + "MhAuQWxsZXlFdmVudFN0YXRlEhMKC0VJQUFLRUdQS01FGA0gASgNQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { AlleyEventStateReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DCMJCNOKKNN), DCMJCNOKKNN.Parser, new string[3] { "EventId", "State", "EIAAKEGPKME" }, null, null, null, null)
		}));
	}
}
