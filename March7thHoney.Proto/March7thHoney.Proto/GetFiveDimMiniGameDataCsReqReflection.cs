using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFiveDimMiniGameDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFiveDimMiniGameDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHZXRGaXZlRGltTWluaUdhbWVEYXRhQ3NSZXEucHJvdG8iMgobR2V0Rml2" + "ZURpbU1pbmlHYW1lRGF0YUNzUmVxEhMKC0tFUE1KS0dKTE5KGA8gASgIQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFiveDimMiniGameDataCsReq), GetFiveDimMiniGameDataCsReq.Parser, new string[1] { "KEPMJKGJLNJ" }, null, null, null, null)
		}));
	}
}
