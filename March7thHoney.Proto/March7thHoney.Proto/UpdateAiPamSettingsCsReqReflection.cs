using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateAiPamSettingsCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateAiPamSettingsCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5VcGRhdGVBaVBhbVNldHRpbmdzQ3NSZXEucHJvdG8iLwoYVXBkYXRlQWlQ" + "YW1TZXR0aW5nc0NzUmVxEhMKC0VLQk1JT0NPTElDGAogASgIQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateAiPamSettingsCsReq), UpdateAiPamSettingsCsReq.Parser, new string[1] { "EKBMIOCOLIC" }, null, null, null, null)
		}));
	}
}
