using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ADHNJADIJACReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ADHNJADIJACReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFBREhOSkFESUpBQy5wcm90bxoWTG9iYnlHYW1lRXh0SW5mby5wcm90bxoR";
		buffer[1] = "TklJR0FQSUxQR0QucHJvdG8aEVBLRUlETkpPTEVMLnByb3RvInkKC0FESE5K";
		buffer[2] = "QURJSkFDEiAKCmJhc2ljX2luZm8YASABKAsyDC5OSUlHQVBJTFBHRBIhCgtO";
		buffer[3] = "RUJBQktPR0dBQRgCIAEoCzIMLlBLRUlETkpPTEVMEiUKCnN0YWdlX2luZm8Y";
		buffer[4] = "AyABKAsyES5Mb2JieUdhbWVFeHRJbmZvQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[5] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			LobbyGameExtInfoReflection.Descriptor,
			NIIGAPILPGDReflection.Descriptor,
			PKEIDNJOLELReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ADHNJADIJAC), ADHNJADIJAC.Parser, new string[3] { "BasicInfo", "NEBABKOGGAA", "StageInfo" }, null, null, null, null)
		}));
	}
}
