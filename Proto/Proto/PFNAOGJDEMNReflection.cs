using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PFNAOGJDEMNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PFNAOGJDEMNReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFQRk5BT0dKREVNTi5wcm90byqBAQoLUEZOQU9HSkRFTU4SGwoXUEZOQU9H";
		buffer[1] = "SkRFTU5fUENQREhFTFBLRU0QABIbChdQRk5BT0dKREVNTl9BUEZGRURES05C";
		buffer[2] = "SxABEhsKF1BGTkFPR0pERU1OX0hNTElQTEdJRUVDEAISGwoXUEZOQU9HSkRF";
		buffer[3] = "TU5fRk9NTUZFTUlCS08QA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(PFNAOGJDEMN) }, null, null));
	}
}
