using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetShopDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetShopDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZHZXRTaG9wRGF0YVNjUnNwLnByb3RvGhFJR0ZIRkJBRkRETy5wcm90byJG" + "ChBHZXRTaG9wRGF0YVNjUnNwEiEKC09DRVBGT0lITEJIGAsgAygLMgwuSUdG" + "SEZCQUZERE8SDwoHcmV0Y29kZRgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[1] { IGFHFBAFDDOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetShopDataScRsp), GetShopDataScRsp.Parser, new string[2] { "OCEPFOIHLBH", "Retcode" }, null, null, null, null)
		}));
	}
}
