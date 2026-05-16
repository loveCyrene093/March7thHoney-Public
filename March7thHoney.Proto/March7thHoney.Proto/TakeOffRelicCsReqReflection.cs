using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeOffRelicCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeOffRelicCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdUYWtlT2ZmUmVsaWNDc1JlcS5wcm90byI/ChFUYWtlT2ZmUmVsaWNDc1Jl" + "cRIXCg9yZWxpY190eXBlX2xpc3QYBCADKA0SEQoJYXZhdGFyX2lkGAYgASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeOffRelicCsReq), TakeOffRelicCsReq.Parser, new string[2] { "RelicTypeList", "AvatarId" }, null, null, null, null)
		}));
	}
}
