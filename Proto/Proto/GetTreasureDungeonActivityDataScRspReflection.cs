using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetTreasureDungeonActivityDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetTreasureDungeonActivityDataScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CilHZXRUcmVhc3VyZUR1bmdlb25BY3Rpdml0eURhdGFTY1JzcC5wcm90bxoR";
		buffer[1] = "RE9BQ0VLRUVLTEoucHJvdG8iWQojR2V0VHJlYXN1cmVEdW5nZW9uQWN0aXZp";
		buffer[2] = "dHlEYXRhU2NSc3ASDwoHcmV0Y29kZRgDIAEoDRIhCgtCUENLRk9KS0NCSxgM";
		buffer[3] = "IAMoCzIMLkRPQUNFS0VFS0xKQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[4] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { DOACEKEEKLJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetTreasureDungeonActivityDataScRsp), GetTreasureDungeonActivityDataScRsp.Parser, new string[2] { "Retcode", "BPCKFOJKCBK" }, null, null, null, null)
		}));
	}
}
