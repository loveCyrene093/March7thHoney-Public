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
		buffer[0] = "CiNIZWFydERpYWxTY3JpcHRDaGFuZ2VTY05vdGlmeS5wcm90bxobSGVhcnRE";
		buffer[1] = "aWFsRGlhbG9ndWVJbmZvLnByb3RvGhlIZWFydERpYWxTY3JpcHRJbmZvLnBy";
		buffer[2] = "b3RvGhtIZWFydERpYWxVbmxvY2tTdGF0dXMucHJvdG8aEVBJQ0lMSUlGS0JF";
		buffer[3] = "LnByb3RvIuUBCh1IZWFydERpYWxTY3JpcHRDaGFuZ2VTY05vdGlmeRI6Chpj";
		buffer[4] = "aGFuZ2VkX2RpYWxvZ3VlX2luZm9fbGlzdBgCIAMoCzIWLkhlYXJ0RGlhbERp";
		buffer[5] = "YWxvZ3VlSW5mbxI2ChhjaGFuZ2VkX3NjcmlwdF9pbmZvX2xpc3QYBSADKAsy";
		buffer[6] = "FC5IZWFydERpYWxTY3JpcHRJbmZvEi0KDXVubG9ja19zdGF0dXMYCiABKA4y";
		buffer[7] = "Fi5IZWFydERpYWxVbmxvY2tTdGF0dXMSIQoLT09HSkFLSVBGREoYCyADKAsy";
		buffer[8] = "DC5QSUNJTElJRktCRUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
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
