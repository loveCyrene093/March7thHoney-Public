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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChtTdG9yeUxpbmVJbmZvU2NOb3RpZnkucHJvdG8ijAEKFVN0b3J5TGluZUlu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Zm9TY05vdGlmeRIcChR0cmlhbF9hdmF0YXJfaWRfbGlzdBgBIAMoDRITCgtK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "QkJKQkdHTkFMRRgCIAEoDRIZChFjdXJfc3RvcnlfbGluZV9pZBgJIAEoDRIl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Ch11bmZpbmlzaGVkX3N0b3J5X2xpbmVfaWRfbGlzdBgLIAMoDUIWqgITTWFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StoryLineInfoScNotify), StoryLineInfoScNotify.Parser, new string[4] { "TrialAvatarIdList", "JBBJBGGNALE", "CurStoryLineId", "UnfinishedStoryLineIdList" }, null, null, null, null)
		}));
	}
}
