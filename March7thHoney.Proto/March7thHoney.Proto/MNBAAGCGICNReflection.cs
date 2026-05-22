using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MNBAAGCGICNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MNBAAGCGICNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNTkJBQUdDR0lDTi5wcm90bxoRTkhES0xNSU1MS0MucHJvdG8iQQoLTU5C" + "QUFHQ0dJQ04SDwoHcmV0Y29kZRgNIAEoDRIhCgtJTU5PSklESkJORxgOIAEo" + "CzIMLk5IREtMTUlNTEtDQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { NHDKLMIMLKCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MNBAAGCGICN), MNBAAGCGICN.Parser, new string[2] { "Retcode", "IMNOJIDJBNG" }, null, null, null, null)
		}));
	}
}
