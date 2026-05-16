using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesGetAvatarStatCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesGetAvatarStatCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFQbGFuZXRGZXNHZXRBdmF0YXJTdGF0Q3NSZXEucHJvdG8iHQobUGxhbmV0" + "RmVzR2V0QXZhdGFyU3RhdENzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesGetAvatarStatCsReq), PlanetFesGetAvatarStatCsReq.Parser, null, null, null, null, null)
		}));
	}
}
