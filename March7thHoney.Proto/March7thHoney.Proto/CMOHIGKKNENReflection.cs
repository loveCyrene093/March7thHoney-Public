using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CMOHIGKKNENReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CMOHIGKKNENReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTU9ISUdLS05FTi5wcm90bxoRTkpCSEtMQ0tIQksucHJvdG8iQQoLQ01P" + "SElHS0tORU4SDwoHcmV0Y29kZRgBIAEoDRIhCgtNQU9OSERDQ0hQRRgKIAEo" + "CzIMLk5KQkhLTENLSEJLQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { NJBHKLCKHBKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CMOHIGKKNEN), CMOHIGKKNEN.Parser, new string[2] { "Retcode", "MAONHDCCHPE" }, null, null, null, null)
		}));
	}
}
