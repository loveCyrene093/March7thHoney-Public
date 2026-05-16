using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IEKNGDDPMAEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IEKNGDDPMAEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJRUtOR0REUE1BRS5wcm90byI3CgtJRUtOR0REUE1BRRITCgtPRERGRUFF" + "RUpKRBgGIAEoDRITCgtPR0tORUJHREVGThgHIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IEKNGDDPMAE), IEKNGDDPMAE.Parser, new string[2] { "ODDFEAEEJJD", "OGKNEBGDEFN" }, null, null, null, null)
		}));
	}
}
