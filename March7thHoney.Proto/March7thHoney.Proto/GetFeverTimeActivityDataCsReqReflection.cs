using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFeverTimeActivityDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFeverTimeActivityDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNHZXRGZXZlclRpbWVBY3Rpdml0eURhdGFDc1JlcS5wcm90byIfCh1HZXRG" + "ZXZlclRpbWVBY3Rpdml0eURhdGFDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFeverTimeActivityDataCsReq), GetFeverTimeActivityDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
