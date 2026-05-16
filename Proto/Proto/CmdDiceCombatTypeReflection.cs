using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdDiceCombatTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdDiceCombatTypeReflection()
	{
		InlineArray16<string> buffer = default(InlineArray16<string>);
		buffer[0] = "ChdDbWREaWNlQ29tYmF0VHlwZS5wcm90byrqBAoRQ21kRGljZUNvbWJhdFR5";
		buffer[1] = "cGUSGwoXSlBCQ0xISkVGTUtfUENQREhFTFBLRU0QABIbChZDbWRNb2RpZnlB";
		buffer[2] = "dmF0YXJEaWNlUnNwEK9IEiQKH0NtZERpY2VDb21iYXRVcGdyYWRlQXZhdGFy";
		buffer[3] = "Q3NSZXEQyUgSIgodQ21kR2V0RGljZUNvbWJhdFN5c3RlbURhdGFSZXEQs0gS";
		buffer[4] = "EwoOQ21kRUpFQUpPQUFFTUIQwkgSJwoiQ21kRGljZUNvbWJhdE1haW5QYWdl";
		buffer[5] = "Um9sbERpY2VDc1JlcRCtSBIgChtDbWREaWNlQ29tYmF0QnV5U2hvcEdvb2RS";
		buffer[6] = "ZXEQykgSGAoTQ21kQnV5U2hvcEdvb2RTY1JzcBCySBITCg5DbWRBSVBFTUVF";
		buffer[7] = "REhBSxDISBIlCiBDbWREaWNlQ29tYmF0RmluaXNoUHZlU3RhZ2VDc1JlcRCu";
		buffer[8] = "SBITCg5DbWRMQU9PSUhQS01PTxCwSBIYChNDbWRHZXRTeXN0ZW1EYXRhUnNw";
		buffer[9] = "ELtIEicKIkNtZERpY2VDb21iYXRNb2RpZnlBdmF0YXJEaWNlQ3NSZXEQtEgS";
		buffer[10] = "IAobQ21kR2V0RGljZUNvbWJhdFNob3BEYXRhUmVxELlIEhgKE0NtZFVwZ3Jh";
		buffer[11] = "ZGVBdmF0YXJSc3AQvEgSGAoTQ21kR2V0U2hvcERhdGFTY1JzcBC9SBIbChZD";
		buffer[12] = "bWRGaW5pc2hQdmVTdGFnZVNjUnNwELFIEhIKDUNtZEFkZEl0ZW1Sc3AQvkgS";
		buffer[13] = "HQoYQ21kVjJGaW5pc2hQdmVTdGFnZUNzUmVxENJIEh0KGENtZFYyRmluaXNo";
		buffer[14] = "UHZlU3RhZ2VTY1JzcBDASEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[15] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdDiceCombatType) }, null, null));
	}
}
