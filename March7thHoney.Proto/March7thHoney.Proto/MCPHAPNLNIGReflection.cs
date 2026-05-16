using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MCPHAPNLNIGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MCPHAPNLNIGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNQ1BIQVBOTE5JRy5wcm90byJ1CgtNQ1BIQVBOTE5JRxIyCgtCRU5FSUZB" + "SElHShgIIAMoCzIdLk1DUEhBUE5MTklHLkJFTkVJRkFISUdKRW50cnkaMgoQ" + "QkVORUlGQUhJR0pFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKA06" + "AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MCPHAPNLNIG), MCPHAPNLNIG.Parser, new string[1] { "BENEIFAHIGJ" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
