using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LBDMFFDNFDPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LBDMFFDNFDPReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFMQkRNRkZETkZEUC5wcm90byqBAQoLTEJETUZGRE5GRFASGwoXTEJETUZG";
		buffer[1] = "RE5GRFBfR0hHQVBPQUtHQUIQABIbChdMQkRNRkZETkZEUF9DQlBOT05CR1BJ";
		buffer[2] = "TRABEhsKF0xCRE1GRkRORkRQX0RQTUpOTUtHR09BEAISGwoXTEJETUZGRE5G";
		buffer[3] = "RFBfS0xIRENPUFBMTkcQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(LBDMFFDNFDP) }, null, null));
	}
}
