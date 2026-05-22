using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class APDPAECJPIHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static APDPAECJPIHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBUERQQUVDSlBJSC5wcm90bypkCgtBUERQQUVDSlBJSBIbChdBUERQQUVD" + "SlBJSF9BT0JFREFFSUpLSBAAEhsKF0FQRFBBRUNKUElIX0FMTklCUE9PREtI" + "EAESGwoXQVBEUEFFQ0pQSUhfUFBHS0hQRUFLRk4QAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(APDPAECJPIH) }, null, null));
	}
}
