using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JOMBHCNIEMPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JOMBHCNIEMPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKT01CSENOSUVNUC5wcm90bxoRRUZFR0tESEVNRk4ucHJvdG8iQQoLSk9N" + "QkhDTklFTVASDwoHcmV0Y29kZRgHIAEoDRIhCgtGRU5MR0dBTUFQQRgMIAEo" + "CzIMLkVGRUdLREhFTUZOQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { EFEGKDHEMFNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JOMBHCNIEMP), JOMBHCNIEMP.Parser, new string[2] { "Retcode", "FENLGGAMAPA" }, null, null, null, null)
		}));
	}
}
