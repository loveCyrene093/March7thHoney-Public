using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueQuitScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueQuitScRspReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		buffer[0] = "ChlDaGVzc1JvZ3VlUXVpdFNjUnNwLnByb3RvGhFCQUJBR0VEQ0NCRy5wcm90";
		buffer[1] = "bxoRQ0dERkdNTUtKQUgucHJvdG8aEUVKQ0NISEFBR05ILnByb3RvGhFGSUlM";
		buffer[2] = "UEhLTEZFSy5wcm90bxoRSk1PR1BNQ0pHTEUucHJvdG8aEVBEQU1CQ0ZGUERJ";
		buffer[3] = "LnByb3RvIvoBChNDaGVzc1JvZ3VlUXVpdFNjUnNwEiEKC01PRERJQkhDUFBE";
		buffer[4] = "GAIgASgLMgwuQ0dERkdNTUtKQUgSJAoOcm9ndWVfZ2V0X2luZm8YAyABKAsy";
		buffer[5] = "DC5CQUJBR0VEQ0NCRxIhCgtORE1MRUdMSU9HThgHIAEoCzIMLkZJSUxQSEtM";
		buffer[6] = "RkVLEg8KB3JldGNvZGUYCSABKA0SIAoKc3RhZ2VfaW5mbxgLIAEoCzIMLkVK";
		buffer[7] = "Q0NISEFBR05IEiEKC09DTExBREJGS0hQGAwgASgLMgwuUERBTUJDRkZQREkS";
		buffer[8] = "IQoLSU1QQkVMSkdESkgYDyABKAsyDC5KTU9HUE1DSkdMRUIWqgITTWFyY2g3";
		buffer[9] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[6]
		{
			BABAGEDCCBGReflection.Descriptor,
			CGDFGMMKJAHReflection.Descriptor,
			EJCCHHAAGNHReflection.Descriptor,
			FIILPHKLFEKReflection.Descriptor,
			JMOGPMCJGLEReflection.Descriptor,
			PDAMBCFFPDIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueQuitScRsp), ChessRogueQuitScRsp.Parser, new string[7] { "MODDIBHCPPD", "RogueGetInfo", "NDMLEGLIOGN", "Retcode", "StageInfo", "OCLLADBFKHP", "IMPBELJGDJH" }, null, null, null, null)
		}));
	}
}
