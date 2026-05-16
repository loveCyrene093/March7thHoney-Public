using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeartDialScriptChangeScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeartDialScriptChangeScNotifyReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "CiNIZWFydERpYWxTY3JpcHRDaGFuZ2VTY05vdGlmeS5wcm90bxobSGVhcnRE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "aWFsRGlhbG9ndWVJbmZvLnByb3RvGhlIZWFydERpYWxTY3JpcHRJbmZvLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "b3RvGhtIZWFydERpYWxVbmxvY2tTdGF0dXMucHJvdG8aEVBJQ0lMSUlGS0JF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "LnByb3RvIuUBCh1IZWFydERpYWxTY3JpcHRDaGFuZ2VTY05vdGlmeRI6Chpj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "aGFuZ2VkX2RpYWxvZ3VlX2luZm9fbGlzdBgCIAMoCzIWLkhlYXJ0RGlhbERp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "YWxvZ3VlSW5mbxI2ChhjaGFuZ2VkX3NjcmlwdF9pbmZvX2xpc3QYBSADKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "FC5IZWFydERpYWxTY3JpcHRJbmZvEi0KDXVubG9ja19zdGF0dXMYCiABKA4y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "Fi5IZWFydERpYWxVbmxvY2tTdGF0dXMSIQoLT09HSkFLSVBGREoYCyADKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "DC5QSUNJTElJRktCRUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[4]
		{
			HeartDialDialogueInfoReflection.Descriptor,
			HeartDialScriptInfoReflection.Descriptor,
			HeartDialUnlockStatusReflection.Descriptor,
			PICILIIFKBEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeartDialScriptChangeScNotify), HeartDialScriptChangeScNotify.Parser, new string[4] { "ChangedDialogueInfoList", "ChangedScriptInfoList", "UnlockStatus", "OOGJAKIPFDJ" }, null, null, null, null)
		}));
	}
}
