using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightCurrentInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightCurrentInfoReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 0) = "ChpHcmlkRmlnaHRDdXJyZW50SW5mby5wcm90bxoRRkNCRUhHSkJKQ04ucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 1) = "dG8aF0dyaWRGaWdodEdhbWVEYXRhLnByb3RvGhdHcmlkRmlnaHRHYW1lSW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 2) = "by5wcm90bxocR3JpZEZpZ2h0UGVuZGluZ0FjdGlvbi5wcm90byKeAgoUR3Jp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 3) = "ZEZpZ2h0Q3VycmVudEluZm8SLwoOcGVuZGluZ19hY3Rpb24YAiABKAsyFy5H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 4) = "cmlkRmlnaHRQZW5kaW5nQWN0aW9uEhEKCXVuaXF1ZV9pZBgDIAEoDRIzChdy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 5) = "b2d1ZV9jdXJyZW50X2dhbWVfaW5mbxgIIAMoCzISLkdyaWRGaWdodEdhbWVJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 6) = "bmZvEhMKC2lzX292ZXJsb2NrGAkgASgIEhMKC2RpdmlzaW9uX2lkGAsgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 7) = "EjAKFGdyaWRfZmlnaHRfZ2FtZV9kYXRhGAwgASgLMhIuR3JpZEZpZ2h0R2Ft";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 8) = "ZURhdGESDgoGc2Vhc29uGA0gASgNEiEKC0JDSFBBT0NPSElMGA4gASgLMgwu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 9) = "RkNCRUhHSkJKQ05CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray10<string>, string>(in buffer, 10))), new FileDescriptor[4]
		{
			FCBEHGJBJCNReflection.Descriptor,
			GridFightGameDataReflection.Descriptor,
			GridFightGameInfoReflection.Descriptor,
			GridFightPendingActionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightCurrentInfo), GridFightCurrentInfo.Parser, new string[8] { "PendingAction", "UniqueId", "RogueCurrentGameInfo", "IsOverlock", "DivisionId", "GridFightGameData", "Season", "BCHPAOCOHIL" }, null, null, null, null)
		}));
	}
}
