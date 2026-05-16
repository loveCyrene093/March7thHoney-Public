using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class APCNLFANPEPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static APCNLFANPEPReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChFBUENOTEZBTlBFUC5wcm90byK+AgoLQVBDTkxGQU5QRVASHwoXZ3JpZF9m";
		buffer[1] = "aWdodF9lcXVpcG1lbnRfaWQYAiABKA0SUQocY29udmVydF9wcm9wZXJ0eV90";
		buffer[2] = "b19maXhwb2ludBgEIAMoCzIrLkFQQ05MRkFOUEVQLkNvbnZlcnRQcm9wZXJ0";
		buffer[3] = "eVRvRml4cG9pbnRFbnRyeRIRCgl1bmlxdWVfaWQYBSABKA0SMgoLQkJKQ01P";
		buffer[4] = "RkdCRkkYBiADKAsyHS5BUENOTEZBTlBFUC5CQkpDTU9GR0JGSUVudHJ5GkAK";
		buffer[5] = "HkNvbnZlcnRQcm9wZXJ0eVRvRml4cG9pbnRFbnRyeRILCgNrZXkYASABKA0S";
		buffer[6] = "DQoFdmFsdWUYAiABKA06AjgBGjIKEEJCSkNNT0ZHQkZJRW50cnkSCwoDa2V5";
		buffer[7] = "GAEgASgNEg0KBXZhbHVlGAIgASgBOgI4AUIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[8] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(APCNLFANPEP), APCNLFANPEP.Parser, new string[4] { "GridFightEquipmentId", "ConvertPropertyToFixpoint", "UniqueId", "BBJCMOFGBFI" }, null, null, null, new GeneratedClrTypeInfo[2])
		}));
	}
}
