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
		buffer[0] = "CiFDaGFuZ2VQcm9wVGltZWxpbmVJbmZvQ3NSZXEucHJvdG8aFlByb3BUaW1l";
		buffer[1] = "bGluZUluZm8ucHJvdG8imAEKG0NoYW5nZVByb3BUaW1lbGluZUluZm9Dc1Jl";
		buffer[2] = "cRIUCgxpc19jbG9zZV9tYXAYASABKAgSFgoOcHJvcF9lbnRpdHlfaWQYAyAB";
		buffer[3] = "KA0SDAoEdXVpZBgGIAEoBBIoCg10aW1lbGluZV9pbmZvGAsgASgLMhEuUHJv";
		buffer[4] = "cFRpbWVsaW5lSW5mbxITCgtpbnRlcmFjdF9pZBgPIAEoBEIWqgITTWFyY2g3";
		buffer[5] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { PropTimelineInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChangePropTimelineInfoCsReq), ChangePropTimelineInfoCsReq.Parser, new string[5] { "IsCloseMap", "PropEntityId", "Uuid", "TimelineInfo", "InteractId" }, null, null, null, null)
		}));
	}
}
