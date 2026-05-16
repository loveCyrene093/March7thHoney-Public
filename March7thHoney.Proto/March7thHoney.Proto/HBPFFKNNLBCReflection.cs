using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HBPFFKNNLBCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HBPFFKNNLBCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQlBGRktOTkxCQy5wcm90byJiCgtIQlBGRktOTkxCQxIQCghwYW5lbF9p" + "ZBgDIAEoDRITCgtLQVBHSFBORU9FSxgGIAEoDRITCgtDTkpFRUtLTUxKSxgH" + "IAEoCBIXCg9pc190YWtlbl9yZXdhcmQYCyABKAhCFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HBPFFKNNLBC), HBPFFKNNLBC.Parser, new string[4] { "PanelId", "KAPGHPNEOEK", "CNJEEKKMLJK", "IsTakenReward" }, null, null, null, null)
		}));
	}
}
