using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HKLCEEEJIGOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HKLCEEEJIGOReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFIS0xDRUVFSklHTy5wcm90bxoRSUdLS0ZQREhKTEsucHJvdG8aEU9NSkxM";
		buffer[1] = "SUxHQUVQLnByb3RvIogBCgtIS0xDRUVFSklHTxITCgtJQ0lMQk5ESURHUBgE";
		buffer[2] = "IAEoCBIRCgl1bmlxdWVfaWQYBiABKAUSIQoLSEROR0pLS0xMUE0YByABKAsy";
		buffer[3] = "DC5JR0tLRlBESEpMSxIZCgNwb3MYCCABKAsyDC5PTUpMTElMR0FFUBITCgtK";
		buffer[4] = "TUlFTkJCTVBBRxgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[5] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			IGKKFPDHJLKReflection.Descriptor,
			OMJLLILGAEPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HKLCEEEJIGO), HKLCEEEJIGO.Parser, new string[5] { "ICILBNDIDGP", "UniqueId", "HDNGJKKLLPM", "Pos", "JMIENBBMPAG" }, null, null, null, null)
		}));
	}
}
