using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdServerPrefsTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdServerPrefsTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChhDbWRTZXJ2ZXJQcmVmc1R5cGUucHJvdG8q1gEKEkNtZFNlcnZlclByZWZz";
		buffer[1] = "VHlwZRIbChdCRUdLRUpGSEdNR19QQ1BESEVMUEtFTRAAEhMKDkNtZExLTkRJ";
		buffer[2] = "SkpFTEtOELMwEhMKDkNtZEFMSEhPTktDTE5KEN4vEhMKDkNtZEpGQ0FLTUlE";
		buffer[3] = "UElBEOYvEiIKHUNtZFVwZGF0ZVNlcnZlclByZWZzRGF0YUNzUmVxEOIvEiIK";
		buffer[4] = "HUNtZEdldEFsbFNlcnZlclByZWZzRGF0YUNzUmVxEK8wEhwKF0JFR0tFSkZI";
		buffer[5] = "R01HX0tORENMQ05HSURPELIwQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[6] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdServerPrefsType) }, null, null));
	}
}
