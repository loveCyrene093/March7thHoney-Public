using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BBKAPDCECDNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BBKAPDCECDNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQktBUERDRUNETi5wcm90bxoRQ0FFQUJISk5MTUkucHJvdG8iWgoLQkJL" + "QVBEQ0VDRE4SIQoLTU1BT09OUEFQRFAYBSABKAsyDC5DQUVBQkhKTkxNSRIT" + "CgtDSk9QRE5BSUVNSxgNIAEoDRITCgtQQkxDTkJNTUJLQxgOIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { CAEABHJNLMIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BBKAPDCECDN), BBKAPDCECDN.Parser, new string[3] { "MMAOONPAPDP", "CJOPDNAIEMK", "PBLCNBMMBKC" }, null, null, null, null)
		}));
	}
}
