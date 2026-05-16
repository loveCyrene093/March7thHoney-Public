using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MBPNKKMKCHCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MBPNKKMKCHCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNQlBOS0tNS0NIQy5wcm90bxoRS1BKRk9CT0tLTk8ucHJvdG8iQQoLTUJQ" + "TktLTUtDSEMSDwoHcmV0Y29kZRgDIAEoDRIhCgtJR0lQQUtFTEpGRBgMIAEo" + "CzIMLktQSkZPQk9LS05PQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { KPJFOBOKKNOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MBPNKKMKCHC), MBPNKKMKCHC.Parser, new string[2] { "Retcode", "IGIPAKELJFD" }, null, null, null, null)
		}));
	}
}
