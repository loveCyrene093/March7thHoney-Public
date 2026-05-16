using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneNpcInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneNpcInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJTY2VuZU5wY0luZm8ucHJvdG8aEk5wY0V4dHJhSW5mby5wcm90byJBCgxT" + "Y2VuZU5wY0luZm8SDgoGbnBjX2lkGAMgASgNEiEKCmV4dHJhX2luZm8YDCAB" + "KAsyDS5OcGNFeHRyYUluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[1] { NpcExtraInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneNpcInfo), SceneNpcInfo.Parser, new string[2] { "NpcId", "ExtraInfo" }, null, null, null, null)
		}));
	}
}
