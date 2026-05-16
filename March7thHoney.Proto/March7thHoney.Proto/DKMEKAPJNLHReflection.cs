using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DKMEKAPJNLHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DKMEKAPJNLHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFES01FS0FQSk5MSC5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIkAKC0RL" + "TUVLQVBKTkxIEg8KB2J1ZmZfaWQYBCABKA0SIAoJY29zdF9kYXRhGAwgASgL" + "Mg0uSXRlbUNvc3REYXRhQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DKMEKAPJNLH), DKMEKAPJNLH.Parser, new string[2] { "BuffId", "CostData" }, null, null, null, null)
		}));
	}
}
