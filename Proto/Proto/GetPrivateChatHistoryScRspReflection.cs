using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPrivateChatHistoryScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPrivateChatHistoryScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiBHZXRQcml2YXRlQ2hhdEhpc3RvcnlTY1JzcC5wcm90bxoVQ2hhdE1lc3Nh";
		buffer[1] = "Z2VEYXRhLnByb3RvIoUBChpHZXRQcml2YXRlQ2hhdEhpc3RvcnlTY1JzcBIU";
		buffer[2] = "Cgxjb250YWN0X3NpZGUYAiABKA0SEwoLdGFyZ2V0X3NpZGUYBCABKA0SDwoH";
		buffer[3] = "cmV0Y29kZRgJIAEoDRIrChFjaGF0X21lc3NhZ2VfbGlzdBgNIAMoCzIQLkNo";
		buffer[4] = "YXRNZXNzYWdlRGF0YUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ChatMessageDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPrivateChatHistoryScRsp), GetPrivateChatHistoryScRsp.Parser, new string[4] { "ContactSide", "TargetSide", "Retcode", "ChatMessageList" }, null, null, null, null)
		}));
	}
}
