using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdPhoneTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdPhoneTypeReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 0) = "ChJDbWRQaG9uZVR5cGUucHJvdG8q/gIKDENtZFBob25lVHlwZRIbChdET0dN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 1) = "UEFBSk5DRl9QQ1BESEVMUEtFTRAAEh0KGENtZFNlbGVjdFBob25lVGhlbWVD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 2) = "c1JlcRD+JxIZChRDbWRHZXRQaG9uZURhdGFTY1JzcBD2JxIgChtDbWRVbmxv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 3) = "Y2tDaGF0QnViYmxlU2NOb3RpZnkQ+icSHAoXQ21kU2VsZWN0UGhvbmVDYXNl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 4) = "U2NSc3AQhigSIAobQ21kVW5sb2NrUGhvbmVUaGVtZVNjTm90aWZ5EM4oEh0K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 5) = "GENtZFNlbGVjdENoYXRCdWJibGVDc1JlcRDKKBIfChpDbWRVbmxvY2tQaG9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 6) = "ZUNhc2VTY05vdGlmeRCTKBIZChRDbWRHZXRQaG9uZURhdGFDc1JlcRDHKBIc";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 7) = "ChdDbWRTZWxlY3RQaG9uZUNhc2VDc1JlcRCrKBIdChhDbWRTZWxlY3RDaGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 8) = "QnViYmxlU2NSc3AQyygSHQoYQ21kU2VsZWN0UGhvbmVUaGVtZVNjUnNwEPUn";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 9) = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray10<string>, string>(in buffer, 10))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdPhoneType) }, null, null));
	}
}
