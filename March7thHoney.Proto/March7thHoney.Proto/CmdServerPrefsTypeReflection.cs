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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChhDbWRTZXJ2ZXJQcmVmc1R5cGUucHJvdG8q1gEKEkNtZFNlcnZlclByZWZz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "VHlwZRIbChdCRUdLRUpGSEdNR19QQ1BESEVMUEtFTRAAEhMKDkNtZExLTkRJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "SkpFTEtOELMwEhMKDkNtZEFMSEhPTktDTE5KEN4vEhMKDkNtZEpGQ0FLTUlE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "UElBEOYvEiIKHUNtZFVwZGF0ZVNlcnZlclByZWZzRGF0YUNzUmVxEOIvEiIK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "HUNtZEdldEFsbFNlcnZlclByZWZzRGF0YUNzUmVxEK8wEhwKF0JFR0tFSkZI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "R01HX0tORENMQ05HSURPELIwQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdServerPrefsType) }, null, null));
	}
}
