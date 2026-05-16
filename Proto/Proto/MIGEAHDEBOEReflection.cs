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
		buffer[0] = "ChFNSUdFQUhERUJPRS5wcm90bxoZR3JpZEZpZ2h0VGFsZW50SW5mby5wcm90";
		buffer[1] = "bxoRTkhES0xNSU1MS0MucHJvdG8iWwoLTUlHRUFIREVCT0USKQoLT0pMQU9E";
		buffer[2] = "SUFMTEUYASABKAsyFC5HcmlkRmlnaHRUYWxlbnRJbmZvEiEKC0lNTk9KSURK";
		buffer[3] = "Qk5HGAggASgLMgwuTkhES0xNSU1MS0NCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[4] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GridFightTalentInfoReflection.Descriptor,
			NHDKLMIMLKCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MIGEAHDEBOE), MIGEAHDEBOE.Parser, new string[2] { "OJLAODIALLE", "IMNOJIDJBNG" }, null, null, null, null)
		}));
	}
}
