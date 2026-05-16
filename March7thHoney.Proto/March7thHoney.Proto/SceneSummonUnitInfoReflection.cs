using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneSummonUnitInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneSummonUnitInfoReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChlTY2VuZVN1bW1vblVuaXRJbmZvLnByb3RvIqoBChNTY2VuZVN1bW1vblVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "aXRJbmZvEhYKDnN1bW1vbl91bml0X2lkGAEgASgNEhkKEXRyaWdnZXJfbmFt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "ZV9saXN0GAMgAygJEhYKDmNyZWF0ZV90aW1lX21zGAUgASgEEhQKDGxpZmVf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "dGltZV9tcxgHIAEoBRIYChBhdHRhY2hfZW50aXR5X2lkGAggASgNEhgKEGNh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "c3Rlcl9lbnRpdHlfaWQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneSummonUnitInfo), SceneSummonUnitInfo.Parser, new string[6] { "SummonUnitId", "TriggerNameList", "CreateTimeMs", "LifeTimeMs", "AttachEntityId", "CasterEntityId" }, null, null, null, null)
		}));
	}
}
