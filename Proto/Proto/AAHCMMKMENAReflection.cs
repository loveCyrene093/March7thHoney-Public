using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AAHCMMKMENAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AAHCMMKMENAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBQUhDTU1LTUVOQS5wcm90bxoWTG9iYnlHYW1lRXh0SW5mby5wcm90byJG" + "CgtBQUhDTU1LTUVOQRIPCgdyZXRjb2RlGAkgASgNEiYKC0pIQ0pNS0RETk5G" + "GAogASgLMhEuTG9iYnlHYW1lRXh0SW5mb0IWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[1] { LobbyGameExtInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AAHCMMKMENA), AAHCMMKMENA.Parser, new string[2] { "Retcode", "JHCJMKDDNNF" }, null, null, null, null)
		}));
	}
}
