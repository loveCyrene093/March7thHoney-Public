using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PKAFDHFOMOLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PKAFDHFOMOLReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFQS0FGREhGT01PTC5wcm90bxoRQURITkpBRElKQUMucHJvdG8aEURMQ0NP";
		buffer[1] = "SlBIQkNCLnByb3RvImQKC1BLQUZESEZPTU9MEiEKC0hHUEdEQ09DREZLGAIg";
		buffer[2] = "ASgLMgwuRExDQ09KUEhCQ0ISDwoHcmV0Y29kZRgIIAEoDRIhCgtCSUVCRkhF";
		buffer[3] = "Q0VQTRgLIAMoCzIMLkFESE5KQURJSkFDQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[4] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ADHNJADIJACReflection.Descriptor,
			DLCCOJPHBCBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PKAFDHFOMOL), PKAFDHFOMOL.Parser, new string[3] { "HGPGDCOCDFK", "Retcode", "BIEBFHECEPM" }, null, null, null, null)
		}));
	}
}
