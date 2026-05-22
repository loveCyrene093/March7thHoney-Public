using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LOCEJAIMMGGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LOCEJAIMMGGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMT0NFSkFJTU1HRy5wcm90byI8CgtMT0NFSkFJTU1HRxIKCgJpZBgHIAEo" + "DRITCgtFQklBT05OTEZHTRgMIAEoDRIMCgR0aW1lGA8gASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LOCEJAIMMGG), LOCEJAIMMGG.Parser, new string[3] { "Id", "EBIAONNLFGM", "Time" }, null, null, null, null)
		}));
	}
}
