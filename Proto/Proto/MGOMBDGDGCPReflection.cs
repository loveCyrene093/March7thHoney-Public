using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MGOMBDGDGCPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MGOMBDGDGCPReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFNR09NQkRHREdDUC5wcm90bxoVQmF0dGxlRW5kU3RhdHVzLnByb3RvIr8B";
		buffer[1] = "CgtNR09NQkRHREdDUBIQCghzY29yZV9pZBgBIAEoDRIUCgx0b3RhbF9kYW1h";
		buffer[2] = "Z2UYBCABKA0SEwoLUERCTkdOQUJESkkYBSABKA0SEwoLQUNLS0FDQ01NSU0Y";
		buffer[3] = "ByABKA0SJAoKZW5kX3N0YXR1cxgKIAEoDjIQLkJhdHRsZUVuZFN0YXR1cxIT";
		buffer[4] = "CgtBR0pHTEdCQ01HRhgLIAEoDRIQCghzdGFnZV9pZBgMIAEoDRIRCgltYXhf";
		buffer[5] = "c2NvcmUYDSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BattleEndStatusReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MGOMBDGDGCP), MGOMBDGDGCP.Parser, new string[8] { "ScoreId", "TotalDamage", "PDBNGNABDJI", "ACKKACCMMIM", "EndStatus", "AGJGLGBCMGF", "StageId", "MaxScore" }, null, null, null, null)
		}));
	}
}
