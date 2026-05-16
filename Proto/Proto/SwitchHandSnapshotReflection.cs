using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwitchHandSnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwitchHandSnapshotReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTd2l0Y2hIYW5kU25hcHNob3QucHJvdG8aIFN3aXRjaEhhbmREYXRhTm9k" + "ZVNuYXBzaG90LnByb3RvIksKElN3aXRjaEhhbmRTbmFwc2hvdBI1ChBzd2l0" + "Y2hfaGFuZF9saXN0GAEgAygLMhsuU3dpdGNoSGFuZERhdGFOb2RlU25hcHNo" + "b3RCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { SwitchHandDataNodeSnapshotReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwitchHandSnapshot), SwitchHandSnapshot.Parser, new string[1] { "SwitchHandList" }, null, null, null, null)
		}));
	}
}
