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
		buffer[0] = "CiRVcGRhdGVXb2xmQnJvU2hvb3RpbmdEYXRhQ3NSZXEucHJvdG8aEURFT01O";
		buffer[1] = "RU9NUEZFLnByb3RvIngKHlVwZGF0ZVdvbGZCcm9TaG9vdGluZ0RhdGFDc1Jl";
		buffer[2] = "cRIhCgtESUZMS0hNS0hCRxgDIAEoCzIMLkRFT01ORU9NUEZFEhMKC0VDRUFD";
		buffer[3] = "QkFHQUtEGAcgASgNEhAKCGdyb3VwX2lkGAogASgNEgwKBHV1aWQYDSABKARC";
		buffer[4] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { DEOMNEOMPFEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateWolfBroShootingDataCsReq), UpdateWolfBroShootingDataCsReq.Parser, new string[4] { "DIFLKHMKHBG", "ECEACBAGAKD", "GroupId", "Uuid" }, null, null, null, null)
		}));
	}
}
