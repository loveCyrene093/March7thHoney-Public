using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncRogueCommonPendingActionScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncRogueCommonPendingActionScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CipTeW5jUm9ndWVDb21tb25QZW5kaW5nQWN0aW9uU2NOb3RpZnkucHJvdG8a";
		buffer[1] = "EUVQUEpITklIQUZMLnByb3RvIlkKJFN5bmNSb2d1ZUNvbW1vblBlbmRpbmdB";
		buffer[2] = "Y3Rpb25TY05vdGlmeRITCgtMT0lET0dFRU5PQhgBIAEoDRIcCgZhY3Rpb24Y";
		buffer[3] = "DyABKAsyDC5FUFBKSE5JSEFGTEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[4] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { EPPJHNIHAFLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncRogueCommonPendingActionScNotify), SyncRogueCommonPendingActionScNotify.Parser, new string[2] { "LOIDOGEENOB", "Action" }, null, null, null, null)
		}));
	}
}
