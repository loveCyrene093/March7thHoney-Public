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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 0) = "ChxHcmlkRmlnaHRQZW5kaW5nQWN0aW9uLnByb3RvGhFFRUpBSk1OS0FNSS5w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 1) = "cm90bxogR3JpZEZpZ2h0QXVnbWVudEFjdGlvbkluZm8ucHJvdG8aJEdyaWRG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 2) = "aWdodEVsaXRlQnJhbmNoQWN0aW9uSW5mby5wcm90bxoiR3JpZEZpZ2h0Rm9y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 3) = "Z2VSb2xlQWN0aW9uSW5mby5wcm90bxojR3JpZEZpZ2h0UG9ydGFsQnVmZkFj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 4) = "dGlvbkluZm8ucHJvdG8aK0dyaWRGaWdodFJlY29tbWVuZEVxdWlwbWVudEFj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 5) = "dGlvbkluZm8ucHJvdG8aKkdyaWRGaWdodFJldHVyblByZXBhcmF0aW9uQWN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 6) = "aW9uSW5mby5wcm90bxojR3JpZEZpZ2h0Um91bmRCZWdpbkFjdGlvbkluZm8u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 7) = "cHJvdG8aH0dyaWRGaWdodFN1cHBseUFjdGlvbkluZm8ucHJvdG8aHkdyaWRG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 8) = "aWdodFRyYWl0QWN0aW9uSW5mby5wcm90bxolR3JpZEZpZ2h0VXBncmFkZUVx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 9) = "dWlwQWN0aW9uSW5mby5wcm90bxoRSEVQRklBRkpBSEwucHJvdG8aEUtJS01K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 10) = "S05ISkdBLnByb3RvGhFOSEpDRUxCQ0ZORi5wcm90bxoRTkpKRlBMRkVFRkMu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 11) = "cHJvdG8i/QYKFkdyaWRGaWdodFBlbmRpbmdBY3Rpb24SFgoOcXVldWVfcG9z";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 12) = "aXRpb24YBSABKA0SMwoNc3VwcGx5X2FjdGlvbhgVIAEoCzIaLkdyaWRGaWdo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 13) = "dFN1cHBseUFjdGlvbkluZm9IABJKChlyZXR1cm5fcHJlcGFyYXRpb25fYWN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 14) = "aW9uGCYgASgLMiUuR3JpZEZpZ2h0UmV0dXJuUHJlcGFyYXRpb25BY3Rpb25J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 15) = "bmZvSAASJAoLREpFSkpLQURCQ0kYpAEgASgLMgwuS0lLTUpLTkhKR0FIABIk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 16) = "CgtIUE1OT0dHTUtLSBicAiABKAsyDC5OSEpDRUxCQ0ZORkgAEjYKDmF1Z21l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 17) = "bnRfYWN0aW9uGOIDIAEoCzIbLkdyaWRGaWdodEF1Z21lbnRBY3Rpb25JbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 18) = "SAASPQoScm91bmRfYmVnaW5fYWN0aW9uGOgGIAEoCzIeLkdyaWRGaWdodFJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 19) = "dW5kQmVnaW5BY3Rpb25JbmZvSAASTQoacmVjb21tZW5kX2VxdWlwbWVudF9h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 20) = "Y3Rpb24Y1AcgASgLMiYuR3JpZEZpZ2h0UmVjb21tZW5kRXF1aXBtZW50QWN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 21) = "aW9uSW5mb0gAEkEKFHVwZ3JhZGVfZXF1aXBfYWN0aW9uGKcIIAEoCzIgLkdy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 22) = "aWRGaWdodFVwZ3JhZGVFcXVpcEFjdGlvbkluZm9IABJAChZmb3JnZV9yb2xl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 23) = "X2FjdGlvbl9pbmZvGP8IIAEoCzIdLkdyaWRGaWdodEZvcmdlUm9sZUFjdGlv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 24) = "bkluZm9IABIkCgtLQUNER0FKSE5CSRi7CSABKAsyDC5OSkpGUExGRUVGQ0gA";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 25) = "EiQKC0FQTEVHSEtORk9LGKYLIAEoCzIMLkhFUEZJQUZKQUhMSAASJAoLUEtD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 26) = "T05ITE5NSUoYhAwgASgLMgwuRUVKQUpNTktBTUlIABIyCgx0cmFpdF9hY3Rp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 27) = "b24YiA4gASgLMhkuR3JpZEZpZ2h0VHJhaXRBY3Rpb25JbmZvSAASPQoScG9y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 28) = "dGFsX2J1ZmZfYWN0aW9uGLMOIAEoCzIeLkdyaWRGaWdodFBvcnRhbEJ1ZmZB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 29) = "Y3Rpb25JbmZvSAASPwoTZWxpdGVfYnJhbmNoX2FjdGlvbhjlDiABKAsyHy5H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 30) = "cmlkRmlnaHRFbGl0ZUJyYW5jaEFjdGlvbkluZm9IAEINCgtCR0dCSU1CS0hF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray32<string>, string>(ref buffer, 31) = "SUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray32<string>, string>(in buffer, 32))), new FileDescriptor[15]
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
