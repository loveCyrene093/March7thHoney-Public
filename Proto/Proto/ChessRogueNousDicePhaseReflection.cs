using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueNousDicePhaseReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueNousDicePhaseReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1DaGVzc1JvZ3VlTm91c0RpY2VQaGFzZS5wcm90bypwChdDaGVzc1JvZ3Vl" + "Tm91c0RpY2VQaGFzZRIbChdGRVBQRU1NTUdNTV9QQ1BESEVMUEtFTRAAEhsK" + "F0ZFUFBFTU1NR01NX01HTU5CTElQRkxQEAESGwoXRkVQUEVNTU1HTU1fSkdJ" + "TElQRVBPQ0oQAkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ChessRogueNousDicePhase) }, null, null));
	}
}
