using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GLJLEEPOCDAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GLJLEEPOCDAReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFHTEpMRUVQT0NEQS5wcm90byqBAQoLR0xKTEVFUE9DREESGwoXR0xKTEVF";
		buffer[1] = "UE9DREFfUENQREhFTFBLRU0QABIbChdHTEpMRUVQT0NEQV9GQ0VITk1KSkFC";
		buffer[2] = "RRABEhsKF0dMSkxFRVBPQ0RBX0ZOS0RJRUJLT0hBEAISGwoXR0xKTEVFUE9D";
		buffer[3] = "REFfQk1DSE1BT0lLREUQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GLJLEEPOCDA) }, null, null));
	}
}
