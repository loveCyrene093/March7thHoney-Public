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
		buffer[0] = "ChhDaGFsbGVuZ2VQZWFrQnVpbGQucHJvdG8aEEVxdWlwUmVsaWMucHJvdG8i";
		buffer[1] = "jwEKEkNoYWxsZW5nZVBlYWtCdWlsZBIbChNlcXVpcG1lbnRfdW5pcXVlX2lk";
		buffer[2] = "GAQgASgNEh8KCnJlbGljX2xpc3QYBSADKAsyCy5FcXVpcFJlbGljEhMKC2F2";
		buffer[3] = "YXRhcl90eXBlGAYgASgNEhMKC0NCSEtGT0VPTUZGGAwgASgNEhEKCWF2YXRh";
		buffer[4] = "cl9pZBgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { EquipRelicReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengePeakBuild), ChallengePeakBuild.Parser, new string[5] { "EquipmentUniqueId", "RelicList", "AvatarType", "CBHKFOEOMFF", "AvatarId" }, null, null, null, null)
		}));
	}
}
