using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPrivateChatHistoryCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPrivateChatHistoryCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBHZXRQcml2YXRlQ2hhdEhpc3RvcnlDc1JlcS5wcm90byJHChpHZXRQcml2" + "YXRlQ2hhdEhpc3RvcnlDc1JlcRITCgt0YXJnZXRfc2lkZRgCIAEoDRIUCgxj" + "b250YWN0X3NpZGUYBSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPrivateChatHistoryCsReq), GetPrivateChatHistoryCsReq.Parser, new string[2] { "TargetSide", "ContactSide" }, null, null, null, null)
		}));
	}
}
