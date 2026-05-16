using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AetherDivideFinishChallengeScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AetherDivideFinishChallengeScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilBZXRoZXJEaXZpZGVGaW5pc2hDaGFsbGVuZ2VTY05vdGlmeS5wcm90byI7" + "CiNBZXRoZXJEaXZpZGVGaW5pc2hDaGFsbGVuZ2VTY05vdGlmeRIUCgxjaGFs" + "bGVuZ2VfaWQYAiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AetherDivideFinishChallengeScNotify), AetherDivideFinishChallengeScNotify.Parser, new string[1] { "ChallengeId" }, null, null, null, null)
		}));
	}
}
