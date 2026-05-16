using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GGFCMMIFOHMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GGFCMMIFOHMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHR0ZDTU1JRk9ITS5wcm90bypkCgtHR0ZDTU1JRk9ITRIbChdHR0ZDTU1J" + "Rk9ITV9ESkdNSU1DSENNQhAAEhsKF0dHRkNNTUlGT0hNX09DTk5CRkZHQUxE" + "EAESGwoXR0dGQ01NSUZPSE1fQkNET0lFTE9BTk4QAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GGFCMMIFOHM) }, null, null));
	}
}
