using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MFMEMDJKDAFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MFMEMDJKDAFReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFNRk1FTURKS0RBRi5wcm90bxoRQUNGSUdGSUlMT0oucHJvdG8aEURHTUxB";
		buffer[1] = "QUlIQkZDLnByb3RvIn0KC01GTUVNREpLREFGEhMKC0VHQ09HUEFDSk9EGAQg";
		buffer[2] = "AygNEhMKC0VQTUZER1BLUEhKGAYgAygNEiEKC0RDRkdPRk5CTENNGAogASgL";
		buffer[3] = "MgwuREdNTEFBSUhCRkMSIQoLRktPRUJNQURKRUsYDSABKAsyDC5BQ0ZJR0ZJ";
		buffer[4] = "SUxPSkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ACFIGFIILOJReflection.Descriptor,
			DGMLAAIHBFCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MFMEMDJKDAF), MFMEMDJKDAF.Parser, new string[4] { "EGCOGPACJOD", "EPMFDGPKPHJ", "DCFGOFNBLCM", "FKOEBMADJEK" }, null, null, null, null)
		}));
	}
}
