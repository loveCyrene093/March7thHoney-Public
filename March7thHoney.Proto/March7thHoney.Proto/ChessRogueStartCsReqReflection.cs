using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueStartCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueStartCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChpDaGVzc1JvZ3VlU3RhcnRDc1JlcS5wcm90byK6AQoUQ2hlc3NSb2d1ZVN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "YXJ0Q3NSZXESEwoLTEdIT09LTU5NQ0wYAiABKA0SJQoddW5maW5pc2hlZF9z";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "dG9yeV9saW5lX2lkX2xpc3QYBCADKA0SCgoCaWQYBSABKA0SGwoTYmFzZV9h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "dmF0YXJfaWRfbGlzdBgIIAMoDRITCgtBTUhERk1GSUxCRBgJIAEoDRITCgtL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "T0xCTEtFRE9HQxgMIAMoDRITCgtPSkFITU5BTklOTBgOIAMoDUIWqgITTWFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueStartCsReq), ChessRogueStartCsReq.Parser, new string[7] { "LGHOOKMNMCL", "UnfinishedStoryLineIdList", "Id", "BaseAvatarIdList", "AMHDFMFILBD", "KOLBLKEDOGC", "OJAHMNANINL" }, null, null, null, null)
		}));
	}
}
