using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IMDPAIOOHMFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IMDPAIOOHMFReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFJTURQQUlPT0hNRi5wcm90bxoRQUFIQkVDSUNPRU4ucHJvdG8ioAEKC0lN";
		buffer[1] = "RFBBSU9PSE1GEiEKC0xDUElPRENMTkhMGAIgAygLMgwuQUFIQkVDSUNPRU4S";
		buffer[2] = "EwoLQUZDQU9CRUJPTUgYBCABKA0SIQoLTEpIRE9GQkZOSkgYCiABKAsyDC5B";
		buffer[3] = "QUhCRUNJQ09FThITCgtGUExEQUtOQUxLTBgMIAEoDRIhCgtQR0lIR05PTElP";
		buffer[4] = "SRgNIAMoCzIMLkFBSEJFQ0lDT0VOQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[5] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { AAHBECICOENReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IMDPAIOOHMF), IMDPAIOOHMF.Parser, new string[5] { "LCPIODCLNHL", "AFCAOBEBOMH", "LJHDOFBFNJH", "FPLDAKNALKL", "PGIHGNOLIOI" }, null, null, null, null)
		}));
	}
}
