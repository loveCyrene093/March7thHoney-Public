using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyBuildRoomScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyBuildRoomScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFUcmFpblBhcnR5QnVpbGRSb29tU2NOb3RpZnkucHJvdG8aFFRyYWluUGFy" + "dHlJbmZvLnByb3RvIkMKG1RyYWluUGFydHlCdWlsZFJvb21TY05vdGlmeRIk" + "CgtNQklFTUJKTUpKThgHIAEoCzIPLlRyYWluUGFydHlJbmZvQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { TrainPartyInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyBuildRoomScNotify), TrainPartyBuildRoomScNotify.Parser, new string[1] { "MBIEMBJMJJN" }, null, null, null, null)
		}));
	}
}
