using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightDamageSttInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightDamageSttInfoReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChxHcmlkRmlnaHREYW1hZ2VTdHRJbmZvLnByb3RvGhFEQUNKRE1QSUNFTC5w";
		buffer[1] = "cm90bxoRRUxBR0NMTU9GRkkucHJvdG8aEUhISE1NSkJHQ05HLnByb3RvIoEB";
		buffer[2] = "ChZHcmlkRmlnaHREYW1hZ2VTdHRJbmZvEiEKC0VBQlBDS0VEREJIGAEgAygL";
		buffer[3] = "MgwuSEhITU1KQkdDTkcSIQoLTU9JRExORktBSUMYAyADKAsyDC5FTEFHQ0xN";
		buffer[4] = "T0ZGSRIhCgtQSERFT1BFSklJRBgNIAMoCzIMLkRBQ0pETVBJQ0VMQhaqAhNN";
		buffer[5] = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			DACJDMPICELReflection.Descriptor,
			ELAGCLMOFFIReflection.Descriptor,
			HHHMMJBGCNGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightDamageSttInfo), GridFightDamageSttInfo.Parser, new string[3] { "EABPCKEDDBH", "MOIDLNFKAIC", "PHDEOPEJIID" }, null, null, null, null)
		}));
	}
}
