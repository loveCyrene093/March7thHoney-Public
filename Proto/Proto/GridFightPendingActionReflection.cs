using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightPendingActionReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightPendingActionReflection()
	{
		_003C_003Ey__InlineArray32<string> buffer = default(_003C_003Ey__InlineArray32<string>);
		buffer[0] = "ChxHcmlkRmlnaHRQZW5kaW5nQWN0aW9uLnByb3RvGhFFRUpBSk1OS0FNSS5w";
		buffer[1] = "cm90bxogR3JpZEZpZ2h0QXVnbWVudEFjdGlvbkluZm8ucHJvdG8aJEdyaWRG";
		buffer[2] = "aWdodEVsaXRlQnJhbmNoQWN0aW9uSW5mby5wcm90bxoiR3JpZEZpZ2h0Rm9y";
		buffer[3] = "Z2VSb2xlQWN0aW9uSW5mby5wcm90bxojR3JpZEZpZ2h0UG9ydGFsQnVmZkFj";
		buffer[4] = "dGlvbkluZm8ucHJvdG8aK0dyaWRGaWdodFJlY29tbWVuZEVxdWlwbWVudEFj";
		buffer[5] = "dGlvbkluZm8ucHJvdG8aKkdyaWRGaWdodFJldHVyblByZXBhcmF0aW9uQWN0";
		buffer[6] = "aW9uSW5mby5wcm90bxojR3JpZEZpZ2h0Um91bmRCZWdpbkFjdGlvbkluZm8u";
		buffer[7] = "cHJvdG8aH0dyaWRGaWdodFN1cHBseUFjdGlvbkluZm8ucHJvdG8aHkdyaWRG";
		buffer[8] = "aWdodFRyYWl0QWN0aW9uSW5mby5wcm90bxolR3JpZEZpZ2h0VXBncmFkZUVx";
		buffer[9] = "dWlwQWN0aW9uSW5mby5wcm90bxoRSEVQRklBRkpBSEwucHJvdG8aEUtJS01K";
		buffer[10] = "S05ISkdBLnByb3RvGhFOSEpDRUxCQ0ZORi5wcm90bxoRTkpKRlBMRkVFRkMu";
		buffer[11] = "cHJvdG8i/QYKFkdyaWRGaWdodFBlbmRpbmdBY3Rpb24SFgoOcXVldWVfcG9z";
		buffer[12] = "aXRpb24YBSABKA0SMwoNc3VwcGx5X2FjdGlvbhgVIAEoCzIaLkdyaWRGaWdo";
		buffer[13] = "dFN1cHBseUFjdGlvbkluZm9IABJKChlyZXR1cm5fcHJlcGFyYXRpb25fYWN0";
		buffer[14] = "aW9uGCYgASgLMiUuR3JpZEZpZ2h0UmV0dXJuUHJlcGFyYXRpb25BY3Rpb25J";
		buffer[15] = "bmZvSAASJAoLREpFSkpLQURCQ0kYpAEgASgLMgwuS0lLTUpLTkhKR0FIABIk";
		buffer[16] = "CgtIUE1OT0dHTUtLSBicAiABKAsyDC5OSEpDRUxCQ0ZORkgAEjYKDmF1Z21l";
		buffer[17] = "bnRfYWN0aW9uGOIDIAEoCzIbLkdyaWRGaWdodEF1Z21lbnRBY3Rpb25JbmZv";
		buffer[18] = "SAASPQoScm91bmRfYmVnaW5fYWN0aW9uGOgGIAEoCzIeLkdyaWRGaWdodFJv";
		buffer[19] = "dW5kQmVnaW5BY3Rpb25JbmZvSAASTQoacmVjb21tZW5kX2VxdWlwbWVudF9h";
		buffer[20] = "Y3Rpb24Y1AcgASgLMiYuR3JpZEZpZ2h0UmVjb21tZW5kRXF1aXBtZW50QWN0";
		buffer[21] = "aW9uSW5mb0gAEkEKFHVwZ3JhZGVfZXF1aXBfYWN0aW9uGKcIIAEoCzIgLkdy";
		buffer[22] = "aWRGaWdodFVwZ3JhZGVFcXVpcEFjdGlvbkluZm9IABJAChZmb3JnZV9yb2xl";
		buffer[23] = "X2FjdGlvbl9pbmZvGP8IIAEoCzIdLkdyaWRGaWdodEZvcmdlUm9sZUFjdGlv";
		buffer[24] = "bkluZm9IABIkCgtLQUNER0FKSE5CSRi7CSABKAsyDC5OSkpGUExGRUVGQ0gA";
		buffer[25] = "EiQKC0FQTEVHSEtORk9LGKYLIAEoCzIMLkhFUEZJQUZKQUhMSAASJAoLUEtD";
		buffer[26] = "T05ITE5NSUoYhAwgASgLMgwuRUVKQUpNTktBTUlIABIyCgx0cmFpdF9hY3Rp";
		buffer[27] = "b24YiA4gASgLMhkuR3JpZEZpZ2h0VHJhaXRBY3Rpb25JbmZvSAASPQoScG9y";
		buffer[28] = "dGFsX2J1ZmZfYWN0aW9uGLMOIAEoCzIeLkdyaWRGaWdodFBvcnRhbEJ1ZmZB";
		buffer[29] = "Y3Rpb25JbmZvSAASPwoTZWxpdGVfYnJhbmNoX2FjdGlvbhjlDiABKAsyHy5H";
		buffer[30] = "cmlkRmlnaHRFbGl0ZUJyYW5jaEFjdGlvbkluZm9IAEINCgtCR0dCSU1CS0hF";
		buffer[31] = "SUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[15]
		{
			EEJAJMNKAMIReflection.Descriptor,
			GridFightAugmentActionInfoReflection.Descriptor,
			GridFightEliteBranchActionInfoReflection.Descriptor,
			GridFightForgeRoleActionInfoReflection.Descriptor,
			GridFightPortalBuffActionInfoReflection.Descriptor,
			GridFightRecommendEquipmentActionInfoReflection.Descriptor,
			GridFightReturnPreparationActionInfoReflection.Descriptor,
			GridFightRoundBeginActionInfoReflection.Descriptor,
			GridFightSupplyActionInfoReflection.Descriptor,
			GridFightTraitActionInfoReflection.Descriptor,
			GridFightUpgradeEquipActionInfoReflection.Descriptor,
			HEPFIAFJAHLReflection.Descriptor,
			KIKMJKNHJGAReflection.Descriptor,
			NHJCELBCFNFReflection.Descriptor,
			NJJFPLFEEFCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightPendingAction), GridFightPendingAction.Parser, new string[16]
			{
				"QueuePosition", "SupplyAction", "ReturnPreparationAction", "DJEJJKADBCI", "HPMNOGGMKKH", "AugmentAction", "RoundBeginAction", "RecommendEquipmentAction", "UpgradeEquipAction", "ForgeRoleActionInfo",
				"KACDGAJHNBI", "APLEGHKNFOK", "PKCONHLNMIJ", "TraitAction", "PortalBuffAction", "EliteBranchAction"
			}, new string[1] { "BGGBIMBKHEI" }, null, null, null)
		}));
	}
}
