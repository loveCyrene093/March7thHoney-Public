using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GEEMGPFMHHIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GEEMGPFMHHIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHRUVNR1BGTUhISS5wcm90bypkCgtHRUVNR1BGTUhISRIbChdHRUVNR1BG" + "TUhISV9MSEdBQkNPSUdKQRAAEhsKF0dFRU1HUEZNSEhJX0lJT09BSkFOTUdH" + "EAESGwoXR0VFTUdQRk1ISElfSENNSktCREtKTksQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GEEMGPFMHHI) }, null, null));
	}
}
