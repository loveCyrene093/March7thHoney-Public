using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdStarFightTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdStarFightTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChZDbWRTdGFyRmlnaHRUeXBlLnByb3RvKtQBChBDbWRTdGFyRmlnaHRUeXBl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "EhsKF0pIUERFQkJJRE1OX1BDUERIRUxQS0VNEAASHQoYQ21kR2V0U3RhckZp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "Z2h0RGF0YVNjUnNwEII4EiAKG0NtZFN0YXJ0U3RhckZpZ2h0TGV2ZWxTY1Jz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "cBD/NxIhChxDbWRTdGFyRmlnaHREYXRhQ2hhbmdlTm90aWZ5EP03Eh0KGENt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "ZEdldFN0YXJGaWdodERhdGFDc1JlcRCBOBIgChtDbWRTdGFydFN0YXJGaWdo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "dExldmVsQ3NSZXEQ+TdCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdStarFightType) }, null, null));
	}
}
