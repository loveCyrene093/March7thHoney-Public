using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NLHIJPEAMPJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NLHIJPEAMPJReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFOTEhJSlBFQU1QSi5wcm90bxoRUENISkFCQUZBREgucHJvdG8ibwoLTkxI";
		buffer[1] = "SUpQRUFNUEoSEwoLUENPSFBHR1BJSUMYAiADKA0SIQoLQk5PRENGSEhOSEwY";
		buffer[2] = "CCABKAsyDC5QQ0hKQUJBRkFESBITCgtDSUNQSEZORUpFQhgLIAMoDRITCgtP";
		buffer[3] = "RkhDTkdISkZISRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { PCHJABAFADHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NLHIJPEAMPJ), NLHIJPEAMPJ.Parser, new string[4] { "PCOHPGGPIIC", "BNODCFHHNHL", "CICPHFNEJEB", "OFHCNGHJFHI" }, null, null, null, null)
		}));
	}
}
