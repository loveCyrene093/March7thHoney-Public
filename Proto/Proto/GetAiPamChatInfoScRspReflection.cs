using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAiPamChatInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAiPamChatInfoScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChtHZXRBaVBhbUNoYXRJbmZvU2NSc3AucHJvdG8aEU1ET0pDQ01MS0hQLnBy";
		buffer[1] = "b3RvIrQBChVHZXRBaVBhbUNoYXRJbmZvU2NSc3ASDwoHcmV0Y29kZRgBIAEo";
		buffer[2] = "DRITCgtBSVBCRkVPRk5ETxgDIAEoCRITCgtIRUZMSENIRERNRxgGIAEoCBIT";
		buffer[3] = "CgtNTkRBSUFHUE9FSRgJIAEoCBIhCgtGSUxGTk1LQ0NOThgLIAMoCzIMLk1E";
		buffer[4] = "T0pDQ01MS0hQEhMKC0VDSUFHTEpOUE1NGAwgASgNEhMKC0VLQk1JT0NPTElD";
		buffer[5] = "GA0gASgIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MDOJCCMLKHPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAiPamChatInfoScRsp), GetAiPamChatInfoScRsp.Parser, new string[7] { "Retcode", "AIPBFEOFNDO", "HEFLHCHDDMG", "MNDAIAGPOEI", "FILFNMKCCNN", "ECIAGLJNPMM", "EKBMIOCOLIC" }, null, null, null, null)
		}));
	}
}
