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
		buffer[0] = "ChFEUEZFTk5CT0JORC5wcm90bxoRR05BTk1FQURQQkQucHJvdG8aDkl0ZW1M";
		buffer[1] = "aXN0LnByb3RvInEKC0RQRkVOTkJPQk5EEhkKBnJld2FyZBgGIAEoCzIJLkl0";
		buffer[2] = "ZW1MaXN0EiEKC0VGSkJGQkVOR0tHGAkgASgLMgwuR05BTk1FQURQQkQSDwoH";
		buffer[3] = "cmV0Y29kZRgLIAEoDRITCgtCTEtBQ0dCREFIQhgOIAMoDUIWqgITTWFyY2g3";
		buffer[4] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GNANMEADPBDReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DPFENNBOBND), DPFENNBOBND.Parser, new string[4] { "Reward", "EFJBFBENGKG", "Retcode", "BLKACGBDAHB" }, null, null, null, null)
		}));
	}
}
