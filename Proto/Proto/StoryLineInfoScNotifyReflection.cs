using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StoryLineInfoScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StoryLineInfoScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChtTdG9yeUxpbmVJbmZvU2NOb3RpZnkucHJvdG8ijAEKFVN0b3J5TGluZUlu";
		buffer[1] = "Zm9TY05vdGlmeRIcChR0cmlhbF9hdmF0YXJfaWRfbGlzdBgBIAMoDRITCgtK";
		buffer[2] = "QkJKQkdHTkFMRRgCIAEoDRIZChFjdXJfc3RvcnlfbGluZV9pZBgJIAEoDRIl";
		buffer[3] = "Ch11bmZpbmlzaGVkX3N0b3J5X2xpbmVfaWRfbGlzdBgLIAMoDUIWqgITTWFy";
		buffer[4] = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StoryLineInfoScNotify), StoryLineInfoScNotify.Parser, new string[4] { "TrialAvatarIdList", "JBBJBGGNALE", "CurStoryLineId", "UnfinishedStoryLineIdList" }, null, null, null, null)
		}));
	}
}
