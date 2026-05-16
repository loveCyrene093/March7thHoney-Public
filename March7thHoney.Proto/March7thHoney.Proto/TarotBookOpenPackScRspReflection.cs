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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "ChxUYXJvdEJvb2tPcGVuUGFja1NjUnNwLnByb3RvIs4CChZUYXJvdEJvb2tP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "cGVuUGFja1NjUnNwEg8KB3JldGNvZGUYAiABKA0SEwoLZW5lcmd5X2luZm8Y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "BSABKA0SPQoLRUtKRkRKQ0hLTE0YBiADKAsyKC5UYXJvdEJvb2tPcGVuUGFj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "a1NjUnNwLkVLSkZESkNIS0xNRW50cnkSEwoLRkJPRk1PUENNQ0QYCCABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "PQoLRkNJTkhNTk5PR0sYDSADKAsyKC5UYXJvdEJvb2tPcGVuUGFja1NjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "LkZDSU5ITU5OT0dLRW50cnkSEwoLSkdLQ0JHQkdNT0QYDiABKA0aMgoQRUtK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "RkRKQ0hLTE1FbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKA06AjgB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "GjIKEEZDSU5ITU5OT0dLRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "ASgNOgI4AUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TarotBookOpenPackScRsp), TarotBookOpenPackScRsp.Parser, new string[6] { "Retcode", "EnergyInfo", "EKJFDJCHKLM", "FBOFMOPCMCD", "FCINHMNNOGK", "JGKCBGBGMOD" }, null, null, null, new GeneratedClrTypeInfo[2])
		}));
	}
}
