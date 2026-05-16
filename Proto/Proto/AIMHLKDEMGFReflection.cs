using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AIMHLKDEMGFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AIMHLKDEMGFReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFBSU1ITEtERU1HRi5wcm90bxoOSXRlbUxpc3QucHJvdG8iygEKC0FJTUhM";
		buffer[1] = "S0RFTUdGEjIKC0RCRE9JSFBMQUZNGAEgAygLMh0uQUlNSExLREVNR0YuREJE";
		buffer[2] = "T0lIUExBRk1FbnRyeRITCgtKQUZOQ09NR0FCRxgDIAEoDRITCgtFSUlBR0FC";
		buffer[3] = "QUZFQxgIIAEoDRIeCgtNSkFOT0tFT0RJQhgNIAEoCzIJLkl0ZW1MaXN0Gj0K";
		buffer[4] = "EERCRE9JSFBMQUZNRW50cnkSCwoDa2V5GAEgASgNEhgKBXZhbHVlGAIgASgL";
		buffer[5] = "MgkuSXRlbUxpc3Q6AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[6] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AIMHLKDEMGF), AIMHLKDEMGF.Parser, new string[4] { "DBDOIHPLAFM", "JAFNCOMGABG", "EIIAGABAFEC", "MJANOKEODIB" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
