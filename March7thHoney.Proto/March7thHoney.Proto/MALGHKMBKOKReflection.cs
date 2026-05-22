using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MALGHKMBKOKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MALGHKMBKOKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNQUxHSEtNQktPSy5wcm90bxoRREtER0dHQ0RBR00ucHJvdG8iSgoLTUFM" + "R0hLTUJLT0sSEAoIc2NvcmVfaWQYBCABKA0SCwoDdWlkGAYgASgNEhwKBmxp" + "bmV1cBgMIAEoCzIMLkRLREdHR0NEQUdNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[1] { DKDGGGCDAGMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MALGHKMBKOK), MALGHKMBKOK.Parser, new string[3] { "ScoreId", "Uid", "Lineup" }, null, null, null, null)
		}));
	}
}
