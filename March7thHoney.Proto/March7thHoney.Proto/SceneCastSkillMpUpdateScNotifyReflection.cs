using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneCastSkillMpUpdateScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneCastSkillMpUpdateScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRTY2VuZUNhc3RTa2lsbE1wVXBkYXRlU2NOb3RpZnkucHJvdG8iRAoeU2Nl" + "bmVDYXN0U2tpbGxNcFVwZGF0ZVNjTm90aWZ5EhYKDmNhc3RfZW50aXR5X2lk" + "GAMgASgNEgoKAm1wGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneCastSkillMpUpdateScNotify), SceneCastSkillMpUpdateScNotify.Parser, new string[2] { "CastEntityId", "Mp" }, null, null, null, null)
		}));
	}
}
