using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateMapRotationDataScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateMapRotationDataScNotifyReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "CiNVcGRhdGVNYXBSb3RhdGlvbkRhdGFTY05vdGlmeS5wcm90bxoRQ2hhcmdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "ckluZm8ucHJvdG8aE1JvdGF0ZU1hcEluZm8ucHJvdG8aEVJvdGF0ZXJEYXRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "LnByb3RvGhdSb3RhdGVyRW5lcmd5SW5mby5wcm90byLyAQodVXBkYXRlTWFw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "Um90YXRpb25EYXRhU2NOb3RpZnkSEwoLQkNQQ0JITUZJSU4YAiABKA0SIQoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "R1BLQUJJQktKSEYYBCADKAsyDC5DaGFyZ2VySW5mbxITCgtESU1PR0xJTUxC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "RBgFIAEoCBITCgtKSERMTkJQTkVLRxgIIAEoBRIjCgtBTU1KRUNIUEdQRRgM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "IAEoCzIOLlJvdGF0ZU1hcEluZm8SIQoLREpIRERPRkhNQ0YYDiADKAsyDC5S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "b3RhdGVyRGF0YRInCgtlbmVyZ3lfaW5mbxgPIAEoCzISLlJvdGF0ZXJFbmVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "Z3lJbmZvQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[4]
		{
			ChargerInfoReflection.Descriptor,
			RotateMapInfoReflection.Descriptor,
			RotaterDataReflection.Descriptor,
			RotaterEnergyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateMapRotationDataScNotify), UpdateMapRotationDataScNotify.Parser, new string[7] { "BCPCBHMFIIN", "GPKABIBKJHF", "DIMOGLIMLBD", "JHDLNBPNEKG", "AMMJECHPGPE", "DJHDDOFHMCF", "EnergyInfo" }, null, null, null, null)
		}));
	}
}
