using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NJMPAPFMNFMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NJMPAPFMNFMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOSk1QQVBGTU5GTS5wcm90bxoRTkpCSEtMQ0tIQksucHJvdG8iQQoLTkpN" + "UEFQRk1ORk0SDwoHcmV0Y29kZRgBIAEoDRIhCgtNQU9OSERDQ0hQRRgEIAEo" + "CzIMLk5KQkhLTENLSEJLQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { NJBHKLCKHBKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NJMPAPFMNFM), NJMPAPFMNFM.Parser, new string[2] { "Retcode", "MAONHDCCHPE" }, null, null, null, null)
		}));
	}
}
