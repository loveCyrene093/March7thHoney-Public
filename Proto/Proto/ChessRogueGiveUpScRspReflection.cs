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
		buffer[0] = "ChtDaGVzc1JvZ3VlR2l2ZVVwU2NSc3AucHJvdG8aEUJBQkFHRURDQ0JHLnBy";
		buffer[1] = "b3RvGhFFSkNDSEhBQUdOSC5wcm90bxoRRklJTFBIS0xGRUsucHJvdG8aEUpN";
		buffer[2] = "T0dQTUNKR0xFLnByb3RvGhFQREFNQkNGRlBESS5wcm90byLZAQoVQ2hlc3NS";
		buffer[3] = "b2d1ZUdpdmVVcFNjUnNwEiEKC05ETUxFR0xJT0dOGAEgASgLMgwuRklJTFBI";
		buffer[4] = "S0xGRUsSIQoLT0NMTEFEQkZLSFAYBCABKAsyDC5QREFNQkNGRlBESRIhCgtJ";
		buffer[5] = "TVBCRUxKR0RKSBgIIAEoCzIMLkpNT0dQTUNKR0xFEiQKDnJvZ3VlX2dldF9p";
		buffer[6] = "bmZvGAkgASgLMgwuQkFCQUdFRENDQkcSIAoKc3RhZ2VfaW5mbxgNIAEoCzIM";
		buffer[7] = "LkVKQ0NISEFBR05IEg8KB3JldGNvZGUYDyABKA1CFqoCE01hcmNoN3RoSG9u";
		buffer[8] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[5]
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
