using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetSystemDataRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetSystemDataRspReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChZHZXRTeXN0ZW1EYXRhUnNwLnByb3RvGhFEQUJOQ0VQQktNRy5wcm90bxoW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "RGljZUNvbWJhdEF2YXRhci5wcm90bxoRSU5BQ0VHQUFBTEoucHJvdG8i0AEK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "EEdldFN5c3RlbURhdGFSc3ASEwoLREFNRFBORENBQ0sYAyADKA0SJgoLYXZh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "dGFyX2xpc3QYBiADKAsyES5EaWNlQ29tYmF0QXZhdGFyEg8KB3JldGNvZGUY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "CCABKA0SEwoLRktPQkZQTkdEQ0cYCSADKA0SIQoLRkFNRkNJUExHT04YCyAD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "KAsyDC5JTkFDRUdBQUFMShITCgtKRUJKR0tBQ0JLRBgNIAEoDRIhCgtES0NH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "QUxES0RGQRgOIAEoCzIMLkRBQk5DRVBCS01HQhaqAhNNYXJjaDd0aEhvbmV5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[3]
		{
			DABNCEPBKMGReflection.Descriptor,
			DiceCombatAvatarReflection.Descriptor,
			INACEGAAALJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetSystemDataRsp), GetSystemDataRsp.Parser, new string[7] { "DAMDPNDCACK", "AvatarList", "Retcode", "FKOBFPNGDCG", "FAMFCIPLGON", "JEBJGKACBKD", "DKCGALDKDFA" }, null, null, null, null)
		}));
	}
}
