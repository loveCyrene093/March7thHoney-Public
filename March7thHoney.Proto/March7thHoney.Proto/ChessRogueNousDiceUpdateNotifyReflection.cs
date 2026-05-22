using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueNousDiceUpdateNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueNousDiceUpdateNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRDaGVzc1JvZ3VlTm91c0RpY2VVcGRhdGVOb3RpZnkucHJvdG8aEUdDSU1N" + "SUhLUEVJLnByb3RvIkMKHkNoZXNzUm9ndWVOb3VzRGljZVVwZGF0ZU5vdGlm" + "eRIhCgtOTktDT0ZPUE5CThgFIAEoCzIMLkdDSU1NSUhLUEVJQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { GCIMMIHKPEIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueNousDiceUpdateNotify), ChessRogueNousDiceUpdateNotify.Parser, new string[1] { "NNKCOFOPNBN" }, null, null, null, null)
		}));
	}
}
