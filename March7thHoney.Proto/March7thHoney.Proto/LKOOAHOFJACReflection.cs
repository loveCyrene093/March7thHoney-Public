using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LKOOAHOFJACReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LKOOAHOFJACReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMS09PQUhPRkpBQy5wcm90byJ+CgtMS09PQUhPRkpBQxIbChNzZXJ2ZXJf" + "dGltZXN0YW1wX21zGAQgASgEEg8KB3JldGNvZGUYBSABKA0SFwoPc2VjcmV0" + "X2tleV9zZWVkGAYgASgEEhMKC0FMTEhEQUZHRENKGAsgASgIEhMKC0tGTUFF" + "R05OSkRMGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LKOOAHOFJAC), LKOOAHOFJAC.Parser, new string[5] { "ServerTimestampMs", "Retcode", "SecretKeySeed", "ALLHDAFGDCJ", "KFMAEGNNJDL" }, null, null, null, null)
		}));
	}
}
