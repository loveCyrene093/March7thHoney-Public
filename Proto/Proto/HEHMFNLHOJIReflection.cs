using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HEHMFNLHOJIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HEHMFNLHOJIReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFIRUhNRk5MSE9KSS5wcm90bxoRRExQR0tKTEJGTEkucHJvdG8aEUpNQk5G";
		buffer[1] = "SU5QSENBLnByb3RvImYKC0hFSE1GTkxIT0pJEiMKC0NPSE1HR1BISUhOGAQg";
		buffer[2] = "ASgLMgwuSk1CTkZJTlBIQ0FIABIjCgtDSUNHTU5ITUxNRRgLIAEoCzIMLkRM";
		buffer[3] = "UEdLSkxCRkxJSABCDQoLTkxQUFBDSEdHUEZCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[4] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			DLPGKJLBFLIReflection.Descriptor,
			JMBNFINPHCAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HEHMFNLHOJI), HEHMFNLHOJI.Parser, new string[2] { "COHMGGPHIHN", "CICGMNHMLME" }, new string[1] { "NLPPPCHGGPF" }, null, null, null)
		}));
	}
}
