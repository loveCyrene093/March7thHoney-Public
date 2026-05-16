using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetDiceCombatSystemDataReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetDiceCombatSystemDataReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBHZXREaWNlQ29tYmF0U3lzdGVtRGF0YVJlcS5wcm90byIcChpHZXREaWNl" + "Q29tYmF0U3lzdGVtRGF0YVJlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetDiceCombatSystemDataReq), GetDiceCombatSystemDataReq.Parser, null, null, null, null, null)
		}));
	}
}
