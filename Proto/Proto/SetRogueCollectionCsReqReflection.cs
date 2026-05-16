using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetRogueCollectionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetRogueCollectionCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch1TZXRSb2d1ZUNvbGxlY3Rpb25Dc1JlcS5wcm90bxoRQUdMTkxIT0JES0ku";
		buffer[1] = "cHJvdG8iZgoXU2V0Um9ndWVDb2xsZWN0aW9uQ3NSZXESEwoLSEpOQUFNQkFK";
		buffer[2] = "TUUYASADKA0SIQoLUEZKRkZFRkVCQU4YBSADKA4yDC5BR0xOTEhPQkRLSRIT";
		buffer[3] = "CgtCQ0lJSkdHSktIQhgLIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[4] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { AGLNLHOBDKIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetRogueCollectionCsReq), SetRogueCollectionCsReq.Parser, new string[3] { "HJNAAMBAJME", "PFJFFEFEBAN", "BCIIJGGJKHB" }, null, null, null, null)
		}));
	}
}
