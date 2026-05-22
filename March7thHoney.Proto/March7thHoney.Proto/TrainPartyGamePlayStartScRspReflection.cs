using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyGamePlayStartScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyGamePlayStartScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJUcmFpblBhcnR5R2FtZVBsYXlTdGFydFNjUnNwLnByb3RvGhFGS1BNT0tP" + "Sk5IUC5wcm90byJSChxUcmFpblBhcnR5R2FtZVBsYXlTdGFydFNjUnNwEiEK" + "C01MQkpGT1BQQkNNGAkgASgLMgwuRktQTU9LT0pOSFASDwoHcmV0Y29kZRgK" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { FKPMOKOJNHPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyGamePlayStartScRsp), TrainPartyGamePlayStartScRsp.Parser, new string[2] { "MLBJFOPPBCM", "Retcode" }, null, null, null, null)
		}));
	}
}
