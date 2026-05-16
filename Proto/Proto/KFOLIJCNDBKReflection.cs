using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KFOLIJCNDBKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KFOLIJCNDBKReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFLRk9MSUpDTkRCSy5wcm90bxoRR0dCRENPSUNHSkcucHJvdG8aEUhLTkRJ";
		buffer[1] = "TERPSkZQLnByb3RvImgKC0tGT0xJSkNOREJLEhMKC0ZDSElLQUFGQ1BMGAEg";
		buffer[2] = "ASgNEiEKC0hPQk5IQkNKSURNGAIgAygLMgwuR0dCRENPSUNHSkcSIQoLSEhC";
		buffer[3] = "SE9CT0pPQ0YYAyADKAsyDC5IS05ESUxET0pGUEIWqgITTWFyY2g3dGhIb25l";
		buffer[4] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GGBDCOICGJGReflection.Descriptor,
			HKNDILDOJFPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KFOLIJCNDBK), KFOLIJCNDBK.Parser, new string[3] { "FCHIKAAFCPL", "HOBNHBCJIDM", "HHBHOBOJOCF" }, null, null, null, null)
		}));
	}
}
