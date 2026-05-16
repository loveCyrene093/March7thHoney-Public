using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMissionDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMissionDataScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChlHZXRNaXNzaW9uRGF0YVNjUnNwLnByb3RvGhFNYWluTWlzc2lvbi5wcm90";
		buffer[1] = "bxoNTWlzc2lvbi5wcm90byKzAQoTR2V0TWlzc2lvbkRhdGFTY1JzcBITCgtQ";
		buffer[2] = "T0FBSkVCRkVOTxgCIAEoDRIYChB0cmFja19taXNzaW9uX2lkGAQgASgNEh4K";
		buffer[3] = "DG1pc3Npb25fbGlzdBgFIAMoCzIILk1pc3Npb24SJwoRbWFpbl9taXNzaW9u";
		buffer[4] = "X2xpc3QYCyADKAsyDC5NYWluTWlzc2lvbhITCgtFSUFHS0ZLT05QRRgMIAMo";
		buffer[5] = "DRIPCgdyZXRjb2RlGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[6] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			MainMissionReflection.Descriptor,
			MissionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMissionDataScRsp), GetMissionDataScRsp.Parser, new string[6] { "POAAJEBFENO", "TrackMissionId", "MissionList", "MainMissionList", "EIAGKFKONPE", "Retcode" }, null, null, null, null)
		}));
	}
}
