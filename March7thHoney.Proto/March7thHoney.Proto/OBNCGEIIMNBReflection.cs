using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OBNCGEIIMNBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OBNCGEIIMNBReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFPQk5DR0VJSU1OQi5wcm90bxoRTUxJQkxIRkJBRkoucHJvdG8aEU9CUE1Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "UENGTkxKLnByb3RvImgKC09CTkNHRUlJTU5CEiEKC0FQSEpJQUZPREhKGAUg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "AygLMgwuT0JQTVBQQ0ZOTEoSIQoLRlBIR0hBUEdOQUUYBiABKA4yDC5NTElC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "TEhGQkFGShITCgtETUhMTEtCTUhFTBgHIAEoBEIWqgITTWFyY2g3dGhIb25l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			MLIBLHFBAFJReflection.Descriptor,
			OBPMPPCFNLJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OBNCGEIIMNB), OBNCGEIIMNB.Parser, new string[3] { "APHJIAFODHJ", "FPHGHAPGNAE", "DMHLLKBMHEL" }, null, null, null, null)
		}));
	}
}
