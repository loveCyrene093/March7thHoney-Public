using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CNHPHDCJEKGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CNHPHDCJEKGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTkhQSERDSkVLRy5wcm90byJICgtDTkhQSERDSkVLRxITCgtDREtFREZQ" + "RUZJShgFIAEoDRITCgtBQ01HQk5ORUFDShgGIAEoCBIPCgdyZXRjb2RlGAog" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CNHPHDCJEKG), CNHPHDCJEKG.Parser, new string[3] { "CDKEDFPEFIJ", "ACMGBNNEACJ", "Retcode" }, null, null, null, null)
		}));
	}
}
