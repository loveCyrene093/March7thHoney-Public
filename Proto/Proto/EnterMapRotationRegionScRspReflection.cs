using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterMapRotationRegionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterMapRotationRegionScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "CiFFbnRlck1hcFJvdGF0aW9uUmVnaW9uU2NSc3AucHJvdG8aEE1vdGlvbklu";
		buffer[1] = "Zm8ucHJvdG8aF1JvdGF0ZXJFbmVyZ3lJbmZvLnByb3RvIroBChtFbnRlck1h";
		buffer[2] = "cFJvdGF0aW9uUmVnaW9uU2NSc3ASGgoSY2xpZW50X3Bvc192ZXJzaW9uGAYg";
		buffer[3] = "ASgNEg8KB3JldGNvZGUYByABKA0SJwoLZW5lcmd5X2luZm8YCCABKAsyEi5S";
		buffer[4] = "b3RhdGVyRW5lcmd5SW5mbxITCgtKSERMTkJQTkVLRxgKIAEoDRIbCgZtb3Rp";
		buffer[5] = "b24YDSABKAsyCy5Nb3Rpb25JbmZvEhMKC0JDUENCSE1GSUlOGA4gASgNQhaq";
		buffer[6] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			MotionInfoReflection.Descriptor,
			RotaterEnergyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterMapRotationRegionScRsp), EnterMapRotationRegionScRsp.Parser, new string[6] { "ClientPosVersion", "Retcode", "EnergyInfo", "JHDLNBPNEKG", "Motion", "BCPCBHMFIIN" }, null, null, null, null)
		}));
	}
}
