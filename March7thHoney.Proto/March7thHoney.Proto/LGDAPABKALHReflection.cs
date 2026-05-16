using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LGDAPABKALHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LGDAPABKALHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMR0RBUEFCS0FMSC5wcm90byIiCgtMR0RBUEFCS0FMSBITCgtESU5NS0VJ" + "SU5MTRgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LGDAPABKALH), LGDAPABKALH.Parser, new string[1] { "DINMKEIINLM" }, null, null, null, null)
		}));
	}
}
