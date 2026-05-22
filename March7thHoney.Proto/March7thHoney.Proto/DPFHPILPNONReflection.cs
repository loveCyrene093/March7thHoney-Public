using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DPFHPILPNONReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DPFHPILPNONReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFEUEZIUElMUE5PTi5wcm90byqBAQoLRFBGSFBJTFBOT04SGwoXRFBGSFBJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "TFBOT05fRUlGRVBPTUhFS0oQABIbChdEUEZIUElMUE5PTl9DSUZBR0hITUxL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "SRABEhsKF0RQRkhQSUxQTk9OX1BKTkFCSExOTEVOEAISGwoXRFBGSFBJTFBO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "T05fQUtOTFBLSUxFTEoQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(DPFHPILPNON) }, null, null));
	}
}
