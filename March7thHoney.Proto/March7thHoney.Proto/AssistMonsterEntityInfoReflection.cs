using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AssistMonsterEntityInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AssistMonsterEntityInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Bc3Npc3RNb25zdGVyRW50aXR5SW5mby5wcm90byIxChdBc3Npc3RNb25z" + "dGVyRW50aXR5SW5mbxIWCg5lbnRpdHlfaWRfbGlzdBgCIAMoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AssistMonsterEntityInfo), AssistMonsterEntityInfo.Parser, new string[1] { "EntityIdList" }, null, null, null, null)
		}));
	}
}
