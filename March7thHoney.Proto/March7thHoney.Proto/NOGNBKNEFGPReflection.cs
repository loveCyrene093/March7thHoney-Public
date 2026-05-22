using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NOGNBKNEFGPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NOGNBKNEFGPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOT0dOQktORUZHUC5wcm90bxoRQUtHT0FJUExKTEoucHJvdG8iRQoLTk9H" + "TkJLTkVGR1ASIQoLRkVJTE5JS05QQ0IYASABKAsyDC5BS0dPQUlQTEpMShIT" + "CgtKSEFETUJEQ1BFTxgJIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { AKGOAIPLJLJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NOGNBKNEFGP), NOGNBKNEFGP.Parser, new string[2] { "FEILNIKNPCB", "JHADMBDCPEO" }, null, null, null, null)
		}));
	}
}
