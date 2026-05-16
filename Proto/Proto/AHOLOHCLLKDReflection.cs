using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AHOLOHCLLKDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AHOLOHCLLKDReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		buffer[0] = "ChFBSE9MT0hDTExLRC5wcm90bxoRQUNDQlBFQUpGRU8ucHJvdG8aEUlPTEpC";
		buffer[1] = "R0xOTENKLnByb3RvGhFLR0FCSkVOQ0ZEQy5wcm90bxoRS0tGQU5HSUpBT0Yu";
		buffer[2] = "cHJvdG8aEU1JQ09NSUJQSU9BLnByb3RvGhFOS0xPQkFLRU1JSS5wcm90bxoR";
		buffer[3] = "T0pBRUVNUEtDQk4ucHJvdG8aEVBHSk5CTkFOREVFLnByb3RvIpgCCgtBSE9M";
		buffer[4] = "T0hDTExLRBIgCgppdGVtX3ZhbHVlGAEgASgLMgwuUEdKTkJOQU5ERUUSIQoL";
		buffer[5] = "RUlFTktKRkZGSkcYAyABKAsyDC5JT0xKQkdMTkxDShIgCgpiYXNpY19pbmZv";
		buffer[6] = "GAQgASgLMgwuS0dBQkpFTkNGREMSIQoLSEtLSUpBQkdDTkEYBSABKAsyDC5O";
		buffer[7] = "S0xPQkFLRU1JSRIbCgVsZXZlbBgJIAEoCzIMLkFDQ0JQRUFKRkVPEhwKBmxp";
		buffer[8] = "bmV1cBgLIAEoCzIMLk1JQ09NSUJQSU9BEiEKC09GQU9JTUNESFBOGAwgASgL";
		buffer[9] = "MgwuT0pBRUVNUEtDQk4SIQoLTU1BT09OUEFQRFAYDiABKAsyDC5LS0ZBTkdJ";
		buffer[10] = "SkFPRkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[8]
		{
			ACCBPEAJFEOReflection.Descriptor,
			IOLJBGLNLCJReflection.Descriptor,
			KGABJENCFDCReflection.Descriptor,
			KKFANGIJAOFReflection.Descriptor,
			MICOMIBPIOAReflection.Descriptor,
			NKLOBAKEMIIReflection.Descriptor,
			OJAEEMPKCBNReflection.Descriptor,
			PGJNBNANDEEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AHOLOHCLLKD), AHOLOHCLLKD.Parser, new string[8] { "ItemValue", "EIENKJFFFJG", "BasicInfo", "HKKIJABGCNA", "Level", "Lineup", "OFAOIMCDHPN", "MMAOONPAPDP" }, null, null, null, null)
		}));
	}
}
