using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KAONKHLDGPBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KAONKHLDGPBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLQU9OS0hMREdQQi5wcm90byJICgtLQU9OS0hMREdQQhITCgtBSUtNUE1L" + "Rk1QSBgBIAEoDRITCgtJS0tGRE9ITUNHTRgHIAEoDRIPCgdhcmVhX2lkGAog" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KAONKHLDGPB), KAONKHLDGPB.Parser, new string[3] { "AIKMPMKFMPH", "IKKFDOHMCGM", "AreaId" }, null, null, null, null)
		}));
	}
}
