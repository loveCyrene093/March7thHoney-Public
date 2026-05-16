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
		buffer[0] = "ChVFbnRlclNjZW5lU2NSc3AucHJvdG8aFVNjZW5lSWRlbnRpZmllci5wcm90";
		buffer[1] = "byJ5Cg9FbnRlclNjZW5lU2NSc3ASKgoQc2NlbmVfaWRlbnRpZmllchgCIAEo";
		buffer[2] = "CzIQLlNjZW5lSWRlbnRpZmllchIPCgdyZXRjb2RlGAogASgNEhQKDGlzX2Ns";
		buffer[3] = "b3NlX21hcBgNIAEoCBITCgtpc19vdmVyX21hcBgOIAEoCEIWqgITTWFyY2g3";
		buffer[4] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SceneIdentifierReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterSceneScRsp), EnterSceneScRsp.Parser, new string[4] { "SceneIdentifier", "Retcode", "IsCloseMap", "IsOverMap" }, null, null, null, null)
		}));
	}
}
