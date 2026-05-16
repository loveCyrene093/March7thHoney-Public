using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StatisticEventReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StatisticEventReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChRTdGF0aXN0aWNFdmVudC5wcm90bxoeQmF0dGxlU3RhdGljdGljRXZlbnRU";
		buffer[1] = "eXBlLnByb3RvImUKDlN0YXRpc3RpY0V2ZW50EicKBHR5cGUYASABKA4yGS5C";
		buffer[2] = "YXR0bGVTdGF0aWN0aWNFdmVudFR5cGUSEwoLUElDRUdNQ0NITUUYAiABKA0S";
		buffer[3] = "FQoNZGlzcGxheV92YWx1ZRgDIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[4] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BattleStaticticEventTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StatisticEvent), StatisticEvent.Parser, new string[3] { "Type", "PICEGMCCHME", "DisplayValue" }, null, null, null, null)
		}));
	}
}
