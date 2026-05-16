using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdBenefitV2ActivityTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdBenefitV2ActivityTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "Ch5DbWRCZW5lZml0VjJBY3Rpdml0eVR5cGUucHJvdG8q0AEKGENtZEJlbmVm";
		buffer[1] = "aXRWMkFjdGl2aXR5VHlwZRIbChdITkRGT0xLT0lHSV9QQ1BESEVMUEtFTRAA";
		buffer[2] = "EhMKDkNtZE1FS0NQSk1HQ09DEONMEhwKF0hOREZPTEtPSUdJX0pNUFBPRk1G";
		buffer[3] = "QUZOEN1MEhwKF0hOREZPTEtPSUdJX0xCTEhLSEVPSkRJEOFMEhMKDkNtZEtP";
		buffer[4] = "S1BES09MQkxFEOZMEhMKDkNtZEVBQ0tNRkhOS0NCEOBMEhwKF0hOREZPTEtP";
		buffer[5] = "SUdJX0hFRkdGREFBRkNJEOVMQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[6] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdBenefitV2ActivityType) }, null, null));
	}
}
