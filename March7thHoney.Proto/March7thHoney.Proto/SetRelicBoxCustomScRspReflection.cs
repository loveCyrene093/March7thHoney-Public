using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetRelicBoxCustomScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetRelicBoxCustomScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxTZXRSZWxpY0JveEN1c3RvbVNjUnNwLnByb3RvIikKFlNldFJlbGljQm94" + "Q3VzdG9tU2NSc3ASDwoHcmV0Y29kZRgFIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetRelicBoxCustomScRsp), SetRelicBoxCustomScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
