using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetRelicBoxTargetScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetRelicBoxTargetScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxTZXRSZWxpY0JveFRhcmdldFNjUnNwLnByb3RvGhFPTUhBT0JGS0lLRS5w" + "cm90byJMChZTZXRSZWxpY0JveFRhcmdldFNjUnNwEiEKC0dQRUFGQUpHQ1BI" + "GAcgASgLMgwuT01IQU9CRktJS0USDwoHcmV0Y29kZRgOIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { OMHAOBFKIKEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetRelicBoxTargetScRsp), SetRelicBoxTargetScRsp.Parser, new string[2] { "GPEAFAJGCPH", "Retcode" }, null, null, null, null)
		}));
	}
}
