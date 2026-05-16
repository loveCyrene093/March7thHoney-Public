using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournSettleCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournSettleCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtSb2d1ZVRvdXJuU2V0dGxlQ3NSZXEucHJvdG8iFwoVUm9ndWVUb3VyblNl" + "dHRsZUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournSettleCsReq), RogueTournSettleCsReq.Parser, null, null, null, null, null)
		}));
	}
}
