using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolySttUpdateScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolySttUpdateScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Nb25vcG9seVN0dFVwZGF0ZVNjTm90aWZ5LnByb3RvGhFNREtQT0FFRUdK" + "Qi5wcm90byI2ChlNb25vcG9seVN0dFVwZGF0ZVNjTm90aWZ5EhkKA3N0dBgH" + "IAEoCzIMLk1ES1BPQUVFR0pCQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[1] { MDKPOAEEGJBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolySttUpdateScNotify), MonopolySttUpdateScNotify.Parser, new string[1] { "Stt" }, null, null, null, null)
		}));
	}
}
