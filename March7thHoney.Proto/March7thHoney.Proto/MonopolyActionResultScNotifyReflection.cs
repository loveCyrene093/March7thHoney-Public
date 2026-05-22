using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyActionResultScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyActionResultScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJNb25vcG9seUFjdGlvblJlc3VsdFNjTm90aWZ5LnByb3RvGhpNb25vcG9s" + "eUFjdGlvblJlc3VsdC5wcm90byJKChxNb25vcG9seUFjdGlvblJlc3VsdFNj" + "Tm90aWZ5EioKC01NQUFITUVDR09FGAUgAygLMhUuTW9ub3BvbHlBY3Rpb25S" + "ZXN1bHRCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { MonopolyActionResultReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyActionResultScNotify), MonopolyActionResultScNotify.Parser, new string[1] { "MMAAHMECGOE" }, null, null, null, null)
		}));
	}
}
