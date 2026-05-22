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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChlHZXRIaXBwbGVuRGF0YVNjUnNwLnByb3RvGhFKRkFDT05JQkZITS5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "bxoRTElPTFBJSk9NQkkucHJvdG8aEU9PTEhORk5LT0hOLnByb3RvIrkBChNH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "ZXRIaXBwbGVuRGF0YVNjUnNwEiEKC0FDSkhHTEdIRUFIGAEgASgLMgwuT09M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "SE5GTktPSE4SIQoLQ0VBSk5MTElCRlAYBCABKAsyDC5MSU9MUElKT01CSRIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "CgtJUE9FSUdBRExKThgHIAEoDRIPCgdyZXRjb2RlGAkgASgNEhMKC01QUEpM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "RklETUxCGAogASgIEiEKC0lCSExLR0lFUExHGA4gASgLMgwuSkZBQ09OSUJG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "SE1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[3]
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
