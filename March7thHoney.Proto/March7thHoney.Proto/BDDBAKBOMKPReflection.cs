using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BDDBAKBOMKPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BDDBAKBOMKPReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFCRERCQUtCT01LUC5wcm90bxoRRk5PTlBNQk9GTkUucHJvdG8aGkZhdGVN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "YXN0ZXJTdGF0dXNUeXBlLnByb3RvIpQBCgtCRERCQUtCT01LUBIOCgZtYXhf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "aHAYASABKAUSJQoGc3RhdHVzGAIgASgOMhUuRmF0ZU1hc3RlclN0YXR1c1R5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "cGUSEQoJYXZhdGFyX2lkGAQgASgNEiEKC0lBS0ZQTU9FSkxGGAUgAygLMgwu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "Rk5PTlBNQk9GTkUSCgoCaHAYCSABKAUSDAoEcmFuaxgLIAEoDUIWqgITTWFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			FNONPMBOFNEReflection.Descriptor,
			FateMasterStatusTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BDDBAKBOMKP), BDDBAKBOMKP.Parser, new string[6] { "MaxHp", "Status", "AvatarId", "IAKFPMOEJLF", "Hp", "Rank" }, null, null, null, null)
		}));
	}
}
