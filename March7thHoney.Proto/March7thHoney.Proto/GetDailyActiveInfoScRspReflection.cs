using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetDailyActiveInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetDailyActiveInfoScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "Ch1HZXREYWlseUFjdGl2ZUluZm9TY1JzcC5wcm90bxoXRGFpbHlBY3Rpdml0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "eUluZm8ucHJvdG8inwEKF0dldERhaWx5QWN0aXZlSW5mb1NjUnNwEg8KB3Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "dGNvZGUYAiABKA0SMwoXZGFpbHlfYWN0aXZlX2xldmVsX2xpc3QYCSADKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "Ei5EYWlseUFjdGl2aXR5SW5mbxIiChpkYWlseV9hY3RpdmVfcXVlc3RfaWRf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "bGlzdBgKIAMoDRIaChJkYWlseV9hY3RpdmVfcG9pbnQYDiABKA1CFqoCE01h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { DailyActivityInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetDailyActiveInfoScRsp), GetDailyActiveInfoScRsp.Parser, new string[4] { "Retcode", "DailyActiveLevelList", "DailyActiveQuestIdList", "DailyActivePoint" }, null, null, null, null)
		}));
	}
}
