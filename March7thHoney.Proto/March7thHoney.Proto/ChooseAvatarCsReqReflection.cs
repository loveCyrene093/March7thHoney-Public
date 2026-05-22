using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChooseAvatarCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChooseAvatarCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdDaG9vc2VBdmF0YXJDc1JlcS5wcm90byImChFDaG9vc2VBdmF0YXJDc1Jl" + "cRIRCglhdmF0YXJfaWQYCSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChooseAvatarCsReq), ChooseAvatarCsReq.Parser, new string[1] { "AvatarId" }, null, null, null, null)
		}));
	}
}
