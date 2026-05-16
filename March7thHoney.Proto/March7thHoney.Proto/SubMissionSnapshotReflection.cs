using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SubMissionSnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SubMissionSnapshotReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTdWJNaXNzaW9uU25hcHNob3QucHJvdG8iLAoSU3ViTWlzc2lvblNuYXBz" + "aG90EhYKDnN1Yl9taXNzaW9uX2lkGAEgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SubMissionSnapshot), SubMissionSnapshot.Parser, new string[1] { "SubMissionId" }, null, null, null, null)
		}));
	}
}
