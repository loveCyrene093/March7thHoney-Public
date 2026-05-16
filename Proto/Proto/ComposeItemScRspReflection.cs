using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ComposeItemScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ComposeItemScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChZDb21wb3NlSXRlbVNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90byJrChBD";
		buffer[1] = "b21wb3NlSXRlbVNjUnNwEg0KBWNvdW50GAEgASgNEg8KB3JldGNvZGUYBCAB";
		buffer[2] = "KA0SIwoQcmV0dXJuX2l0ZW1fbGlzdBgFIAEoCzIJLkl0ZW1MaXN0EhIKCmNv";
		buffer[3] = "bXBvc2VfaWQYDSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ComposeItemScRsp), ComposeItemScRsp.Parser, new string[4] { "Count", "Retcode", "ReturnItemList", "ComposeId" }, null, null, null, null)
		}));
	}
}
