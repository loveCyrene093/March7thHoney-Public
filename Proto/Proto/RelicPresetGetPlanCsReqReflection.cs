using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicPresetGetPlanCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicPresetGetPlanCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1SZWxpY1ByZXNldEdldFBsYW5Dc1JlcS5wcm90byIsChdSZWxpY1ByZXNl" + "dEdldFBsYW5Dc1JlcRIRCglhdmF0YXJfaWQYDSABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicPresetGetPlanCsReq), RelicPresetGetPlanCsReq.Parser, new string[1] { "AvatarId" }, null, null, null, null)
		}));
	}
}
