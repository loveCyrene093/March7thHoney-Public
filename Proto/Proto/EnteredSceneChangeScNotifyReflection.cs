using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnteredSceneChangeScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnteredSceneChangeScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBFbnRlcmVkU2NlbmVDaGFuZ2VTY05vdGlmeS5wcm90bxoWRW50ZXJlZFNj" + "ZW5lSW5mby5wcm90byJQChpFbnRlcmVkU2NlbmVDaGFuZ2VTY05vdGlmeRIy" + "ChdlbnRlcmVkX3NjZW5lX2luZm9fbGlzdBgEIAMoCzIRLkVudGVyZWRTY2Vu" + "ZUluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { EnteredSceneInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnteredSceneChangeScNotify), EnteredSceneChangeScNotify.Parser, new string[1] { "EnteredSceneInfoList" }, null, null, null, null)
		}));
	}
}
