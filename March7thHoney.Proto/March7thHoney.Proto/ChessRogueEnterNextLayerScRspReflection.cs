using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueEnterNextLayerScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueEnterNextLayerScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "CiNDaGVzc1JvZ3VlRW50ZXJOZXh0TGF5ZXJTY1JzcC5wcm90bxoRRUJHSktQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "Sk5QQkwucHJvdG8aEUVKQ0NISEFBR05ILnByb3RvGhFJTEVKR0VEQkVLRi5w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "cm90byKcAQodQ2hlc3NSb2d1ZUVudGVyTmV4dExheWVyU2NSc3ASIAoKc3Rh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "Z2VfaW5mbxgBIAEoCzIMLkVKQ0NISEFBR05IEiUKD3JvZ3VlX2dhbWVfaW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "bxgJIAEoCzIMLklMRUpHRURCRUtGEg8KB3JldGNvZGUYCiABKA0SIQoLRU9I";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "T0pFQ0tPREoYDCABKAsyDC5FQkdKS1BKTlBCTEIWqgITTWFyY2g3dGhIb25l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[3]
		{
			EBGJKPJNPBLReflection.Descriptor,
			EJCCHHAAGNHReflection.Descriptor,
			ILEJGEDBEKFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueEnterNextLayerScRsp), ChessRogueEnterNextLayerScRsp.Parser, new string[4] { "StageInfo", "RogueGameInfo", "Retcode", "EOHOJECKODJ" }, null, null, null, null)
		}));
	}
}
