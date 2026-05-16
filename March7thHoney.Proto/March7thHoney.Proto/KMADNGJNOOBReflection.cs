using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KMADNGJNOOBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KMADNGJNOOBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLTUFETkdKTk9PQi5wcm90byJeCgtLTUFETkdKTk9PQhITCgtIQ0hDT0FQ" + "SkxNRxgDIAEoDRITCgtNREZNRURLTkVIRxgGIAEoDRIQCghncm91cF9pZBgI" + "IAEoDRITCgtNT09PUEFNQk9GSxgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KMADNGJNOOB), KMADNGJNOOB.Parser, new string[4] { "HCHCOAPJLMG", "MDFMEDKNEHG", "GroupId", "MOOOPAMBOFK" }, null, null, null, null)
		}));
	}
}
