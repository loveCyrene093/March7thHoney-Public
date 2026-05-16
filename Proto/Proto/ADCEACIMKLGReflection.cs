using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ADCEACIMKLGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ADCEACIMKLGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBRENFQUNJTUtMRy5wcm90bxoUVHVybkZvb2RTd2l0Y2gucHJvdG8iWQoL" + "QURDRUFDSU1LTEcSJAoLRURESU9ITU5OTkIYBCABKA4yDy5UdXJuRm9vZFN3" + "aXRjaBITCgtBTUZMTkxHQkpHTBgHIAEoCBIPCgdyZXRjb2RlGA8gASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { TurnFoodSwitchReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ADCEACIMKLG), ADCEACIMKLG.Parser, new string[3] { "EDDIOHMNNNB", "AMFLNLGBJGL", "Retcode" }, null, null, null, null)
		}));
	}
}
