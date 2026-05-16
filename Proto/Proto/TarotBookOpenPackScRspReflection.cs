using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TarotBookOpenPackScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TarotBookOpenPackScRspReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChxUYXJvdEJvb2tPcGVuUGFja1NjUnNwLnByb3RvIs4CChZUYXJvdEJvb2tP";
		buffer[1] = "cGVuUGFja1NjUnNwEg8KB3JldGNvZGUYAiABKA0SEwoLZW5lcmd5X2luZm8Y";
		buffer[2] = "BSABKA0SPQoLRUtKRkRKQ0hLTE0YBiADKAsyKC5UYXJvdEJvb2tPcGVuUGFj";
		buffer[3] = "a1NjUnNwLkVLSkZESkNIS0xNRW50cnkSEwoLRkJPRk1PUENNQ0QYCCABKA0S";
		buffer[4] = "PQoLRkNJTkhNTk5PR0sYDSADKAsyKC5UYXJvdEJvb2tPcGVuUGFja1NjUnNw";
		buffer[5] = "LkZDSU5ITU5OT0dLRW50cnkSEwoLSkdLQ0JHQkdNT0QYDiABKA0aMgoQRUtK";
		buffer[6] = "RkRKQ0hLTE1FbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKA06AjgB";
		buffer[7] = "GjIKEEZDSU5ITU5OT0dLRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIg";
		buffer[8] = "ASgNOgI4AUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TarotBookOpenPackScRsp), TarotBookOpenPackScRsp.Parser, new string[6] { "Retcode", "EnergyInfo", "EKJFDJCHKLM", "FBOFMOPCMCD", "FCINHMNNOGK", "JGKCBGBGMOD" }, null, null, null, new GeneratedClrTypeInfo[2])
		}));
	}
}
