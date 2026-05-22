using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueGiveUpScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueGiveUpScRspReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "ChtDaGVzc1JvZ3VlR2l2ZVVwU2NSc3AucHJvdG8aEUJBQkFHRURDQ0JHLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "b3RvGhFFSkNDSEhBQUdOSC5wcm90bxoRRklJTFBIS0xGRUsucHJvdG8aEUpN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "T0dQTUNKR0xFLnByb3RvGhFQREFNQkNGRlBESS5wcm90byLZAQoVQ2hlc3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "b2d1ZUdpdmVVcFNjUnNwEiEKC05ETUxFR0xJT0dOGAEgASgLMgwuRklJTFBI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "S0xGRUsSIQoLT0NMTEFEQkZLSFAYBCABKAsyDC5QREFNQkNGRlBESRIhCgtJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "TVBCRUxKR0RKSBgIIAEoCzIMLkpNT0dQTUNKR0xFEiQKDnJvZ3VlX2dldF9p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "bmZvGAkgASgLMgwuQkFCQUdFRENDQkcSIAoKc3RhZ2VfaW5mbxgNIAEoCzIM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "LkVKQ0NISEFBR05IEg8KB3JldGNvZGUYDyABKA1CFqoCE01hcmNoN3RoSG9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[5]
		{
			BABAGEDCCBGReflection.Descriptor,
			EJCCHHAAGNHReflection.Descriptor,
			FIILPHKLFEKReflection.Descriptor,
			JMOGPMCJGLEReflection.Descriptor,
			PDAMBCFFPDIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueGiveUpScRsp), ChessRogueGiveUpScRsp.Parser, new string[6] { "NDMLEGLIOGN", "OCLLADBFKHP", "IMPBELJGDJH", "RogueGetInfo", "StageInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
