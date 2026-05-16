using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GEMAIGNDNPKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GEMAIGNDNPKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHRU1BSUdORE5QSy5wcm90byIiCgtHRU1BSUdORE5QSxITCgtET01HTEhJ" + "S0pFRBgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GEMAIGNDNPK), GEMAIGNDNPK.Parser, new string[1] { "DOMGLHIKJED" }, null, null, null, null)
		}));
	}
}
