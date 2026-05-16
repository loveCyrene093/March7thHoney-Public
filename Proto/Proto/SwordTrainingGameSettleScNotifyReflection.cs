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
		buffer[0] = "CiVTd29yZFRyYWluaW5nR2FtZVNldHRsZVNjTm90aWZ5LnByb3RvGg5JdGVt";
		buffer[1] = "TGlzdC5wcm90bxoRTkNDTEpCQ0hCQlAucHJvdG8i3wEKH1N3b3JkVHJhaW5p";
		buffer[2] = "bmdHYW1lU2V0dGxlU2NOb3RpZnkSGgoSZ2FtZV9zdG9yeV9saW5lX2lkGAMg";
		buffer[3] = "ASgNEhMKC0ZIS0lOQUtHQkJLGAUgASgNEhMKC05DUEtQSE1PSElNGAYgASgN";
		buffer[4] = "EhMKC0xES0dKQkFMR0tDGAggASgNEhMKC1BHQUhGQkFKQVBGGAkgAygNEhMK";
		buffer[5] = "C0xFR0xPSU1OUEVDGAsgAygNEhwKBnJlYXNvbhgNIAEoDjIMLk5DQ0xKQkNI";
		buffer[6] = "QkJQEhkKBnJld2FyZBgOIAEoCzIJLkl0ZW1MaXN0QhaqAhNNYXJjaDd0aEhv";
		buffer[7] = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			NCCLJBCHBBPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingGameSettleScNotify), SwordTrainingGameSettleScNotify.Parser, new string[8] { "GameStoryLineId", "FHKINAKGBBK", "NCPKPHMOHIM", "LDKGJBALGKC", "PGAHFBAJAPF", "LEGLOIMNPEC", "Reason", "Reward" }, null, null, null, null)
		}));
	}
}
