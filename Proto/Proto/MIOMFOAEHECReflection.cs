using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MIOMFOAEHECReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MIOMFOAEHECReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNSU9NRk9BRUhFQy5wcm90bxoRQkxLQUlFSE9DQkMucHJvdG8iaAoLTUlP" + "TUZPQUVIRUMSIQoLSVBISEdNRUNBS0IYBSABKAsyDC5CTEtBSUVIT0NCQxIT" + "CgtNQUdDR1BNSEhFQRgGIAEoDRIhCgtJSkFFQkRDRkVNRxgMIAEoCzIMLkJM" + "S0FJRUhPQ0JDQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { BLKAIEHOCBCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MIOMFOAEHEC), MIOMFOAEHEC.Parser, new string[3] { "IPHHGMECAKB", "MAGCGPMHHEA", "IJAEBDCFEMG" }, null, null, null, null)
		}));
	}
}
