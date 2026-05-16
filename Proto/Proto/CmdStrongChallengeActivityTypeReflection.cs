using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdStrongChallengeActivityTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdStrongChallengeActivityTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "CiRDbWRTdHJvbmdDaGFsbGVuZ2VBY3Rpdml0eVR5cGUucHJvdG8q1wEKHkNt";
		buffer[1] = "ZFN0cm9uZ0NoYWxsZW5nZUFjdGl2aXR5VHlwZRIbChdJQUlGQ01MTURBRl9Q";
		buffer[2] = "Q1BESEVMUEtFTRAAEikKJENtZEVudGVyQWN0aXZpdHlTdHJvbmdDaGFsbGVu";
		buffer[3] = "Z2VDc1JlcRCmNBIuCilDbWRFbnRlclN0cm9uZ0NoYWxsZW5nZUFjdGl2aXR5";
		buffer[4] = "U3RhZ2VTY1JzcBCnNBITCg5DbWRCTUlMSEtDQUtFQRCjNBITCg5DbWRMQkdP";
		buffer[5] = "REFJRU1GQxDSMxITCg5DbWRNR09NQkRHREdDUBDWM0IWqgITTWFyY2g3dGhI";
		buffer[6] = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdStrongChallengeActivityType) }, null, null));
	}
}
