using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OLCPICDAOKIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OLCPICDAOKIReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChFPTENQSUNEQU9LSS5wcm90bxoRS0dDTE5NSEFBTU0ucHJvdG8iqQIKC09M";
		buffer[1] = "Q1BJQ0RBT0tJEg4KBmF0dGFjaxgBIAEoBRIPCgdidWZmX2lkGAIgASgNEhMK";
		buffer[2] = "C05CRUtDRUlISkFDGAMgASgIEhMKC0tGQUVNSUJCUEhBGAQgASgNEiEKC09B";
		buffer[3] = "SU1BREVFRVBFGAUgASgLMgwuS0dDTE5NSEFBTU0SEwoLTkZPRklQR0dKR1AY";
		buffer[4] = "ByABKAgSCgoCaHAYCCABKAUSDgoGbWF4X2hwGAkgASgFEiEKC01CQUZJT0NM";
		buffer[5] = "TUFJGAogASgLMgwuS0dDTE5NSEFBTU0SEwoLQUJBRk9QQkhJTEsYCyABKAgS";
		buffer[6] = "DQoFbGV2ZWwYDCABKA0SCgoCaWQYDSABKA0SEwoLT0xLQkhKTk9JQUQYDiAB";
		buffer[7] = "KAgSEwoLS0hOTkVMUEdLSU0YDyABKAJCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[8] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { KGCLNMHAAMMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OLCPICDAOKI), OLCPICDAOKI.Parser, new string[14]
			{
				"Attack", "BuffId", "NBEKCEIHJAC", "KFAEMIBBPHA", "OAIMADEEEPE", "NFOFIPGGJGP", "Hp", "MaxHp", "MBAFIOCLMAI", "ABAFOPBHILK",
				"Level", "Id", "OLKBHJNOIAD", "KHNNELPGKIM"
			}, null, null, null, null)
		}));
	}
}
