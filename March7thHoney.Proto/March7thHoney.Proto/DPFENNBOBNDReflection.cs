using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DPFENNBOBNDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DPFENNBOBNDReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFEUEZFTk5CT0JORC5wcm90bxoRR05BTk1FQURQQkQucHJvdG8aDkl0ZW1M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "aXN0LnByb3RvInEKC0RQRkVOTkJPQk5EEhkKBnJld2FyZBgGIAEoCzIJLkl0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ZW1MaXN0EiEKC0VGSkJGQkVOR0tHGAkgASgLMgwuR05BTk1FQURQQkQSDwoH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "cmV0Y29kZRgLIAEoDRITCgtCTEtBQ0dCREFIQhgOIAMoDUIWqgITTWFyY2g3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			GNANMEADPBDReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DPFENNBOBND), DPFENNBOBND.Parser, new string[4] { "Reward", "EFJBFBENGKG", "Retcode", "BLKACGBDAHB" }, null, null, null, null)
		}));
	}
}
