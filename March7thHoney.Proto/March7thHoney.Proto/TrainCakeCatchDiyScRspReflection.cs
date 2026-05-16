using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainCakeCatchDiyScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainCakeCatchDiyScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxUcmFpbkNha2VDYXRjaERpeVNjUnNwLnByb3RvGhFGT0ZOT0JITEtHTy5w" + "cm90byJMChZUcmFpbkNha2VDYXRjaERpeVNjUnNwEiEKC1BFT0VDRERBTk5Q" + "GAYgASgLMgwuRk9GTk9CSExLR08SDwoHcmV0Y29kZRgHIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { FOFNOBHLKGOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainCakeCatchDiyScRsp), TrainCakeCatchDiyScRsp.Parser, new string[2] { "PEOECDDANNP", "Retcode" }, null, null, null, null)
		}));
	}
}
