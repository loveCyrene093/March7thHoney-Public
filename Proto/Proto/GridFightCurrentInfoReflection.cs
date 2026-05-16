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
		buffer[0] = "ChpHcmlkRmlnaHRDdXJyZW50SW5mby5wcm90bxoRRkNCRUhHSkJKQ04ucHJv";
		buffer[1] = "dG8aF0dyaWRGaWdodEdhbWVEYXRhLnByb3RvGhdHcmlkRmlnaHRHYW1lSW5m";
		buffer[2] = "by5wcm90bxocR3JpZEZpZ2h0UGVuZGluZ0FjdGlvbi5wcm90byKeAgoUR3Jp";
		buffer[3] = "ZEZpZ2h0Q3VycmVudEluZm8SLwoOcGVuZGluZ19hY3Rpb24YAiABKAsyFy5H";
		buffer[4] = "cmlkRmlnaHRQZW5kaW5nQWN0aW9uEhEKCXVuaXF1ZV9pZBgDIAEoDRIzChdy";
		buffer[5] = "b2d1ZV9jdXJyZW50X2dhbWVfaW5mbxgIIAMoCzISLkdyaWRGaWdodEdhbWVJ";
		buffer[6] = "bmZvEhMKC2lzX292ZXJsb2NrGAkgASgIEhMKC2RpdmlzaW9uX2lkGAsgASgN";
		buffer[7] = "EjAKFGdyaWRfZmlnaHRfZ2FtZV9kYXRhGAwgASgLMhIuR3JpZEZpZ2h0R2Ft";
		buffer[8] = "ZURhdGESDgoGc2Vhc29uGA0gASgNEiEKC0JDSFBBT0NPSElMGA4gASgLMgwu";
		buffer[9] = "RkNCRUhHSkJKQ05CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
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
