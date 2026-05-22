using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdFightFestTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdFightFestTypeReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "ChZDbWRGaWdodEZlc3RUeXBlLnByb3RvKsACChBDbWRGaWdodEZlc3RUeXBl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "EhsKF0VJTU9PT0lMTUtDX1BDUERIRUxQS0VNEAASIgodQ21kRmlnaHRGZXN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "VW5sb2NrU2tpbGxOb3RpZnkQ+DgSGwoWQ21kU3RhcnRGaWdodEZlc3RTY1Jz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "cBDtOBIsCidDbWRGaWdodEZlc3RVcGRhdGVDaGFsbGVuZ2VSZWNvcmROb3Rp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "ZnkQ1zgSIgodQ21kRmlnaHRGZXN0U2NvcmVVcGRhdGVOb3RpZnkQ9TgSIQoc";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "Q21kRmlnaHRGZXN0VXBkYXRlQ29pbk5vdGlmeRDTOBIbChZDbWRTdGFydEZp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "Z2h0RmVzdENzUmVxEPA4Eh0KGENtZEdldEZpZ2h0RmVzdERhdGFDc1JlcRDf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "OBIdChhDbWRHZXRGaWdodEZlc3REYXRhU2NSc3AQ2ThCFqoCE01hcmNoN3Ro";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdFightFestType) }, null, null));
	}
}
