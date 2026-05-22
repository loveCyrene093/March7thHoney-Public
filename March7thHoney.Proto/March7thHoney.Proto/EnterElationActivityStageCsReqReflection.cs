using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterElationActivityStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterElationActivityStageCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiRFbnRlckVsYXRpb25BY3Rpdml0eVN0YWdlQ3NSZXEucHJvdG8aG0VsYXRp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "b25BY3Rpdml0eUF2YXRhci5wcm90byKiAQoeRW50ZXJFbGF0aW9uQWN0aXZp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "dHlTdGFnZUNzUmVxEjsKG3BsYXllcl9zZWxlY3RlZF9hdmF0YXJfbGlzdBgH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "IAMoCzIWLkVsYXRpb25BY3Rpdml0eUF2YXRhchIxChFmaXhlZF9hdmF0YXJf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "bGlzdBgIIAMoCzIWLkVsYXRpb25BY3Rpdml0eUF2YXRhchIQCghsZXZlbF9p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "ZBgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { ElationActivityAvatarReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterElationActivityStageCsReq), EnterElationActivityStageCsReq.Parser, new string[3] { "PlayerSelectedAvatarList", "FixedAvatarList", "LevelId" }, null, null, null, null)
		}));
	}
}
