using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueMagicLevelInfoUpdateScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueMagicLevelInfoUpdateScNotifyReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "CidSb2d1ZU1hZ2ljTGV2ZWxJbmZvVXBkYXRlU2NOb3RpZnkucHJvdG8aEUxC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "TUxMSkhGRUhCLnByb3RvGhFPRkhQS0pESE9NRi5wcm90bxoRT0pFSkNIQkhD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "SkwucHJvdG8iwQEKIVJvZ3VlTWFnaWNMZXZlbEluZm9VcGRhdGVTY05vdGlm";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "eRITCgtLRURJTU1BR0ZCTxgBIAEoDRITCgtOTE1NRkpPUEJGQxgGIAEoDRIc";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "CgZzdGF0dXMYCCABKA4yDC5MQk1MTEpIRkVIQhIcCgZyZWFzb24YCyABKA4y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "DC5PRkhQS0pESE9NRhITCgtBUE1JQUtEUEhKTBgNIAEoDRIhCgtGSExKRUhE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "SEpMSRgOIAMoCzIMLk9KRUpDSEJIQ0pMQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[3]
		{
			LBMLLJHFEHBReflection.Descriptor,
			OFHPKJDHOMFReflection.Descriptor,
			OJEJCHBHCJLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicLevelInfoUpdateScNotify), RogueMagicLevelInfoUpdateScNotify.Parser, new string[6] { "KEDIMMAGFBO", "NLMMFJOPBFC", "Status", "Reason", "APMIAKDPHJL", "FHLJEHDHJLI" }, null, null, null, null)
		}));
	}
}
