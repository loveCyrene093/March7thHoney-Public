using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerReturnTakeRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerReturnTakeRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFQbGF5ZXJSZXR1cm5UYWtlUmV3YXJkQ3NSZXEucHJvdG8iHQobUGxheWVy" + "UmV0dXJuVGFrZVJld2FyZENzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerReturnTakeRewardCsReq), PlayerReturnTakeRewardCsReq.Parser, null, null, null, null, null)
		}));
	}
}
