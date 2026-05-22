using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChangePropTimelineInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChangePropTimelineInfoCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiFDaGFuZ2VQcm9wVGltZWxpbmVJbmZvQ3NSZXEucHJvdG8aFlByb3BUaW1l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "bGluZUluZm8ucHJvdG8imAEKG0NoYW5nZVByb3BUaW1lbGluZUluZm9Dc1Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "cRIUCgxpc19jbG9zZV9tYXAYASABKAgSFgoOcHJvcF9lbnRpdHlfaWQYAyAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "KA0SDAoEdXVpZBgGIAEoBBIoCg10aW1lbGluZV9pbmZvGAsgASgLMhEuUHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "cFRpbWVsaW5lSW5mbxITCgtpbnRlcmFjdF9pZBgPIAEoBEIWqgITTWFyY2g3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { PropTimelineInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChangePropTimelineInfoCsReq), ChangePropTimelineInfoCsReq.Parser, new string[5] { "IsCloseMap", "PropEntityId", "Uuid", "TimelineInfo", "InteractId" }, null, null, null, null)
		}));
	}
}
