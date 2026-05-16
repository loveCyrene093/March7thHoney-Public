using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MainMissionCustomValueReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MainMissionCustomValueReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxNYWluTWlzc2lvbkN1c3RvbVZhbHVlLnByb3RvGhFFUE5DREZCQUhFQS5w" + "cm90byJaChZNYWluTWlzc2lvbkN1c3RvbVZhbHVlEicKEWN1c3RvbV92YWx1" + "ZV9saXN0GAUgASgLMgwuRVBOQ0RGQkFIRUESFwoPbWFpbl9taXNzaW9uX2lk" + "GAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { EPNCDFBAHEAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MainMissionCustomValue), MainMissionCustomValue.Parser, new string[2] { "CustomValueList", "MainMissionId" }, null, null, null, null)
		}));
	}
}
