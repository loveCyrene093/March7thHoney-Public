using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterSceneScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterSceneScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChVFbnRlclNjZW5lU2NSc3AucHJvdG8aFVNjZW5lSWRlbnRpZmllci5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "byJ5Cg9FbnRlclNjZW5lU2NSc3ASKgoQc2NlbmVfaWRlbnRpZmllchgCIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "CzIQLlNjZW5lSWRlbnRpZmllchIPCgdyZXRjb2RlGAogASgNEhQKDGlzX2Ns";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "b3NlX21hcBgNIAEoCBITCgtpc19vdmVyX21hcBgOIAEoCEIWqgITTWFyY2g3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { SceneIdentifierReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterSceneScRsp), EnterSceneScRsp.Parser, new string[4] { "SceneIdentifier", "Retcode", "IsCloseMap", "IsOverMap" }, null, null, null, null)
		}));
	}
}
