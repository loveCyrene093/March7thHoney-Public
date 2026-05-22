using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GCDMHAMCDHIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GCDMHAMCDHIReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFHQ0RNSEFNQ0RISS5wcm90byq7AQoLR0NETUhBTUNESEkSGwoXR0NETUhB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "TUNESElfR0NHTUNQTVBKSEQQABIbChdHQ0RNSEFNQ0RISV9FTEtGTkxMUEhQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "QhABEhsKF0dDRE1IQU1DREhJX0VEQUpPREZOTEZIEAISGwoXR0NETUhBTUNE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "SElfR0JITU5JTUJCTkcQAxIbChdHQ0RNSEFNQ0RISV9BSEhCRkxKS0dGSxAE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "EhsKF0dDRE1IQU1DREhJX0VBQUNCSUFHTEhQEAVCFqoCE01hcmNoN3RoSG9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GCDMHAMCDHI) }, null, null));
	}
}
