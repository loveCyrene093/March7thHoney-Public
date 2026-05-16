using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MIGEAHDEBOEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MIGEAHDEBOEReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFNSUdFQUhERUJPRS5wcm90bxoZR3JpZEZpZ2h0VGFsZW50SW5mby5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "bxoRTkhES0xNSU1MS0MucHJvdG8iWwoLTUlHRUFIREVCT0USKQoLT0pMQU9E";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "SUFMTEUYASABKAsyFC5HcmlkRmlnaHRUYWxlbnRJbmZvEiEKC0lNTk9KSURK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Qk5HGAggASgLMgwuTkhES0xNSU1MS0NCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			GridFightTalentInfoReflection.Descriptor,
			NHDKLMIMLKCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MIGEAHDEBOE), MIGEAHDEBOE.Parser, new string[2] { "OJLAODIALLE", "IMNOJIDJBNG" }, null, null, null, null)
		}));
	}
}
