using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleEndReasonReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleEndReasonReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVCYXR0bGVFbmRSZWFzb24ucHJvdG8qbgoPQmF0dGxlRW5kUmVhc29uEhoK" + "FkJBVFRMRV9FTkRfUkVBU09OX05PTkUQABIdChlCQVRUTEVfRU5EX1JFQVNP" + "Tl9BTExfRElFEAESIAocQkFUVExFX0VORF9SRUFTT05fVFVSTl9MSU1JVBAC" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(BattleEndReason) }, null, null));
	}
}
