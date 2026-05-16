using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyMoveCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyMoveCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdNb25vcG9seU1vdmVDc1JlcS5wcm90byI9ChFNb25vcG9seU1vdmVDc1Jl" + "cRITCgtIQ09ISUxCQUxHRxgHIAEoDRITCgtJRktMRUdDTFBFRRgJIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyMoveCsReq), MonopolyMoveCsReq.Parser, new string[2] { "HCOHILBALGG", "IFKLEGCLPEE" }, null, null, null, null)
		}));
	}
}
