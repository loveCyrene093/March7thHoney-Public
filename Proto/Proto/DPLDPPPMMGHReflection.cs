using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DPLDPPPMMGHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DPLDPPPMMGHReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFEUExEUFBQTU1HSC5wcm90bxoRR0tEREdIQkdHQU0ucHJvdG8aEUtOR0xN";
		buffer[1] = "S0VKQkFCLnByb3RvGhFMRFBMSUpBTUlPRS5wcm90byK8AQoLRFBMRFBQUE1N";
		buffer[2] = "R0gSIQoLT0NESE9HSUxJTU8YASADKAsyDC5MRFBMSUpBTUlPRRIhCgtBSkNF";
		buffer[3] = "TkpPQU1FRBgDIAMoCzIMLkxEUExJSkFNSU9FEiEKC0RJS0NCS0tOSU5NGAUg";
		buffer[4] = "AygLMgwuR0tEREdIQkdHQU0SIQoLQ05MSUFMQlBBQk4YBiABKAsyDC5MRFBM";
		buffer[5] = "SUpBTUlPRRIhCgtERExIUERCSEdKRBgPIAMoCzIMLktOR0xNS0VKQkFCQhaq";
		buffer[6] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			GKDDGHBGGAMReflection.Descriptor,
			KNGLMKEJBABReflection.Descriptor,
			LDPLIJAMIOEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DPLDPPPMMGH), DPLDPPPMMGH.Parser, new string[5] { "OCDHOGILIMO", "AJCENJOAMED", "DIKCBKKNINM", "CNLIALBPABN", "DDLHPDBHGJD" }, null, null, null, null)
		}));
	}
}
