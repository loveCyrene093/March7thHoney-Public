using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PMKEENOFAPCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PMKEENOFAPCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQTUtFRU5PRkFQQy5wcm90bxoRT0xKSkpCQ0tMREsucHJvdG8iUwoLUE1L" + "RUVOT0ZBUEMSIQoLSE5MQUVJQkRGSk0YAiABKAsyDC5PTEpKSkJDS0xESxIh" + "CgtETkFPQkZMQUNJRxgHIAMoCzIMLk9MSkpKQkNLTERLQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { OLJJJBCKLDKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PMKEENOFAPC), PMKEENOFAPC.Parser, new string[2] { "HNLAEIBDFJM", "DNAOBFLACIG" }, null, null, null, null)
		}));
	}
}
