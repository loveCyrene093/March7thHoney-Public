using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CAEABHJNLMIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CAEABHJNLMIReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFDQUVBQkhKTkxNSS5wcm90byK0AQoLQ0FFQUJISk5MTUkSEwoLREFDT0tG";
		buffer[1] = "Q0JNQkkYASABKA0SMgoLQkxKRUJJSkVNQ0gYByADKAsyHS5DQUVBQkhKTkxN";
		buffer[2] = "SS5CTEpFQklKRU1DSEVudHJ5EhMKC01FQUpBRUJEQU9JGAogASgNEhMKC0RP";
		buffer[3] = "TUdMSElLSkVEGAsgASgNGjIKEEJMSkVCSUpFTUNIRW50cnkSCwoDa2V5GAEg";
		buffer[4] = "ASgNEg0KBXZhbHVlGAIgASgNOgI4AUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[5] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CAEABHJNLMI), CAEABHJNLMI.Parser, new string[4] { "DACOKFCBMBI", "BLJEBIJEMCH", "MEAJAEBDAOI", "DOMGLHIKJED" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
