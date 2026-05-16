using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMatchPlayDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMatchPlayDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRNYXRjaFBsYXlEYXRhQ3NSZXEucHJvdG8aE0ZpZ2h0R2FtZU1vZGUu" + "cHJvdG8iPAoVR2V0TWF0Y2hQbGF5RGF0YUNzUmVxEiMKC0JGQkpLQUFMRkhE" + "GAggAygOMg4uRmlnaHRHYW1lTW9kZUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[1] { FightGameModeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMatchPlayDataCsReq), GetMatchPlayDataCsReq.Parser, new string[1] { "BFBJKAALFHD" }, null, null, null, null)
		}));
	}
}
