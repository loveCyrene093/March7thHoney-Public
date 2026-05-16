using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PCKNAJOFGLDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PCKNAJOFGLDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQQ0tOQUpPRkdMRC5wcm90bxoRQ0pMSkRLTENOREEucHJvdG8iQQoLUENL" + "TkFKT0ZHTEQSDwoHcmV0Y29kZRgLIAEoDRIhCgtNT0RESUJIQ1BQRBgMIAEo" + "CzIMLkNKTEpES0xDTkRBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { CJLJDKLCNDAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PCKNAJOFGLD), PCKNAJOFGLD.Parser, new string[2] { "Retcode", "MODDIBHCPPD" }, null, null, null, null)
		}));
	}
}
