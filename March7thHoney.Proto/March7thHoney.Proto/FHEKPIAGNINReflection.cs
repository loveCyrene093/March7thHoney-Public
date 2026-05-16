using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FHEKPIAGNINReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FHEKPIAGNINReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGSEVLUElBR05JTi5wcm90byIzCgtGSEVLUElBR05JThITCgtIT0hBTlBK" + "TkFOQRgCIAEoDRIPCgdyZXRjb2RlGAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FHEKPIAGNIN), FHEKPIAGNIN.Parser, new string[2] { "HOHANPJNANA", "Retcode" }, null, null, null, null)
		}));
	}
}
