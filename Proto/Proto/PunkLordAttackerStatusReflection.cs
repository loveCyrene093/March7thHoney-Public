using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PunkLordAttackerStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PunkLordAttackerStatusReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChxQdW5rTG9yZEF0dGFja2VyU3RhdHVzLnByb3RvKowBChZQdW5rTG9yZEF0";
		buffer[1] = "dGFja2VyU3RhdHVzEhsKF0lIREhGS0pIQUFIX1BDUERIRUxQS0VNEAASGwoX";
		buffer[2] = "SUhESEZLSkhBQUhfQklJT0tKSE5CUE4QARIbChdJSERIRktKSEFBSF9HSERJ";
		buffer[3] = "TE1NSEVDQhACEhsKF0lIREhGS0pIQUFIX0NCRURDRURNSkhBEANCFqoCE01h";
		buffer[4] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(PunkLordAttackerStatus) }, null, null));
	}
}
