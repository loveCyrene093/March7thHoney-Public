using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RaidCollectionEnterNextRaidScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RaidCollectionEnterNextRaidScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSYWlkQ29sbGVjdGlvbkVudGVyTmV4dFJhaWRTY1JzcC5wcm90bxoRRk5K" + "SkNJR0pJS0MucHJvdG8iUAogUmFpZENvbGxlY3Rpb25FbnRlck5leHRSYWlk" + "U2NSc3ASDwoHcmV0Y29kZRgBIAEoDRIbCgVzY2VuZRgMIAEoCzIMLkZOSkpD" + "SUdKSUtDQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { FNJJCIGJIKCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RaidCollectionEnterNextRaidScRsp), RaidCollectionEnterNextRaidScRsp.Parser, new string[2] { "Retcode", "Scene" }, null, null, null, null)
		}));
	}
}
