using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AFHIHMKCPNFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AFHIHMKCPNFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBRkhJSE1LQ1BORi5wcm90byI2CgtBRkhJSE1LQ1BORhITCgtQSUdGQ0FF" + "Q0ZDRhgBIAEoDRISCgptb25zdGVyX2lkGAIgASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AFHIHMKCPNF), AFHIHMKCPNF.Parser, new string[2] { "PIGFCAECFCF", "MonsterId" }, null, null, null, null)
		}));
	}
}
