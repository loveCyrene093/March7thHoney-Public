using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GGBDCOICGJGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GGBDCOICGJGReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFHR0JEQ09JQ0dKRy5wcm90bxoRSEhJUEtJTk5DQVAucHJvdG8iegoLR0dC";
		buffer[1] = "RENPSUNHSkcSDAoEd2F2ZRgBIAEoDRIQCghzY29yZV9pZBgCIAEoDRITCgtP";
		buffer[2] = "SVBBQU1HSUlFRxgDIAEoDRIhCgtCSEZDUEpBS0lCRxgEIAMoCzIMLkhISVBL";
		buffer[3] = "SU5OQ0FQEhMKC0pIRktBTktHTEpOGAUgASgCQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[4] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { HHIPKINNCAPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GGBDCOICGJG), GGBDCOICGJG.Parser, new string[5] { "Wave", "ScoreId", "OIPAAMGIIEG", "BHFCPJAKIBG", "JHFKANKGLJN" }, null, null, null, null)
		}));
	}
}
