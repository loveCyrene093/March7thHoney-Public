using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeBenefitActivityRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeBenefitActivityRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRUYWtlQmVuZWZpdEFjdGl2aXR5UmV3YXJkQ3NSZXEucHJvdG8aEUlJSktJ" + "TEZKRU5MLnByb3RvIlgKHlRha2VCZW5lZml0QWN0aXZpdHlSZXdhcmRDc1Jl" + "cRITCgtGSEZNTk9HQU1IQRgBIAEoCBIhCgtzd2l0Y2hfbGlzdBgDIAMoCzIM" + "LklJSktJTEZKRU5MQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { IIJKILFJENLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeBenefitActivityRewardCsReq), TakeBenefitActivityRewardCsReq.Parser, new string[2] { "FHFMNOGAMHA", "SwitchList" }, null, null, null, null)
		}));
	}
}
