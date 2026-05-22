using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPunkLordDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPunkLordDataScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChpHZXRQdW5rTG9yZERhdGFTY1JzcC5wcm90byK6AQoUR2V0UHVua0xvcmRE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "YXRhU2NSc3ASDwoHcmV0Y29kZRgBIAEoDRITCgtNUElDT0hNRkdPQRgCIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "DRITCgtLRkFDTUlETUJGRhgDIAEoDRITCgtNT0dCTkpPSEtMQRgEIAMoDRIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "CgtEQkFLTkJITE5KSxgGIAEoDRITCgtFREFOS1BIR0tLSxgIIAEoAxITCgtF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "SkZFQkNLRE5OSBgMIAEoDRITCgtDTE1PTkVFSUVKRRgNIAEoDUIWqgITTWFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPunkLordDataScRsp), GetPunkLordDataScRsp.Parser, new string[8] { "Retcode", "MPICOHMFGOA", "KFACMIDMBFF", "MOGBNJOHKLA", "DBAKNBHLNJK", "EDANKPHGKKK", "EJFEBCKDNNH", "CLMONEEIEJE" }, null, null, null, null)
		}));
	}
}
