using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FCFFJAPIIFLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FCFFJAPIIFLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGQ0ZGSkFQSUlGTC5wcm90bxoRRkdQRUZFRUxPQ08ucHJvdG8iRQoLRkNG" + "RkpBUElJRkwSEwoLT01JQUhOQUVOS00YBCABKA0SIQoLSktQQURQSENPSkoY" + "CSADKAsyDC5GR1BFRkVFTE9DT0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { FGPEFEELOCOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FCFFJAPIIFL), FCFFJAPIIFL.Parser, new string[2] { "OMIAHNAENKM", "JKPADPHCOJJ" }, null, null, null, null)
		}));
	}
}
