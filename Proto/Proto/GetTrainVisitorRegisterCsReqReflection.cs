using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetTrainVisitorRegisterCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetTrainVisitorRegisterCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJHZXRUcmFpblZpc2l0b3JSZWdpc3RlckNzUmVxLnByb3RvGhFCR01LQ0FG" + "RU9ISi5wcm90byI6ChxHZXRUcmFpblZpc2l0b3JSZWdpc3RlckNzUmVxEhoK" + "BHR5cGUYBiABKA4yDC5CR01LQ0FGRU9ISkIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[1] { BGMKCAFEOHJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetTrainVisitorRegisterCsReq), GetTrainVisitorRegisterCsReq.Parser, new string[1] { "Type" }, null, null, null, null)
		}));
	}
}
