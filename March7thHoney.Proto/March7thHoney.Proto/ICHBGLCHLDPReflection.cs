using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ICHBGLCHLDPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ICHBGLCHLDPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJQ0hCR0xDSExEUC5wcm90bxoRS0RDSU1DRU5DR1AucHJvdG8iMAoLSUNI" + "QkdMQ0hMRFASIQoLTE5GSE5JSkpGTU0YByADKAsyDC5LRENJTUNFTkNHUEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { KDCIMCENCGPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ICHBGLCHLDP), ICHBGLCHLDP.Parser, new string[1] { "LNFHNIJJFMM" }, null, null, null, null)
		}));
	}
}
