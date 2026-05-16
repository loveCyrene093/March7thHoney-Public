using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MuseumRandomEventStateReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MuseumRandomEventStateReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChxNdXNldW1SYW5kb21FdmVudFN0YXRlLnByb3RvKowBChZNdXNldW1SYW5k";
		buffer[1] = "b21FdmVudFN0YXRlEhsKF0pLRUtORERCRE1DX1BDUERIRUxQS0VNEAASGwoX";
		buffer[2] = "SktFS05EREJETUNfRERMUEdOSEFEQ0oQARIbChdKS0VLTkREQkRNQ19IUEpF";
		buffer[3] = "QkZGSEpOUBACEhsKF0pLRUtORERCRE1DX0tMSERDT1BQTE5HEANCFqoCE01h";
		buffer[4] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MuseumRandomEventState) }, null, null));
	}
}
