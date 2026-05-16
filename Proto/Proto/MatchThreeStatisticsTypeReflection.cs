using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MatchThreeStatisticsTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MatchThreeStatisticsTypeReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		buffer[0] = "Ch5NYXRjaFRocmVlU3RhdGlzdGljc1R5cGUucHJvdG8qsAMKGE1hdGNoVGhy";
		buffer[1] = "ZWVTdGF0aXN0aWNzVHlwZRIbChdNUEtJTk9FRU5NT19OSUhEQ1BNRUdNRxAA";
		buffer[2] = "EhsKF01QS0lOT0VFTk1PX0xMR0VMR1BETklHEAESGwoXTVBLSU5PRUVOTU9f";
		buffer[3] = "QUNCSE9JTFBKRE0QAhIbChdNUEtJTk9FRU5NT19GREJOTUlIS0JGQxADEhsK";
		buffer[4] = "F01QS0lOT0VFTk1PX01QQ05FQ09QRU9LEAQSGwoXTVBLSU5PRUVOTU9fT0pP";
		buffer[5] = "REFDUFBITFAQBRIbChdNUEtJTk9FRU5NT19QTEFMS09NQ0RKThAGEhsKF01Q";
		buffer[6] = "S0lOT0VFTk1PX0lMR0tMREVCSkZCEAcSGwoXTVBLSU5PRUVOTU9fRklFTU5K";
		buffer[7] = "Sk5KSkoQCBIbChdNUEtJTk9FRU5NT19QREVCTVBKSUhMTxAJEhsKF01QS0lO";
		buffer[8] = "T0VFTk1PX0NBQURISEFCTUFHEAoSGwoXTVBLSU5PRUVOTU9fQ0tDTkhPQkNE";
		buffer[9] = "S0kQCxIbChdNUEtJTk9FRU5NT19LSkVNSERNSE9GTBAMEhsKF01QS0lOT0VF";
		buffer[10] = "Tk1PX0ZPTEtFRk9KQ0xNEA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[11] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MatchThreeStatisticsType) }, null, null));
	}
}
