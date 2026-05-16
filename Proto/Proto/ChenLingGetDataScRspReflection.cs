using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingGetDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingGetDataScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChpDaGVuTGluZ0dldERhdGFTY1JzcC5wcm90bxoRRkNMRE5IT0hQSUkucHJv";
		buffer[1] = "dG8aEUZNRU1QUE5OS0pILnByb3RvIpcBChRDaGVuTGluZ0dldERhdGFTY1Jz";
		buffer[2] = "cBITCgtKSkFCUFBESUxPSxgGIAEoDRIhCgtQT0dDR01MUEVPThgHIAEoCzIM";
		buffer[3] = "LkZNRU1QUE5OS0pIEiEKC0lLS01ORE1FTExOGAwgASgLMgwuRkNMRE5IT0hQ";
		buffer[4] = "SUkSEwoLRE9BSUhGSUZGTk8YDSADKA0SDwoHcmV0Y29kZRgOIAEoDUIWqgIT";
		buffer[5] = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			FCLDNHOHPIIReflection.Descriptor,
			FMEMPPNNKJHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingGetDataScRsp), ChenLingGetDataScRsp.Parser, new string[5] { "JJABPPDILOK", "POGCGMLPEON", "IKKMNDMELLN", "DOAIHFIFFNO", "Retcode" }, null, null, null, null)
		}));
	}
}
