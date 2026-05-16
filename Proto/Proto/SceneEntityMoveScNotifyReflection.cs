using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneEntityMoveScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneEntityMoveScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch1TY2VuZUVudGl0eU1vdmVTY05vdGlmeS5wcm90bxoQTW90aW9uSW5mby5w";
		buffer[1] = "cm90byJ3ChdTY2VuZUVudGl0eU1vdmVTY05vdGlmeRIbCgZtb3Rpb24YBCAB";
		buffer[2] = "KAsyCy5Nb3Rpb25JbmZvEhAKCGVudHJ5X2lkGAUgASgNEhEKCWVudGl0eV9p";
		buffer[3] = "ZBgNIAEoDRIaChJjbGllbnRfcG9zX3ZlcnNpb24YDyABKA1CFqoCE01hcmNo";
		buffer[4] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MotionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneEntityMoveScNotify), SceneEntityMoveScNotify.Parser, new string[4] { "Motion", "EntryId", "EntityId", "ClientPosVersion" }, null, null, null, null)
		}));
	}
}
