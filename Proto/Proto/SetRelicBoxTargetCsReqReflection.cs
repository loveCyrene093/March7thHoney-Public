using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetRelicBoxTargetCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetRelicBoxTargetCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxTZXRSZWxpY0JveFRhcmdldENzUmVxLnByb3RvGhFPTUhBT0JGS0lLRS5w" + "cm90byI7ChZTZXRSZWxpY0JveFRhcmdldENzUmVxEiEKC0dQRUFGQUpHQ1BI" + "GAMgASgLMgwuT01IQU9CRktJS0VCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[1] { OMHAOBFKIKEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetRelicBoxTargetCsReq), SetRelicBoxTargetCsReq.Parser, new string[1] { "GPEAFAJGCPH" }, null, null, null, null)
		}));
	}
}
