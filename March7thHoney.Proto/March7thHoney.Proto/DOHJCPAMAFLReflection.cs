using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DOHJCPAMAFLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DOHJCPAMAFLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFET0hKQ1BBTUFGTC5wcm90bxoRR05BTk1FQURQQkQucHJvdG8iQQoLRE9I" + "SkNQQU1BRkwSIQoLRUZKQkZCRU5HS0cYAyABKAsyDC5HTkFOTUVBRFBCRBIP" + "CgdyZXRjb2RlGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { GNANMEADPBDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DOHJCPAMAFL), DOHJCPAMAFL.Parser, new string[2] { "EFJBFBENGKG", "Retcode" }, null, null, null, null)
		}));
	}
}
