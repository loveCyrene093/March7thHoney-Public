using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KPOCAINFJDAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KPOCAINFJDAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLUE9DQUlORkpEQS5wcm90bxoRQURNQ01GSUlOSUgucHJvdG8iVgoLS1BP" + "Q0FJTkZKREESEwoLTU9ISElKR0hQTkIYAyABKA0SIQoLTEhGTU5BSElET00Y" + "BiADKAsyDC5BRE1DTUZJSU5JSBIPCgdyZXRjb2RlGAogASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ADMCMFIINIHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KPOCAINFJDA), KPOCAINFJDA.Parser, new string[3] { "MOHHIJGHPNB", "LHFMNAHIDOM", "Retcode" }, null, null, null, null)
		}));
	}
}
