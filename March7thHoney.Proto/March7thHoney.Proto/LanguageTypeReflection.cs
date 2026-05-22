using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LanguageTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LanguageTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChJMYW5ndWFnZVR5cGUucHJvdG8q/gEKDExhbmd1YWdlVHlwZRIRCg1MQU5H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "VUFHRV9OT05FEAASDwoLTEFOR1VBR0VfU0MQARIPCgtMQU5HVUFHRV9UQxAC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "Eg8KC0xBTkdVQUdFX0VOEAMSDwoLTEFOR1VBR0VfS1IQBBIPCgtMQU5HVUFH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "RV9KUBAFEg8KC0xBTkdVQUdFX0ZSEAYSDwoLTEFOR1VBR0VfREUQBxIPCgtM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "QU5HVUFHRV9FUxAIEg8KC0xBTkdVQUdFX1BUEAkSDwoLTEFOR1VBR0VfUlUQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "ChIPCgtMQU5HVUFHRV9USBALEg8KC0xBTkdVQUdFX1ZJEAwSDwoLTEFOR1VB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "R0VfSUQQDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(LanguageType) }, null, null));
	}
}
