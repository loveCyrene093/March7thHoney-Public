using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EKGAMNCMOEJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EKGAMNCMOEJReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFFS0dBTU5DTU9FSi5wcm90bxoRT0NMRUpMRUZCRk8ucHJvdG8ifQoLRUtH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "QU1OQ01PRUoSEwoLREZMTUtDSUtGT1AYAyABKAkSDwoHcmV0Y29kZRgGIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "DRIQCghzdGFnZV9pZBgLIAEoDRIhCgtyZXBsYXlfdHlwZRgNIAEoDjIMLk9D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "TEVKTEVGQkZPEhMKC0VGTEFFQU5LQUNNGA4gASgJQhaqAhNNYXJjaDd0aEhv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { OCLEJLEFBFOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EKGAMNCMOEJ), EKGAMNCMOEJ.Parser, new string[5] { "DFLMKCIKFOP", "Retcode", "StageId", "ReplayType", "EFLAEANKACM" }, null, null, null, null)
		}));
	}
}
