using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdAdventureTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdAdventureTypeReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 0) = "ChZDbWRBZHZlbnR1cmVUeXBlLnByb3RvKqwDChBDbWRBZHZlbnR1cmVUeXBl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 1) = "EhsKF0tFR0NIQ0lIS0RNX1BDUERIRUxQS0VNEAASHQoYQ21kRmFybUVsZW1l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 2) = "bnRTd2VlcFNjUnNwEJUKEh0KGENtZEZhcm1FbGVtZW50U3dlZXBDc1JlcRC7";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 3) = "ChIcChdLRUdDSENJSEtETV9ET0ZNQUdPR0FOUBDvChIiCh1DbWRRdWlja1N0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 4) = "YXJ0Q29jb29uU3RhZ2VDc1JlcRCiChITCg5DbWRHSUNERE5ER0pKTxCeChIi";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 5) = "Ch1DbWRRdWlja1N0YXJ0Q29jb29uU3RhZ2VTY1JzcBCmChIiCh1DbWRRdWlj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 6) = "a1N0YXJ0RmFybUVsZW1lbnRTY1JzcBD2ChIYChNDbWRDb2Nvb25Td2VlcFNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 7) = "UnNwEK4KEhgKE0NtZENvY29vblN3ZWVwQ3NSZXEQ0woSIgodQ21kUXVpY2tT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 8) = "dGFydEZhcm1FbGVtZW50Q3NSZXEQnQoSIgodQ21kR2V0RmFybVN0YWdlR2Fj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 9) = "aGFJbmZvU2NSc3AQ8woSIgodQ21kR2V0RmFybVN0YWdlR2FjaGFJbmZvQ3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 10) = "ZXEQ8gpCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray11<string>, string>(in buffer, 11))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdAdventureType) }, null, null));
	}
}
