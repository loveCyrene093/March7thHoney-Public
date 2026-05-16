using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MOFDANDCGHJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MOFDANDCGHJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNT0ZEQU5EQ0dISi5wcm90bxoRRkpESUxFR0NCSFAucHJvdG8iWgoLTU9G" + "REFORENHSEoSEwoLR0ZJSkpOTkFLR1AYBSABKA0SEwoLR1BFTU1DTUpQUEQY" + "BiABKA0SIQoLQUxGSE5FSE9CSkEYByABKA4yDC5GSkRJTEVHQ0JIUEIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { FJDILEGCBHPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MOFDANDCGHJ), MOFDANDCGHJ.Parser, new string[3] { "GFIJJNNAKGP", "GPEMMCMJPPD", "ALFHNEHOBJA" }, null, null, null, null)
		}));
	}
}
