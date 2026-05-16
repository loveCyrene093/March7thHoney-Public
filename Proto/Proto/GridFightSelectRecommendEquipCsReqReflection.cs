using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightSelectRecommendEquipCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightSelectRecommendEquipCsReqReflection()
	{
		_003C_003Ey__InlineArray43<string> buffer = default(_003C_003Ey__InlineArray43<string>);
		buffer[0] = "CihHcmlkRmlnaHRTZWxlY3RSZWNvbW1lbmRFcXVpcENzUmVxLnByb3RvGhFF";
		buffer[1] = "S0pHR0xMRUVMSy5wcm90bxoRRU5JSEFETkJGRkkucHJvdG8aIkdyaWRGaWdo";
		buffer[2] = "dEF1Z21lbnRBY3Rpb25SZXN1bHQucHJvdG8aKEdyaWRGaWdodEF1Z21lbnRS";
		buffer[3] = "ZXJvbGxBY3Rpb25SZXN1bHQucHJvdG8aJkdyaWRGaWdodEVsaXRlQnJhbmNo";
		buffer[4] = "QWN0aW9uUmVzdWx0LnByb3RvGiRHcmlkRmlnaHRGb3JnZVJvbGVBY3Rpb25S";
		buffer[5] = "ZXN1bHQucHJvdG8aJUdyaWRGaWdodFBvcnRhbEJ1ZmZBY3Rpb25SZXN1bHQu";
		buffer[6] = "cHJvdG8aK0dyaWRGaWdodFBvcnRhbEJ1ZmZSZXJvbGxBY3Rpb25SZXN1bHQu";
		buffer[7] = "cHJvdG8aLUdyaWRGaWdodFJlY29tbWVuZEVxdWlwbWVudEFjdGlvblJlc3Vs";
		buffer[8] = "dC5wcm90bxosR3JpZEZpZ2h0UmV0dXJuUHJlcGFyYXRpb25BY3Rpb25SZXN1";
		buffer[9] = "bHQucHJvdG8aJUdyaWRGaWdodFJvdW5kQmVnaW5BY3Rpb25SZXN1bHQucHJv";
		buffer[10] = "dG8aIUdyaWRGaWdodFN1cHBseUFjdGlvblJlc3VsdC5wcm90bxonR3JpZEZp";
		buffer[11] = "Z2h0U3VwcGx5UmVyb2xsQWN0aW9uUmVzdWx0LnByb3RvGiBHcmlkRmlnaHRU";
		buffer[12] = "cmFpdEFjdGlvblJlc3VsdC5wcm90bxonR3JpZEZpZ2h0VXBncmFkZUVxdWlw";
		buffer[13] = "QWN0aW9uUmVzdWx0LnByb3RvGhFKRktPQ0hBSktERy5wcm90bxoRS0tJUElD";
		buffer[14] = "QkZKUE0ucHJvdG8aEUxGS0VEUFBMT0tMLnByb3RvGhFQUENKQkRIREhMTC5w";
		buffer[15] = "cm90byKeCQoiR3JpZEZpZ2h0U2VsZWN0UmVjb21tZW5kRXF1aXBDc1JlcRIW";
		buffer[16] = "Cg5xdWV1ZV9wb3NpdGlvbhgNIAEoDRIzCgx0cmFpdF9hY3Rpb24YGiABKAsy";
		buffer[17] = "Gy5HcmlkRmlnaHRUcmFpdEFjdGlvblJlc3VsdEgAEk0KGXJldHVybl9wcmVw";
		buffer[18] = "YXJhdGlvbl9hY3Rpb24Y5gEgASgLMicuR3JpZEZpZ2h0UmV0dXJuUHJlcGFy";
		buffer[19] = "YXRpb25BY3Rpb25SZXN1bHRIABIkCgtBUExFR0hLTkZPSxi0AiABKAsyDC5F";
		buffer[20] = "TklIQUROQkZGSUgAEiQKC1BLQ09OSExOTUlKGIADIAEoCzIMLkpGS09DSEFK";
		buffer[21] = "S0RHSAASJAoLSEdLTUhPT0ZOREEYkAMgASgLMgwuS0tJUElDQkZKUE1IABJD";
		buffer[22] = "ChRyZXJvbGxfc3VwcGx5X2FjdGlvbhi+AyABKAsyIi5HcmlkRmlnaHRTdXBw";
		buffer[23] = "bHlSZXJvbGxBY3Rpb25SZXN1bHRIABI2Cg1zdXBwbHlfYWN0aW9uGLIEIAEo";
		buffer[24] = "CzIcLkdyaWRGaWdodFN1cHBseUFjdGlvblJlc3VsdEgAEkwKGXBvcnRhbF9i";
		buffer[25] = "dWZmX3Jlcm9sbF9hY3Rpb24YiQUgASgLMiYuR3JpZEZpZ2h0UG9ydGFsQnVm";
		buffer[26] = "ZlJlcm9sbEFjdGlvblJlc3VsdEgAEkEKE2VsaXRlX2JyYW5jaF9hY3Rpb24Y";
		buffer[27] = "gAYgASgLMiEuR3JpZEZpZ2h0RWxpdGVCcmFuY2hBY3Rpb25SZXN1bHRIABI/";
		buffer[28] = "ChJyb3VuZF9iZWdpbl9hY3Rpb24YlwcgASgLMiAuR3JpZEZpZ2h0Um91bmRC";
		buffer[29] = "ZWdpbkFjdGlvblJlc3VsdEgAEj8KEnBvcnRhbF9idWZmX2FjdGlvbhjhCCAB";
		buffer[30] = "KAsyIC5HcmlkRmlnaHRQb3J0YWxCdWZmQWN0aW9uUmVzdWx0SAASRQoVcmVy";
		buffer[31] = "b2xsX2F1Z21lbnRfYWN0aW9uGO8JIAEoCzIjLkdyaWRGaWdodEF1Z21lbnRS";
		buffer[32] = "ZXJvbGxBY3Rpb25SZXN1bHRIABIkCgtLQUNER0FKSE5CSRiEDCABKAsyDC5M";
		buffer[33] = "RktFRFBQTE9LTEgAEk8KGnJlY29tbWVuZF9lcXVpcG1lbnRfYWN0aW9uGMQM";
		buffer[34] = "IAEoCzIoLkdyaWRGaWdodFJlY29tbWVuZEVxdWlwbWVudEFjdGlvblJlc3Vs";
		buffer[35] = "dEgAEiQKC0RKRUpKS0FEQkNJGP8MIAEoCzIMLkVLSkdHTExFRUxLSAASQgoW";
		buffer[36] = "Zm9yZ2Vfcm9sZV9hY3Rpb25faW5mbxiDDSABKAsyHy5HcmlkRmlnaHRGb3Jn";
		buffer[37] = "ZVJvbGVBY3Rpb25SZXN1bHRIABJDChR1cGdyYWRlX2VxdWlwX2FjdGlvbhiN";
		buffer[38] = "DSABKAsyIi5HcmlkRmlnaHRVcGdyYWRlRXF1aXBBY3Rpb25SZXN1bHRIABIk";
		buffer[39] = "CgtIUE1OT0dHTUtLSBisDSABKAsyDC5QUENKQkRIREhMTEgAEjgKDmF1Z21l";
		buffer[40] = "bnRfYWN0aW9uGJ8PIAEoCzIdLkdyaWRGaWdodEF1Z21lbnRBY3Rpb25SZXN1";
		buffer[41] = "bHRIAEINCgtCR0dCSU1CS0hFSUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[42] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[19]
		{
			EKJGGLLEELKReflection.Descriptor,
			ENIHADNBFFIReflection.Descriptor,
			GridFightAugmentActionResultReflection.Descriptor,
			GridFightAugmentRerollActionResultReflection.Descriptor,
			GridFightEliteBranchActionResultReflection.Descriptor,
			GridFightForgeRoleActionResultReflection.Descriptor,
			GridFightPortalBuffActionResultReflection.Descriptor,
			GridFightPortalBuffRerollActionResultReflection.Descriptor,
			GridFightRecommendEquipmentActionResultReflection.Descriptor,
			GridFightReturnPreparationActionResultReflection.Descriptor,
			GridFightRoundBeginActionResultReflection.Descriptor,
			GridFightSupplyActionResultReflection.Descriptor,
			GridFightSupplyRerollActionResultReflection.Descriptor,
			GridFightTraitActionResultReflection.Descriptor,
			GridFightUpgradeEquipActionResultReflection.Descriptor,
			JFKOCHAJKDGReflection.Descriptor,
			KKIPICBFJPMReflection.Descriptor,
			LFKEDPPLOKLReflection.Descriptor,
			PPCJBDHDHLLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSelectRecommendEquipCsReq), GridFightSelectRecommendEquipCsReq.Parser, new string[20]
			{
				"QueuePosition", "TraitAction", "ReturnPreparationAction", "APLEGHKNFOK", "PKCONHLNMIJ", "HGKMHOOFNDA", "RerollSupplyAction", "SupplyAction", "PortalBuffRerollAction", "EliteBranchAction",
				"RoundBeginAction", "PortalBuffAction", "RerollAugmentAction", "KACDGAJHNBI", "RecommendEquipmentAction", "DJEJJKADBCI", "ForgeRoleActionInfo", "UpgradeEquipAction", "HPMNOGGMKKH", "AugmentAction"
			}, new string[1] { "BGGBIMBKHEI" }, null, null, null)
		}));
	}
}
