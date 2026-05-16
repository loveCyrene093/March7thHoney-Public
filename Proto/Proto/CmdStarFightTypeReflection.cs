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
		buffer[0] = "ChZDbWRTdGFyRmlnaHRUeXBlLnByb3RvKtQBChBDbWRTdGFyRmlnaHRUeXBl";
		buffer[1] = "EhsKF0pIUERFQkJJRE1OX1BDUERIRUxQS0VNEAASHQoYQ21kR2V0U3RhckZp";
		buffer[2] = "Z2h0RGF0YVNjUnNwEII4EiAKG0NtZFN0YXJ0U3RhckZpZ2h0TGV2ZWxTY1Jz";
		buffer[3] = "cBD/NxIhChxDbWRTdGFyRmlnaHREYXRhQ2hhbmdlTm90aWZ5EP03Eh0KGENt";
		buffer[4] = "ZEdldFN0YXJGaWdodERhdGFDc1JlcRCBOBIgChtDbWRTdGFydFN0YXJGaWdo";
		buffer[5] = "dExldmVsQ3NSZXEQ+TdCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[6] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdStarFightType) }, null, null));
	}
}
