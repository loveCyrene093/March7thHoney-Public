using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetPlayerInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetPlayerInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChhTZXRQbGF5ZXJJbmZvU2NSc3AucHJvdG8aGU11bHRpUGF0aEF2YXRhclR5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "cGUucHJvdG8ieQoSU2V0UGxheWVySW5mb1NjUnNwEhEKCWlzX21vZGlmeRgB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "IAEoCBIQCghzZXRfdGltZRgFIAEoAxItCg9jdXJfYXZhdGFyX3BhdGgYBiAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "KA4yFC5NdWx0aVBhdGhBdmF0YXJUeXBlEg8KB3JldGNvZGUYByABKA1CFqoC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { MultiPathAvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetPlayerInfoScRsp), SetPlayerInfoScRsp.Parser, new string[4] { "IsModify", "SetTime", "CurAvatarPath", "Retcode" }, null, null, null, null)
		}));
	}
}
