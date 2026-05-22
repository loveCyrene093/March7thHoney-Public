using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ExchangeStaminaCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ExchangeStaminaCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpFeGNoYW5nZVN0YW1pbmFDc1JlcS5wcm90byIWChRFeGNoYW5nZVN0YW1p" + "bmFDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ExchangeStaminaCsReq), ExchangeStaminaCsReq.Parser, null, null, null, null, null)
		}));
	}
}
