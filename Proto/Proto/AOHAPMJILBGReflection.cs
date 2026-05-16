using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AOHAPMJILBGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AOHAPMJILBGReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFBT0hBUE1KSUxCRy5wcm90byKkAQoLQU9IQVBNSklMQkcSHAoUZHJlc3Nf";
		buffer[1] = "cm9sZV91bmlxdWVfaWQYCSABKA0SDwoHcm9sZV9pZBgMIAEoDRIyCgtFRUJL";
		buffer[2] = "REVNRVBKSxgOIAMoCzIdLkFPSEFQTUpJTEJHLkVFQktERU1FUEpLRW50cnka";
		buffer[3] = "MgoQRUVCS0RFTUVQSktFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiAB";
		buffer[4] = "KA06AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AOHAPMJILBG), AOHAPMJILBG.Parser, new string[3] { "DressRoleUniqueId", "RoleId", "EEBKDEMEPJK" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
