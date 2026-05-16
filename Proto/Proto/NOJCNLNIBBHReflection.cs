using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NOJCNLNIBBHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NOJCNLNIBBHReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFOT0pDTkxOSUJCSC5wcm90byKKAQoLTk9KQ05MTklCQkgSEwoLTEJFSUhJ";
		buffer[1] = "TEhPS00YBSABKA0SEgoKaXRlbV92YWx1ZRgJIAEoDRITCgtCS0lMRUxCSUxC";
		buffer[2] = "TxgMIAEoDRITCgtOT05LSEVNTEROTxgNIAEoDRITCgtJT0pMTU9DUEFQRxgO";
		buffer[3] = "IAEoCBITCgtETUJHRkxBRE5IQRgPIAEoCEIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[4] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NOJCNLNIBBH), NOJCNLNIBBH.Parser, new string[6] { "LBEIHILHOKM", "ItemValue", "BKILELBILBO", "NONKHEMLDNO", "IOJLMOCPAPG", "DMBGFLADNHA" }, null, null, null, null)
		}));
	}
}
