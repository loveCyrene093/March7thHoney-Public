using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LBMPPLKEBFOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LBMPPLKEBFOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMQk1QUExLRUJGTy5wcm90bxoRR05BTk1FQURQQkQucHJvdG8iQQoLTEJN" + "UFBMS0VCRk8SIQoLRUZKQkZCRU5HS0cYBiABKAsyDC5HTkFOTUVBRFBCRBIP" + "CgdyZXRjb2RlGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { GNANMEADPBDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LBMPPLKEBFO), LBMPPLKEBFO.Parser, new string[2] { "EFJBFBENGKG", "Retcode" }, null, null, null, null)
		}));
	}
}
