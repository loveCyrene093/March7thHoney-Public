using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BIDMHOFDCICReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BIDMHOFDCICReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCSURNSE9GRENJQy5wcm90bxoRS0xDSUNOSEFPUEYucHJvdG8iQQoLQklE" + "TUhPRkRDSUMSDwoHcmV0Y29kZRgBIAEoDRIhCgtGR0xKT0tJTEtIRxgHIAEo" + "CzIMLktMQ0lDTkhBT1BGQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { KLCICNHAOPFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BIDMHOFDCIC), BIDMHOFDCIC.Parser, new string[2] { "Retcode", "FGLJOKILKHG" }, null, null, null, null)
		}));
	}
}
