using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ExchangeHcoinCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ExchangeHcoinCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhFeGNoYW5nZUhjb2luQ3NSZXEucHJvdG8iIQoSRXhjaGFuZ2VIY29pbkNz" + "UmVxEgsKA251bRgEIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ExchangeHcoinCsReq), ExchangeHcoinCsReq.Parser, new string[1] { "Num" }, null, null, null, null)
		}));
	}
}
