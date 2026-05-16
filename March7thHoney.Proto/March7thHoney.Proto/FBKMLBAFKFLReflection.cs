using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FBKMLBAFKFLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FBKMLBAFKFLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGQktNTEJBRktGTC5wcm90bxoRQUxFT0lMQ0lGSU4ucHJvdG8iMAoLRkJL" + "TUxCQUZLRkwSIQoLQ0VBS09PQU9KTEYYDyABKAsyDC5BTEVPSUxDSUZJTkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ALEOILCIFINReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FBKMLBAFKFL), FBKMLBAFKFL.Parser, new string[1] { "CEAKOOAOJLF" }, null, null, null, null)
		}));
	}
}
