using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class QuickStartFarmElementCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static QuickStartFarmElementCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBRdWlja1N0YXJ0RmFybUVsZW1lbnRDc1JlcS5wcm90byJXChpRdWlja1N0" + "YXJ0RmFybUVsZW1lbnRDc1JlcRINCgVDb3VudBgCIAEoDRITCgt3b3JsZF9s" + "ZXZlbBgJIAEoDRIVCg1GYXJtRWxlbWVudElkGA8gASgNQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(QuickStartFarmElementCsReq), QuickStartFarmElementCsReq.Parser, new string[3] { "Count", "WorldLevel", "FarmElementId" }, null, null, null, null)
		}));
	}
}
