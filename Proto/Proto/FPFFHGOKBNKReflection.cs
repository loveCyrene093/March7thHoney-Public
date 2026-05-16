using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FPFFHGOKBNKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FPFFHGOKBNKReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFGUEZGSEdPS0JOSy5wcm90bxodQmF0dGxlQXZhdGFyU2VydmFudEluZm8u";
		buffer[1] = "cHJvdG8iZgoLRlBGRkhHT0tCTksSLQoLRUtESENDRUZKR0EYASADKAsyGC5C";
		buffer[2] = "YXR0bGVBdmF0YXJTZXJ2YW50SW5mbxITCgtKUEtETkNQRUxETRgCIAEoDRIT";
		buffer[3] = "CgtQSEpDREhLRk5QShgDIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[4] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BattleAvatarServantInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FPFFHGOKBNK), FPFFHGOKBNK.Parser, new string[3] { "EKDHCCEFJGA", "JPKDNCPELDM", "PHJCDHKFNPJ" }, null, null, null, null)
		}));
	}
}
