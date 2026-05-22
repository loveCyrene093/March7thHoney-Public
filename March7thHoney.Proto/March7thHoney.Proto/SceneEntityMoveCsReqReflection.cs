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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChpTY2VuZUVudGl0eU1vdmVDc1JlcS5wcm90bxoSRW50aXR5TW90aW9uLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "b3RvIn0KFFNjZW5lRW50aXR5TW92ZUNzUmVxEhAKCGVudHJ5X2lkGAMgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EhMKC2ludGVyYWN0X2lkGAYgASgEEikKEmVudGl0eV9tb3Rpb25fbGlzdBgK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "IAMoCzINLkVudGl0eU1vdGlvbhITCgtCRkJFSE1BRkpNQxgNIAEoBEIWqgIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { EntityMotionReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneEntityMoveCsReq), SceneEntityMoveCsReq.Parser, new string[4] { "EntryId", "InteractId", "EntityMotionList", "BFBEHMAFJMC" }, null, null, null, null)
		}));
	}
}
