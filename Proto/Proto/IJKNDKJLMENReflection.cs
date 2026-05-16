using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IJKNDKJLMENReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IJKNDKJLMENReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFJSktOREtKTE1FTi5wcm90bxoVUm9ndWVSb29tU3RhdHVzLnByb3RvIpYB";
		buffer[1] = "CgtJSktOREtKTE1FThIlCgtCSkRCT0VGRklBRxgBIAEoDjIQLlJvZ3VlUm9v";
		buffer[2] = "bVN0YXR1cxITCgtIQ01KRE1GTkVORRgEIAEoDRITCgtJT0dHSUFKQkVQUBgK";
		buffer[3] = "IAEoDRIlCgtNQ0VCSktESkhHUBgLIAEoDjIQLlJvZ3VlUm9vbVN0YXR1cxIP";
		buffer[4] = "Cgdyb29tX2lkGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[5] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { RogueRoomStatusReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IJKNDKJLMEN), IJKNDKJLMEN.Parser, new string[5] { "BJDBOEFFIAG", "HCMJDMFNENE", "IOGGIAJBEPP", "MCEBJKDJHGP", "RoomId" }, null, null, null, null)
		}));
	}
}
