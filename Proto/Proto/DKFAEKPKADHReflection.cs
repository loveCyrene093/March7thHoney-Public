using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DKFAEKPKADHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DKFAEKPKADHReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFES0ZBRUtQS0FESC5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvGhFKQkRH";
		buffer[1] = "SFBDQkhQTy5wcm90byK9AQoLREtGQUVLUEtBREgSIQoLTU5KTkZNS0lLTUgY";
		buffer[2] = "ASADKAsyDC5KQkRHSFBDQkhQTxITCgtCRk5MQ0ZNRERKSBgEIAEoDRITCgtE";
		buffer[3] = "S0hMTEdPSUhLSBgGIAEoDRITCgtGR0FBUENOTk1JUBgMIAEoDRITCgtNRUFK";
		buffer[4] = "QUVCREFPSRgNIAEoDRIiCgtPTE5PSUlFREtFUBgOIAEoCzINLkl0ZW1Db3N0";
		buffer[5] = "RGF0YRITCgtBRkhCTktPSEhIQhgPIAEoCEIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[6] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ItemCostDataReflection.Descriptor,
			JBDGHPCBHPOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DKFAEKPKADH), DKFAEKPKADH.Parser, new string[7] { "MNJNFMKIKMH", "BFNLCFMDDJH", "DKHLLGOIHKH", "FGAAPCNNMIP", "MEAJAEBDAOI", "OLNOIIEDKEP", "AFHBNKOHHHB" }, null, null, null, null)
		}));
	}
}
