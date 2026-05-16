using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdHeartdialTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdHeartdialTypeReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		buffer[0] = "ChZDbWRIZWFydGRpYWxUeXBlLnByb3RvKrwDChBDbWRIZWFydGRpYWxUeXBl";
		buffer[1] = "EhsKF05JT0ZESUZBREVLX1BDUERIRUxQS0VNEAASHgoZQ21kU3VibWl0RW1v";
		buffer[2] = "dGlvbkl0ZW1Dc1JlcRCqMRIhChxDbWRIZWFydERpYWxUcmFjZVNjcmlwdENz";
		buffer[3] = "UmVxELYxEh4KGUNtZFN1Ym1pdEVtb3Rpb25JdGVtU2NSc3AQrjESJQogQ21k";
		buffer[4] = "SGVhcnREaWFsU2NyaXB0Q2hhbmdlU2NOb3RpZnkQ2zESHQoYQ21kR2V0SGVh";
		buffer[5] = "cnREaWFsSW5mb0NzUmVxEPcxEiEKHENtZEhlYXJ0RGlhbFRyYWNlU2NyaXB0";
		buffer[6] = "U2NSc3AQwzESIAobQ21kQ2hhbmdlU2NyaXB0RW1vdGlvbkNzUmVxEPoxEi0K";
		buffer[7] = "KENtZEZpbmlzaEVtb3Rpb25EaWFsb2d1ZVBlcmZvcm1hbmNlU2NSc3AQ/jES";
		buffer[8] = "IAobQ21kQ2hhbmdlU2NyaXB0RW1vdGlvblNjUnNwEPsxEi0KKENtZEZpbmlz";
		buffer[9] = "aEVtb3Rpb25EaWFsb2d1ZVBlcmZvcm1hbmNlQ3NSZXEQpTESHQoYQ21kR2V0";
		buffer[10] = "SGVhcnREaWFsSW5mb1NjUnNwEKYxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[11] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdHeartdialType) }, null, null));
	}
}
