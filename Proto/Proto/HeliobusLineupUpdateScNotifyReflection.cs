using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusLineupUpdateScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusLineupUpdateScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJIZWxpb2J1c0xpbmV1cFVwZGF0ZVNjTm90aWZ5LnByb3RvGh1IZWxpb2J1" + "c0NoYWxsZW5nZUxpbmV1cC5wcm90byJIChxIZWxpb2J1c0xpbmV1cFVwZGF0" + "ZVNjTm90aWZ5EigKBmxpbmV1cBgBIAEoCzIYLkhlbGlvYnVzQ2hhbGxlbmdl" + "TGluZXVwQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { HeliobusChallengeLineupReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusLineupUpdateScNotify), HeliobusLineupUpdateScNotify.Parser, new string[1] { "Lineup" }, null, null, null, null)
		}));
	}
}
