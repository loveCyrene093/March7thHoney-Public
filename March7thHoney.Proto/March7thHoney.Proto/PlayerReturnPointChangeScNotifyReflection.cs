using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerReturnPointChangeScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerReturnPointChangeScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVQbGF5ZXJSZXR1cm5Qb2ludENoYW5nZVNjTm90aWZ5LnByb3RvIjYKH1Bs" + "YXllclJldHVyblBvaW50Q2hhbmdlU2NOb3RpZnkSEwoLTENEQUxFRUVESkoY" + "CyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerReturnPointChangeScNotify), PlayerReturnPointChangeScNotify.Parser, new string[1] { "LCDALEEEDJJ" }, null, null, null, null)
		}));
	}
}
