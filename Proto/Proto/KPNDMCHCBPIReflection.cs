using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KPNDMCHCBPIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KPNDMCHCBPIReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFLUE5ETUNIQ0JQSS5wcm90bxoRR0tERUtKS09JSk4ucHJvdG8iwwEKC0tQ";
		buffer[1] = "TkRNQ0hDQlBJEiEKC0NJTk1QSExKREVNGAEgAygLMgwuR0tERUtKS09JSk4S";
		buffer[2] = "EwoLUE9JTkVLSUVGUEUYBCABKA0SEwoLQVBEQUJOR0RNUE0YBiABKA0SEwoL";
		buffer[3] = "RFBCRUVOQlBESVAYCSABKA0SEwoLQkpBREhDT0ZMR0kYCyABKAgSEwoLT0FJ";
		buffer[4] = "QkNDTkFBSEYYDCABKA0SEwoLRU1GSExCQk9DRksYDSABKA0SEwoLRE9OT0pB";
		buffer[5] = "RU1KREIYDyABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GKDEKJKOIJNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KPNDMCHCBPI), KPNDMCHCBPI.Parser, new string[8] { "CINMPHLJDEM", "POINEKIEFPE", "APDABNGDMPM", "DPBEENBPDIP", "BJADHCOFLGI", "OAIBCCNAAHF", "EMFHLBBOCFK", "DONOJAEMJDB" }, null, null, null, null)
		}));
	}
}
