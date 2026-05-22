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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "CiFQdW5rTG9yZE1vbnN0ZXJJbmZvU2NOb3RpZnkucHJvdG8aEUlOUEJHTkpN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "TktKLnByb3RvGhFQSE9DRUNKT0JISC5wcm90bxoeUHVua0xvcmRNb25zdGVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "QmFzaWNJbmZvLnByb3RvIqIBChtQdW5rTG9yZE1vbnN0ZXJJbmZvU2NOb3Rp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "ZnkSHAoGcmVhc29uGAcgASgOMgwuSU5QQkdOSk1OS0oSLQoKYmFzaWNfaW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "bxgIIAEoCzIZLlB1bmtMb3JkTW9uc3RlckJhc2ljSW5mbxIhCgtGSFBPSUxJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "TUtJSRgLIAEoCzIMLlBIT0NFQ0pPQkhIEhMKC0dEQklJTU5KTEJBGAwgAygN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[3]
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
