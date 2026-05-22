using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingGameSettleScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingGameSettleScNotifyReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "CiVTd29yZFRyYWluaW5nR2FtZVNldHRsZVNjTm90aWZ5LnByb3RvGg5JdGVt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "TGlzdC5wcm90bxoRTkNDTEpCQ0hCQlAucHJvdG8i3wEKH1N3b3JkVHJhaW5p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "bmdHYW1lU2V0dGxlU2NOb3RpZnkSGgoSZ2FtZV9zdG9yeV9saW5lX2lkGAMg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "ASgNEhMKC0ZIS0lOQUtHQkJLGAUgASgNEhMKC05DUEtQSE1PSElNGAYgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "EhMKC0xES0dKQkFMR0tDGAggASgNEhMKC1BHQUhGQkFKQVBGGAkgAygNEhMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "C0xFR0xPSU1OUEVDGAsgAygNEhwKBnJlYXNvbhgNIAEoDjIMLk5DQ0xKQkNI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "QkJQEhkKBnJld2FyZBgOIAEoCzIJLkl0ZW1MaXN0QhaqAhNNYXJjaDd0aEhv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			NCCLJBCHBBPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingGameSettleScNotify), SwordTrainingGameSettleScNotify.Parser, new string[8] { "GameStoryLineId", "FHKINAKGBBK", "NCPKPHMOHIM", "LDKGJBALGKC", "PGAHFBAJAPF", "LEGLOIMNPEC", "Reason", "Reward" }, null, null, null, null)
		}));
	}
}
