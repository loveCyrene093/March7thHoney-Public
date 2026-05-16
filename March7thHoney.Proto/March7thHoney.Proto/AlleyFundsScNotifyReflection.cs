using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AlleyFundsScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AlleyFundsScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhBbGxleUZ1bmRzU2NOb3RpZnkucHJvdG8iJgoSQWxsZXlGdW5kc1NjTm90" + "aWZ5EhAKCGN1cl9mdW5kGAMgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AlleyFundsScNotify), AlleyFundsScNotify.Parser, new string[1] { "CurFund" }, null, null, null, null)
		}));
	}
}
