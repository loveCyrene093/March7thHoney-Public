using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GPPGPMEDJEFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GPPGPMEDJEFReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFHUFBHUE1FREpFRi5wcm90bxoRQkZQSUJJRUdKR0oucHJvdG8aDkl0ZW1M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "aXN0LnByb3RvImUKC0dQUEdQTUVESkVGEhMKC0pGSlBERVBPRk1PGAEgAygN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EiEKC0tHRUJKTkhPTENOGAIgASgOMgwuQkZQSUJJRUdKR0oSHgoLRk5MREZH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "TEdFT0EYCCABKAsyCS5JdGVtTGlzdEIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			BFPIBIEGJGJReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GPPGPMEDJEF), GPPGPMEDJEF.Parser, new string[3] { "JFJPDEPOFMO", "KGEBJNHOLCN", "FNLDFGLGEOA" }, null, null, null, null)
		}));
	}
}
