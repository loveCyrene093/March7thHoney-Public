using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HHHMMJBGCNGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HHHMMJBGCNGReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFISEhNTUpCR0NORy5wcm90byKUAQoLSEhITU1KQkdDTkcSFAoMdG90YWxf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "ZGFtYWdlGAUgASgBEg8KB3JvbGVfaWQYByABKA0SIQoZZ3JpZF9maWdodF9l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "cXVpcG1lbnRfbGlzdBgIIAMoDRIRCglyb2xlX3N0YXIYDCABKA0SEwoLTERN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "TkJESURGQ0MYDSABKAgSEwoLSE5MRURCUEdEQkMYDyABKAhCFqoCE01hcmNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HHHMMJBGCNG), HHHMMJBGCNG.Parser, new string[6] { "TotalDamage", "RoleId", "GridFightEquipmentList", "RoleStar", "LDMNBDIDFCC", "HNLEDBPGDBC" }, null, null, null, null)
		}));
	}
}
