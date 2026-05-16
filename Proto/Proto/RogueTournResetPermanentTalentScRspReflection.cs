using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournResetPermanentTalentScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournResetPermanentTalentScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CilSb2d1ZVRvdXJuUmVzZXRQZXJtYW5lbnRUYWxlbnRTY1JzcC5wcm90bxoR";
		buffer[1] = "RUNKTkFJT0xLSkQucHJvdG8iWQojUm9ndWVUb3VyblJlc2V0UGVybWFuZW50";
		buffer[2] = "VGFsZW50U2NSc3ASDwoHcmV0Y29kZRgFIAEoDRIhCgtGTUtFRkdKTUNIQRgG";
		buffer[3] = "IAEoCzIMLkVDSk5BSU9MS0pEQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[4] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ECJNAIOLKJDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournResetPermanentTalentScRsp), RogueTournResetPermanentTalentScRsp.Parser, new string[2] { "Retcode", "FMKEFGJMCHA" }, null, null, null, null)
		}));
	}
}
