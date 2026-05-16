using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LogisticsInfoScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LogisticsInfoScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtMb2dpc3RpY3NJbmZvU2NOb3RpZnkucHJvdG8aEUdFT0FBQU9BUEdLLnBy" + "b3RvIjoKFUxvZ2lzdGljc0luZm9TY05vdGlmeRIhCgtIQk1KSUdHQkZLUBgP" + "IAEoCzIMLkdFT0FBQU9BUEdLQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[1] { GEOAAAOAPGKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LogisticsInfoScNotify), LogisticsInfoScNotify.Parser, new string[1] { "HBMJIGGBFKP" }, null, null, null, null)
		}));
	}
}
