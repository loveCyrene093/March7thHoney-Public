using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AKEKHLAEKBCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AKEKHLAEKBCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBS0VLSExBRUtCQy5wcm90byI3CgtBS0VLSExBRUtCQxITCgtJQ0ROSVBI" + "TEZGQxgEIAEoDRITCgtDTkRLQVBPSUVPShgKIAEoCEIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AKEKHLAEKBC), AKEKHLAEKBC.Parser, new string[2] { "ICDNIPHLFFC", "CNDKAPOIEOJ" }, null, null, null, null)
		}));
	}
}
