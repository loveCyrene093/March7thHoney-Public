using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ExpUpRelicScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ExpUpRelicScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVFeHBVcFJlbGljU2NSc3AucHJvdG8aDlBpbGVJdGVtLnByb3RvIkcKD0V4" + "cFVwUmVsaWNTY1JzcBIjChByZXR1cm5faXRlbV9saXN0GAogAygLMgkuUGls" + "ZUl0ZW0SDwoHcmV0Y29kZRgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[1] { PileItemReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ExpUpRelicScRsp), ExpUpRelicScRsp.Parser, new string[2] { "ReturnItemList", "Retcode" }, null, null, null, null)
		}));
	}
}
