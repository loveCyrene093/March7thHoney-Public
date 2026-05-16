using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SecretKeyTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SecretKeyTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNTZWNyZXRLZXlUeXBlLnByb3RvKnMKDVNlY3JldEtleVR5cGUSEwoPU0VD" + "UkVUX0tFWV9OT05FEAASGwoXU0VDUkVUX0tFWV9TRVJWRVJfQ0hFQ0sQARIU" + "ChBTRUNSRVRfS0VZX1ZJREVPEAISGgoWU0VDUkVUX0tFWV9CQVRUTEVfVElN" + "RRADQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(SecretKeyType) }, null, null));
	}
}
