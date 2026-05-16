using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BuyBpLevelCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BuyBpLevelCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVCdXlCcExldmVsQ3NSZXEucHJvdG8iJgoPQnV5QnBMZXZlbENzUmVxEhMK" + "C09EQURKSUxPRUtPGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BuyBpLevelCsReq), BuyBpLevelCsReq.Parser, new string[1] { "ODADJILOEKO" }, null, null, null, null)
		}));
	}
}
