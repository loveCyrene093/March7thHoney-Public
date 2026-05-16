using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IOLJBGLNLCJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IOLJBGLNLCJReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFJT0xKQkdMTkxDSi5wcm90bxoRRE9HR0lETklOSlAucHJvdG8aEUtISEhG";
		buffer[1] = "SEVPREVELnByb3RvIn0KC0lPTEpCR0xOTENKEhMKC0xPTENCRkNKUEFNGAMg";
		buffer[2] = "ASgNEhMKC0hFT0xHRVBHSUhMGAYgASgIEiEKC0JJQ1BOS09DSEdOGAcgAygL";
		buffer[3] = "MgwuS0hISEZIRU9ERUQSIQoLRUJLREpITEZPR04YDCADKAsyDC5ET0dHSURO";
		buffer[4] = "SU5KUEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			DOGGIDNINJPReflection.Descriptor,
			KHHHFHEODEDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IOLJBGLNLCJ), IOLJBGLNLCJ.Parser, new string[4] { "LOLCBFCJPAM", "HEOLGEPGIHL", "BICPNKOCHGN", "EBKDJHLFOGN" }, null, null, null, null)
		}));
	}
}
