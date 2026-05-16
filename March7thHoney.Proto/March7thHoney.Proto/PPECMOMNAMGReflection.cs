using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PPECMOMNAMGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PPECMOMNAMGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQUEVDTU9NTkFNRy5wcm90bxoVQXJlYUR5bmFtaWNJbmZvLnByb3RvIkUK" + "C1BQRUNNT01OQU1HEiUKC0FJSUZGSkFFT0RKGAcgASgLMhAuQXJlYUR5bmFt" + "aWNJbmZvEg8KB2FyZWFfaWQYCiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[1] { AreaDynamicInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PPECMOMNAMG), PPECMOMNAMG.Parser, new string[2] { "AIIFFJAEODJ", "AreaId" }, null, null, null, null)
		}));
	}
}
