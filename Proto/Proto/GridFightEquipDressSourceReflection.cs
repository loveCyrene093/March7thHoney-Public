using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightEquipDressSourceReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightEquipDressSourceReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch9HcmlkRmlnaHRFcXVpcERyZXNzU291cmNlLnByb3RvKnIKGUdyaWRGaWdo";
		buffer[1] = "dEVxdWlwRHJlc3NTb3VyY2USGwoXQkxKSkRKT0RBSEhfRkxMSVBLQ01GSEgQ";
		buffer[2] = "ABIbChdCTEpKREpPREFISF9HTkZOUEhIQU5GQRABEhsKF0JMSkpESk9EQUhI";
		buffer[3] = "X0dNTEpEQUZPRUlDEAJCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GridFightEquipDressSource) }, null, null));
	}
}
