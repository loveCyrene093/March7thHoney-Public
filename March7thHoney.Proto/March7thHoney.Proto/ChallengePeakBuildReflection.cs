using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengePeakBuildReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengePeakBuildReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChhDaGFsbGVuZ2VQZWFrQnVpbGQucHJvdG8aEEVxdWlwUmVsaWMucHJvdG8i";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "jwEKEkNoYWxsZW5nZVBlYWtCdWlsZBIbChNlcXVpcG1lbnRfdW5pcXVlX2lk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "GAQgASgNEh8KCnJlbGljX2xpc3QYBSADKAsyCy5FcXVpcFJlbGljEhMKC2F2";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "YXRhcl90eXBlGAYgASgNEhMKC0NCSEtGT0VPTUZGGAwgASgNEhEKCWF2YXRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cl9pZBgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { EquipRelicReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengePeakBuild), ChallengePeakBuild.Parser, new string[5] { "EquipmentUniqueId", "RelicList", "AvatarType", "CBHKFOEOMFF", "AvatarId" }, null, null, null, null)
		}));
	}
}
