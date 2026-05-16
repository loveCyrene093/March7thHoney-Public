using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BBOGAPHFIBGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BBOGAPHFIBGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQk9HQVBIRklCRy5wcm90byJgCgtCQk9HQVBIRklCRxITCgtHSUlJR0pG" + "TUhQTxgDIAEoDRISCgphcHBseV90aW1lGAYgASgDEhMKC0VQR0lLR0NBREhN" + "GAogASgNEhMKC0RKREVCS1BHSkROGA0gAygNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BBOGAPHFIBG), BBOGAPHFIBG.Parser, new string[4] { "GIIIGJFMHPO", "ApplyTime", "EPGIKGCADHM", "DJDEBKPGJDN" }, null, null, null, null)
		}));
	}
}
