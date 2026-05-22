using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AAKHENHMIFMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AAKHENHMIFMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBQUtIRU5ITUlGTS5wcm90byJhCgtBQUtIRU5ITUlGTRITCgtPRkFNQkRF" + "SUNNRRgBIAEoCBITCgtQQkFHSkdNT0xGQhgCIAMoDRITCgtLTkZDQUdGQUhC" + "ShgDIAEoDRITCgtCREVDTERNRE5HSRgEIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AAKHENHMIFM), AAKHENHMIFM.Parser, new string[4] { "OFAMBDEICME", "PBAGJGMOLFB", "KNFCAGFAHBJ", "BDECLDMDNGI" }, null, null, null, null)
		}));
	}
}
