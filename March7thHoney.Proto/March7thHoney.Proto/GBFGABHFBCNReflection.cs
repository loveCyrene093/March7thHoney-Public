using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GBFGABHFBCNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GBFGABHFBCNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHQkZHQUJIRkJDTi5wcm90bxoRTkJNRk9KQUtNR1AucHJvdG8iQAoLR0JG" + "R0FCSEZCQ04SDwoHcmV0Y29kZRgEIAEoDRIgCgpyZWxpY19wbGFuGAggASgL" + "MgwuTkJNRk9KQUtNR1BCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[1] { NBMFOJAKMGPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GBFGABHFBCN), GBFGABHFBCN.Parser, new string[2] { "Retcode", "RelicPlan" }, null, null, null, null)
		}));
	}
}
