using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BIELAAMEPDKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BIELAAMEPDKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCSUVMQUFNRVBESy5wcm90bxoRSUxMQk5LRkJOQlAucHJvdG8iRQoLQklF" + "TEFBTUVQREsSEwoLSEFPUEVLUEtPRkkYAyABKAgSIQoLTkxLTkVFTkZIQU0Y" + "CSABKAsyDC5JTExCTktGQk5CUEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { ILLBNKFBNBPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BIELAAMEPDK), BIELAAMEPDK.Parser, new string[2] { "HAOPEKPKOFI", "NLKNEENFHAM" }, null, null, null, null)
		}));
	}
}
