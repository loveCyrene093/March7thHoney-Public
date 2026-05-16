using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JMCJBDELOKJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JMCJBDELOKJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKTUNKQkRFTE9LSi5wcm90bxoRTk9KTk1BSUFDR0IucHJvdG8iMAoLSk1D" + "SkJERUxPS0oSIQoLTU9GSktMSExETUQYBCADKAsyDC5OT0pOTUFJQUNHQkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { NOJNMAIACGBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JMCJBDELOKJ), JMCJBDELOKJ.Parser, new string[1] { "MOFJKLHLDMD" }, null, null, null, null)
		}));
	}
}
