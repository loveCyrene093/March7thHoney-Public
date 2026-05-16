using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateWolfBroShootingDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateWolfBroShootingDataCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiRVcGRhdGVXb2xmQnJvU2hvb3RpbmdEYXRhQ3NSZXEucHJvdG8aEURFT01O";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RU9NUEZFLnByb3RvIngKHlVwZGF0ZVdvbGZCcm9TaG9vdGluZ0RhdGFDc1Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "cRIhCgtESUZMS0hNS0hCRxgDIAEoCzIMLkRFT01ORU9NUEZFEhMKC0VDRUFD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "QkFHQUtEGAcgASgNEhAKCGdyb3VwX2lkGAogASgNEgwKBHV1aWQYDSABKARC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { DEOMNEOMPFEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateWolfBroShootingDataCsReq), UpdateWolfBroShootingDataCsReq.Parser, new string[4] { "DIFLKHMKHBG", "ECEACBAGAKD", "GroupId", "Uuid" }, null, null, null, null)
		}));
	}
}
