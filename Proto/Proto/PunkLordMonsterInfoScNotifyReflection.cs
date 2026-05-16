using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PunkLordMonsterInfoScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PunkLordMonsterInfoScNotifyReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "CiFQdW5rTG9yZE1vbnN0ZXJJbmZvU2NOb3RpZnkucHJvdG8aEUlOUEJHTkpN";
		buffer[1] = "TktKLnByb3RvGhFQSE9DRUNKT0JISC5wcm90bxoeUHVua0xvcmRNb25zdGVy";
		buffer[2] = "QmFzaWNJbmZvLnByb3RvIqIBChtQdW5rTG9yZE1vbnN0ZXJJbmZvU2NOb3Rp";
		buffer[3] = "ZnkSHAoGcmVhc29uGAcgASgOMgwuSU5QQkdOSk1OS0oSLQoKYmFzaWNfaW5m";
		buffer[4] = "bxgIIAEoCzIZLlB1bmtMb3JkTW9uc3RlckJhc2ljSW5mbxIhCgtGSFBPSUxJ";
		buffer[5] = "TUtJSRgLIAEoCzIMLlBIT0NFQ0pPQkhIEhMKC0dEQklJTU5KTEJBGAwgAygN";
		buffer[6] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			INPBGNJMNKJReflection.Descriptor,
			PHOCECJOBHHReflection.Descriptor,
			PunkLordMonsterBasicInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PunkLordMonsterInfoScNotify), PunkLordMonsterInfoScNotify.Parser, new string[4] { "Reason", "BasicInfo", "FHPOILIMKII", "GDBIIMNJLBA" }, null, null, null, null)
		}));
	}
}
