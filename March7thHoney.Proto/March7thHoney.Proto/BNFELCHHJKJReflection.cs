using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BNFELCHHJKJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BNFELCHHJKJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCTkZFTENISEpLSi5wcm90byINCgtCTkZFTENISEpLSkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BNFELCHHJKJ), BNFELCHHJKJ.Parser, null, null, null, null, null)
		}));
	}
}
