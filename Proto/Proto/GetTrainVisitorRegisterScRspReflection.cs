using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetTrainVisitorRegisterScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetTrainVisitorRegisterScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiJHZXRUcmFpblZpc2l0b3JSZWdpc3RlclNjUnNwLnByb3RvGhFISElBT0FO";
		buffer[1] = "REdBTC5wcm90byJnChxHZXRUcmFpblZpc2l0b3JSZWdpc3RlclNjUnNwEg8K";
		buffer[2] = "B3JldGNvZGUYCyABKA0SIQoLTExEQUZLSEZFQ0EYDCADKAsyDC5ISElBT0FO";
		buffer[3] = "REdBTBITCgtHTEJQTEpQUEpQQRgNIAMoDUIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[4] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { HHIAOANDGALReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetTrainVisitorRegisterScRsp), GetTrainVisitorRegisterScRsp.Parser, new string[3] { "Retcode", "LLDAFKHFECA", "GLBPLJPPJPA" }, null, null, null, null)
		}));
	}
}
