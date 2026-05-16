using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LGOPLIAFLCKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LGOPLIAFLCKReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFMR09QTElBRkxDSy5wcm90bxoRRk5QREpGSkZPQkUucHJvdG8aEUpBTUxI";
		buffer[1] = "T0hCSUdCLnByb3RvGhFOQkNCSkpERkJQTC5wcm90byLKAQoLTEdPUExJQUZM";
		buffer[2] = "Q0sSIQoLRE5OT0ZHSkpNQ1AYASADKAsyDC5OQkNCSkpERkJQTBITCgtGREpC";
		buffer[3] = "S01ET1BGRBgEIAMoDRITCgtKS0xQTk9GRE5BTBgFIAEoBBITCgtPS0NOSFBM";
		buffer[4] = "T01DRBgGIAEoDRITCgtMSEtEREJCSUtPQhgHIAEoBRIhCgtJUExFT09MQ0FD";
		buffer[5] = "SRgIIAEoDjIMLkZOUERKRkpGT0JFEiEKC0tHS09ITkFBQ0VOGA8gASgLMgwu";
		buffer[6] = "SkFNTEhPSEJJR0JCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			FNPDJFJFOBEReflection.Descriptor,
			JAMLHOHBIGBReflection.Descriptor,
			NBCBJJDFBPLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LGOPLIAFLCK), LGOPLIAFLCK.Parser, new string[7] { "DNNOFGJJMCP", "FDJBKMDOPFD", "JKLPNOFDNAL", "OKCNHPLOMCD", "LHKDDBBIKOB", "IPLEOOLCACI", "KGKOHNAACEN" }, null, null, null, null)
		}));
	}
}
