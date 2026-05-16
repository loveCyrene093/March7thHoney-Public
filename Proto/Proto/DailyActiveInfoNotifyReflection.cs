using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DailyActiveInfoNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DailyActiveInfoNotifyReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChtEYWlseUFjdGl2ZUluZm9Ob3RpZnkucHJvdG8aF0RhaWx5QWN0aXZpdHlJ";
		buffer[1] = "bmZvLnByb3RvIowBChVEYWlseUFjdGl2ZUluZm9Ob3RpZnkSGgoSZGFpbHlf";
		buffer[2] = "YWN0aXZlX3BvaW50GAIgASgNEjMKF2RhaWx5X2FjdGl2ZV9sZXZlbF9saXN0";
		buffer[3] = "GAkgAygLMhIuRGFpbHlBY3Rpdml0eUluZm8SIgoaZGFpbHlfYWN0aXZlX3F1";
		buffer[4] = "ZXN0X2lkX2xpc3QYDCADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[5] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { DailyActivityInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DailyActiveInfoNotify), DailyActiveInfoNotify.Parser, new string[3] { "DailyActivePoint", "DailyActiveLevelList", "DailyActiveQuestIdList" }, null, null, null, null)
		}));
	}
}
