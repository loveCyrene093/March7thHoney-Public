using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EvolveBuildStartLevelCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EvolveBuildStartLevelCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiBFdm9sdmVCdWlsZFN0YXJ0TGV2ZWxDc1JlcS5wcm90bxoRSEhJUEtJTk5D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "QVAucHJvdG8aEU1PRURHT0hPQUxQLnByb3RvInQKGkV2b2x2ZUJ1aWxkU3Rh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "cnRMZXZlbENzUmVxEiEKC0VEREpHTk5PQ0FHGAYgASgLMgwuSEhJUEtJTk5D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "QVASEAoIbGV2ZWxfaWQYCSABKA0SIQoLYXZhdGFyX2xpc3QYDCADKAsyDC5N";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "T0VER09IT0FMUEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			HHIPKINNCAPReflection.Descriptor,
			MOEDGOHOALPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildStartLevelCsReq), EvolveBuildStartLevelCsReq.Parser, new string[3] { "EDDJGNNOCAG", "LevelId", "AvatarList" }, null, null, null, null)
		}));
	}
}
