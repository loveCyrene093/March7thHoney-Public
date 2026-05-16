using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HCKLELPMGDJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HCKLELPMGDJReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFIQ0tMRUxQTUdESi5wcm90byqBAQoLSENLTEVMUE1HREoSGwoXSENLTEVM";
		buffer[1] = "UE1HREpfTEFKS0dESE5BSkoQABIbChdIQ0tMRUxQTUdESl9FRVBDTlBPQU5J";
		buffer[2] = "SBABEhsKF0hDS0xFTFBNR0RKX0xPSU5JTkJQSUJJEAISGwoXSENLTEVMUE1H";
		buffer[3] = "REpfQkVCSkVJR1BPSVAQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(HCKLELPMGDJ) }, null, null));
	}
}
