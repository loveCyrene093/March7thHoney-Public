using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EquipSkillCoreScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EquipSkillCoreScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChlFcXVpcFNraWxsQ29yZVNjUnNwLnByb3RvGhFKQkpJS0pHRUJBSC5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "bxoRS05IS0JIQURKR0UucHJvdG8ibAoTRXF1aXBTa2lsbENvcmVTY1JzcBIh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "CgtIS09ISUhDQkdBQRgBIAEoCzIMLktOSEtCSEFESkdFEiEKC0dDTkRPSU1B";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Q0FOGAsgASgLMgwuSkJKSUtKR0VCQUgSDwoHcmV0Y29kZRgOIAEoDUIWqgIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			JBJIKJGEBAHReflection.Descriptor,
			KNHKBHADJGEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EquipSkillCoreScRsp), EquipSkillCoreScRsp.Parser, new string[3] { "HKOHIHCBGAA", "GCNDOIMACAN", "Retcode" }, null, null, null, null)
		}));
	}
}
