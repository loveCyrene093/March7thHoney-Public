using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ScenePlaneEventScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ScenePlaneEventScNotifyReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "Ch1TY2VuZVBsYW5lRXZlbnRTY05vdGlmeS5wcm90bxoOSXRlbUxpc3QucHJv";
		buffer[1] = "dG8imwEKF1NjZW5lUGxhbmVFdmVudFNjTm90aWZ5EiAKDWdldF9pdGVtX2xp";
		buffer[2] = "c3QYAiABKAsyCS5JdGVtTGlzdBIeCgtFQU9NQkpKSE1NQRgFIAEoCzIJLkl0";
		buffer[3] = "ZW1MaXN0Eh4KC0NJRFBPTk1PTUlPGAcgASgLMgkuSXRlbUxpc3QSHgoLS0pK";
		buffer[4] = "S0hLRkNQTUEYDSABKAsyCS5JdGVtTGlzdEIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[5] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ScenePlaneEventScNotify), ScenePlaneEventScNotify.Parser, new string[4] { "GetItemList", "EAOMBJJHMMA", "CIDPONMOMIO", "KJJKHKFCPMA" }, null, null, null, null)
		}));
	}
}
