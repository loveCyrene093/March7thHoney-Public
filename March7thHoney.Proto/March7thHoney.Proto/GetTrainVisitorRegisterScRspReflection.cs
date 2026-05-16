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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiJHZXRUcmFpblZpc2l0b3JSZWdpc3RlclNjUnNwLnByb3RvGhFISElBT0FO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "REdBTC5wcm90byJnChxHZXRUcmFpblZpc2l0b3JSZWdpc3RlclNjUnNwEg8K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "B3JldGNvZGUYCyABKA0SIQoLTExEQUZLSEZFQ0EYDCADKAsyDC5ISElBT0FO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "REdBTBITCgtHTEJQTEpQUEpQQRgNIAMoDUIWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { HHIAOANDGALReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetTrainVisitorRegisterScRsp), GetTrainVisitorRegisterScRsp.Parser, new string[3] { "Retcode", "LLDAFKHFECA", "GLBPLJPPJPA" }, null, null, null, null)
		}));
	}
}
