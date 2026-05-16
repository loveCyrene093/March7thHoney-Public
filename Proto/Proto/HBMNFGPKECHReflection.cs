using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HBMNFGPKECHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HBMNFGPKECHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQk1ORkdQS0VDSC5wcm90byJvCgtIQk1ORkdQS0VDSBITCgtESkRFQktQ" + "R0pEThgBIAMoDRITCgtDRENCRkhGSkdNRBgGIAEoDRIMCgR0aW1lGAcgASgD" + "EhMKC0pGSE1DREZEQUJJGAggASgIEhMKC1BIQUxLREhIUFBCGA0gASgEQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HBMNFGPKECH), HBMNFGPKECH.Parser, new string[5] { "DJDEBKPGJDN", "CDCBFHFJGMD", "Time", "JFHMCDFDABI", "PHALKDHHPPB" }, null, null, null, null)
		}));
	}
}
