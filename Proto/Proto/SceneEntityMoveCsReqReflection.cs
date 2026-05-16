using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneEntityMoveCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneEntityMoveCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChpTY2VuZUVudGl0eU1vdmVDc1JlcS5wcm90bxoSRW50aXR5TW90aW9uLnBy";
		buffer[1] = "b3RvIn0KFFNjZW5lRW50aXR5TW92ZUNzUmVxEhAKCGVudHJ5X2lkGAMgASgN";
		buffer[2] = "EhMKC2ludGVyYWN0X2lkGAYgASgEEikKEmVudGl0eV9tb3Rpb25fbGlzdBgK";
		buffer[3] = "IAMoCzINLkVudGl0eU1vdGlvbhITCgtCRkJFSE1BRkpNQxgNIAEoBEIWqgIT";
		buffer[4] = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { EntityMotionReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneEntityMoveCsReq), SceneEntityMoveCsReq.Parser, new string[4] { "EntryId", "InteractId", "EntityMotionList", "BFBEHMAFJMC" }, null, null, null, null)
		}));
	}
}
