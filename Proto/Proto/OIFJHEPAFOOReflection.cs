using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OIFJHEPAFOOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OIFJHEPAFOOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPSUZKSEVQQUZPTy5wcm90bxoRR0ZOTUFLSFBBT0UucHJvdG8iMAoLT0lG" + "SkhFUEFGT08SIQoLT05KS0JFTk5NRkMYASABKAsyDC5HRk5NQUtIUEFPRUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GFNMAKHPAOEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OIFJHEPAFOO), OIFJHEPAFOO.Parser, new string[1] { "ONJKBENNMFC" }, null, null, null, null)
		}));
	}
}
