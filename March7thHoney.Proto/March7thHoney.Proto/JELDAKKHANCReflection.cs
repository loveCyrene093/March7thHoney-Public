using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JELDAKKHANCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JELDAKKHANCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKRUxEQUtLSEFOQy5wcm90bxoRTkFOT0ROTUZGRkgucHJvdG8iUwoLSkVM" + "REFLS0hBTkMSIQoLSkRPTUNGRkFDQUwYBiABKAsyDC5OQU5PRE5NRkZGSBIh" + "CgtBT1BBS0xJRkJBTBgPIAEoCzIMLk5BTk9ETk1GRkZIQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { NANODNMFFFHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JELDAKKHANC), JELDAKKHANC.Parser, new string[2] { "JDOMCFFACAL", "AOPAKLIFBAL" }, null, null, null, null)
		}));
	}
}
