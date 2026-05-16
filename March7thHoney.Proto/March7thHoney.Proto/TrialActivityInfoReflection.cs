using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrialActivityInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrialActivityInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdUcmlhbEFjdGl2aXR5SW5mby5wcm90byI7ChFUcmlhbEFjdGl2aXR5SW5m" + "bxIUCgx0YWtlbl9yZXdhcmQYAiABKAgSEAoIc3RhZ2VfaWQYCSABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrialActivityInfo), TrialActivityInfo.Parser, new string[2] { "TakenReward", "StageId" }, null, null, null, null)
		}));
	}
}
