using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KGABJENCFDCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KGABJENCFDCReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFLR0FCSkVOQ0ZEQy5wcm90bxoRRURJS0pMQkVBRUEucHJvdG8aEUVQUEpI";
		buffer[1] = "TklIQUZMLnByb3RvGhFPQU1PSEZKS0NBQS5wcm90byLiAQoLS0dBQkpFTkNG";
		buffer[2] = "REMSIQoLTUFFRk5FQkxJSk0YASABKAsyDC5PQU1PSEZKS0NBQRITCgtGSERQ";
		buffer[3] = "RU1DQUJJRRgCIAEoDRIkCg5wZW5kaW5nX2FjdGlvbhgEIAEoCzIMLkVQUEpI";
		buffer[4] = "TklIQUZMEhMKC0VITkVFTUNLSUJLGAggASgNEhMKC01ESUxESk1QTkdIGAsg";
		buffer[5] = "ASgJEhMKC0JOT0RPTVBNQ0JFGAwgASgNEhMKC0xPSURPR0VFTk9CGA4gASgN";
		buffer[6] = "EiEKC0lNSUJGRUhQRERJGA8gASgLMgwuRURJS0pMQkVBRUFCFqoCE01hcmNo";
		buffer[7] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			EDIKJLBEAEAReflection.Descriptor,
			EPPJHNIHAFLReflection.Descriptor,
			OAMOHFJKCAAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KGABJENCFDC), KGABJENCFDC.Parser, new string[8] { "MAEFNEBLIJM", "FHDPEMCABIE", "PendingAction", "EHNEEMCKIBK", "MDILDJMPNGH", "BNODOMPMCBE", "LOIDOGEENOB", "IMIBFEHPDDI" }, null, null, null, null)
		}));
	}
}
