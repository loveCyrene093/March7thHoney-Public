using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMapRotationDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMapRotationDataScRspReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "Ch1HZXRNYXBSb3RhdGlvbkRhdGFTY1JzcC5wcm90bxoRQ2hhcmdlckluZm8u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "cHJvdG8aE1JvdGF0ZU1hcEluZm8ucHJvdG8aEVJvdGF0ZXJEYXRhLnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "GhdSb3RhdGVyRW5lcmd5SW5mby5wcm90byL9AQoXR2V0TWFwUm90YXRpb25E";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "YXRhU2NSc3ASJwoLZW5lcmd5X2luZm8YAiABKAsyEi5Sb3RhdGVyRW5lcmd5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "SW5mbxIhCgtHUEtBQklCS0pIRhgDIAMoCzIMLkNoYXJnZXJJbmZvEhMKC0pI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "RExOQlBORUtHGAQgASgFEhMKC0JDUENCSE1GSUlOGAUgASgNEg8KB3JldGNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "ZGUYByABKA0SIQoLREpIRERPRkhNQ0YYCSADKAsyDC5Sb3RhdGVyRGF0YRIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "CgtESU1PR0xJTUxCRBgKIAEoCBIjCgtBTU1KRUNIUEdQRRgNIAEoCzIOLlJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "dGF0ZU1hcEluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[4]
		{
			ChargerInfoReflection.Descriptor,
			RotateMapInfoReflection.Descriptor,
			RotaterDataReflection.Descriptor,
			RotaterEnergyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMapRotationDataScRsp), GetMapRotationDataScRsp.Parser, new string[8] { "EnergyInfo", "GPKABIBKJHF", "JHDLNBPNEKG", "BCPCBHMFIIN", "Retcode", "DJHDDOFHMCF", "DIMOGLIMLBD", "AMMJECHPGPE" }, null, null, null, null)
		}));
	}
}
