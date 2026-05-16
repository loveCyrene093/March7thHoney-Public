using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DPENFEFPEBIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DPENFEFPEBIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEUEVORkVGUEVCSS5wcm90bypkCgtEUEVORkVGUEVCSRIbChdEUEVORkVG" + "UEVCSV9LSEVFSkJCUElDRBAAEhsKF0RQRU5GRUZQRUJJX0RBQkdQQk1LR0pC" + "EAESGwoXRFBFTkZFRlBFQklfRExFQ0hHTktPTUIQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(DPENFEFPEBI) }, null, null));
	}
}
