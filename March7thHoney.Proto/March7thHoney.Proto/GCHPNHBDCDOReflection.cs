using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GCHPNHBDCDOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GCHPNHBDCDOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHQ0hQTkhCRENETy5wcm90bypkCgtHQ0hQTkhCRENETxIbChdHQ0hQTkhC" + "RENET19CRktGREtNR0xITxAAEhsKF0dDSFBOSEJEQ0RPX05PRkdBSUlQSURL" + "EAESGwoXR0NIUE5IQkRDRE9fR05HR0VQTElNSkUQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GCHPNHBDCDO) }, null, null));
	}
}
