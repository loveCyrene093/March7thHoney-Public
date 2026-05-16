using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HBCMBPKGBJKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HBCMBPKGBJKReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFIQkNNQlBLR0JKSy5wcm90bxoRR0tERUtKS09JSk4ucHJvdG8aDkl0ZW1M";
		buffer[1] = "aXN0LnByb3RvIrcBCgtIQkNNQlBLR0JKSxIhCgtNRUtMSUJBUEdPThgCIAMo";
		buffer[2] = "CzIMLkdLREVLSktPSUpOEiEKC0hFT0VLQVBCTklFGAQgAygLMgwuR0tERUtK";
		buffer[3] = "S09JSk4SDwoHcmV0Y29kZRgIIAEoDRITCgtGSUlKQ0ZKSkxPTxgLIAEoCBIh";
		buffer[4] = "CgtGTVBOTkhEUEdLRBgMIAMoCzIMLkdLREVLSktPSUpOEhkKBnJld2FyZBgO";
		buffer[5] = "IAEoCzIJLkl0ZW1MaXN0QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[6] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GKDEKJKOIJNReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HBCMBPKGBJK), HBCMBPKGBJK.Parser, new string[6] { "MEKLIBAPGON", "HEOEKAPBNIE", "Retcode", "FIIJCFJJLOO", "FMPNNHDPGKD", "Reward" }, null, null, null, null)
		}));
	}
}
