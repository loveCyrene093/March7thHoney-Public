using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesAvatarLevelUpScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesAvatarLevelUpScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiFQbGFuZXRGZXNBdmF0YXJMZXZlbFVwU2NSc3AucHJvdG8aEUhMTENEQkxD";
		buffer[1] = "SVBLLnByb3RvIokBChtQbGFuZXRGZXNBdmF0YXJMZXZlbFVwU2NSc3ASEwoL";
		buffer[2] = "SUhMTE1MTE5JRk4YASABKA0SHAoGcmV3YXJkGAMgASgLMgwuSExMQ0RCTENJ";
		buffer[3] = "UEsSDwoHcmV0Y29kZRgFIAEoDRITCgtPREFESklMT0VLTxgJIAEoDRIRCglh";
		buffer[4] = "dmF0YXJfaWQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[5] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { HLLCDBLCIPKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesAvatarLevelUpScRsp), PlanetFesAvatarLevelUpScRsp.Parser, new string[5] { "IHLLMLLNIFN", "Reward", "Retcode", "ODADJILOEKO", "AvatarId" }, null, null, null, null)
		}));
	}
}
