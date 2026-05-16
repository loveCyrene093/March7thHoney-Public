using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IBLHPOBOOPEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IBLHPOBOOPEReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFJQkxIUE9CT09QRS5wcm90byKeAQoLSUJMSFBPQk9PUEUSDgoGaXNfd2lu";
		buffer[1] = "GAggASgIEhcKD2JhdHRsZV9ldmVudF9pZBgJIAEoDRIyCgtPSE9HREJQS0xG";
		buffer[2] = "TRgPIAMoCzIdLklCTEhQT0JPT1BFLk9IT0dEQlBLTEZNRW50cnkaMgoQT0hP";
		buffer[3] = "R0RCUEtMRk1FbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKA06AjgB";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IBLHPOBOOPE), IBLHPOBOOPE.Parser, new string[3] { "IsWin", "BattleEventId", "OHOGDBPKLFM" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
