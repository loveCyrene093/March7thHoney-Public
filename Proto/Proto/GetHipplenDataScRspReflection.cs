using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetHipplenDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetHipplenDataScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChlHZXRIaXBwbGVuRGF0YVNjUnNwLnByb3RvGhFKRkFDT05JQkZITS5wcm90";
		buffer[1] = "bxoRTElPTFBJSk9NQkkucHJvdG8aEU9PTEhORk5LT0hOLnByb3RvIrkBChNH";
		buffer[2] = "ZXRIaXBwbGVuRGF0YVNjUnNwEiEKC0FDSkhHTEdIRUFIGAEgASgLMgwuT09M";
		buffer[3] = "SE5GTktPSE4SIQoLQ0VBSk5MTElCRlAYBCABKAsyDC5MSU9MUElKT01CSRIT";
		buffer[4] = "CgtJUE9FSUdBRExKThgHIAEoDRIPCgdyZXRjb2RlGAkgASgNEhMKC01QUEpM";
		buffer[5] = "RklETUxCGAogASgIEiEKC0lCSExLR0lFUExHGA4gASgLMgwuSkZBQ09OSUJG";
		buffer[6] = "SE1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			JFACONIBFHMReflection.Descriptor,
			LIOLPIJOMBIReflection.Descriptor,
			OOLHNFNKOHNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetHipplenDataScRsp), GetHipplenDataScRsp.Parser, new string[6] { "ACJHGLGHEAH", "CEAJNLLIBFP", "IPOEIGADLJN", "Retcode", "MPPJLFIDMLB", "IBHLKGIEPLG" }, null, null, null, null)
		}));
	}
}
