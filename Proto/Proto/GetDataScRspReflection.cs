using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetDataScRspReflection()
	{
		InlineArray13<string> buffer = default(InlineArray13<string>);
		buffer[0] = "ChJHZXREYXRhU2NSc3AucHJvdG8aEUZIQ0NDSEpISEtMLnByb3RvGhFHSEpJ";
		buffer[1] = "Rk9ISk9FTS5wcm90bxoRTEVITkhETEVNSEwucHJvdG8aEUxIRURKQUlPSE9F";
		buffer[2] = "LnByb3RvIrsDCgxHZXREYXRhU2NSc3ASDwoHcmV0Y29kZRgBIAEoDRITCgtC";
		buffer[3] = "TUdBS0tOQUtGRBgCIAEoDRITCgtOSkRCSUVNQU9BQRgDIAEoDRITCgtHQ0VO";
		buffer[4] = "Sk1QTEhNQxgEIAMoDRITCgtQS0hCQU1JTElPSRgFIAEoDRIhCgtMRUdNT0pM";
		buffer[5] = "REVDSBgGIAEoDjIMLkdISklGT0hKT0VNEiEKC0hNQUJNS0tLSE5CGAcgAygL";
		buffer[6] = "MgwuTEhFREpBSU9IT0USEwoLQkJPSkxJRUFMREIYCCABKA0SEwoLSEZKSkpL";
		buffer[7] = "RUJNRVAYCSABKA0SEwoLQkNMTENCREVQRVAYCiABKA0SHAoGbGluZXVwGAsg";
		buffer[8] = "ASgLMgwuRkhDQ0NISkhIS0wSEwoLSklJQ0pPS0xOTEcYDSABKA0SEwoLRkhI";
		buffer[9] = "TUFDSFBNR0EYDiABKA0SIQoLSUpHQUxDT0ZMTEEYDyADKAsyDC5MRUhOSERM";
		buffer[10] = "RU1ITBIUCgtBQ0pKQ1BDUEZEThjUBCABKA0SFAoLTktCRERJREZQTkUY/wQg";
		buffer[11] = "ASgNEhQKC05DQlBPT0NDQ0FOGJ8HIAEoDRIUCgtQQkFGRkxEQkFMRRjDCiAB";
		buffer[12] = "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			FHCCCHJHHKLReflection.Descriptor,
			GHJIFOHJOEMReflection.Descriptor,
			LEHNHDLEMHLReflection.Descriptor,
			LHEDJAIOHOEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetDataScRsp), GetDataScRsp.Parser, new string[18]
			{
				"Retcode", "BMGAKKNAKFD", "NJDBIEMAOAA", "GCENJMPLHMC", "PKHBAMILIOI", "LEGMOJLDECH", "HMABMKKKHNB", "BBOJLIEALDB", "HFJJJKEBMEP", "BCLLCBDEPEP",
				"Lineup", "JIICJOKLNLG", "FHHMACHPMGA", "IJGALCOFLLA", "ACJJCPCPFDN", "NKBDDIDFPNE", "NCBPOOCCCAN", "PBAFFLDBALE"
			}, null, null, null, null)
		}));
	}
}
