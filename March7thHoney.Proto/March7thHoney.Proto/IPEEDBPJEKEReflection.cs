using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IPEEDBPJEKEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IPEEDBPJEKEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJUEVFREJQSkVLRS5wcm90bypkCgtJUEVFREJQSkVLRRIbChdJUEVFREJQ" + "SkVLRV9QQ1BESEVMUEtFTRAAEhsKF0lQRUVEQlBKRUtFX0NCSU1MRkpHT0lJ" + "EAESGwoXSVBFRURCUEpFS0VfSU5OSEFJRE9HTkYQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(IPEEDBPJEKE) }, null, null));
	}
}
