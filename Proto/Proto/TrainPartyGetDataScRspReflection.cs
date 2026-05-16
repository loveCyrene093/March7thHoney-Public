using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyGetDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyGetDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxUcmFpblBhcnR5R2V0RGF0YVNjUnNwLnByb3RvGhRUcmFpblBhcnR5RGF0" + "YS5wcm90byJUChZUcmFpblBhcnR5R2V0RGF0YVNjUnNwEg8KB3JldGNvZGUY" + "BiABKA0SKQoQdHJhaW5fcGFydHlfZGF0YRgLIAEoCzIPLlRyYWluUGFydHlE" + "YXRhQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { TrainPartyDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyGetDataScRsp), TrainPartyGetDataScRsp.Parser, new string[2] { "Retcode", "TrainPartyData" }, null, null, null, null)
		}));
	}
}
