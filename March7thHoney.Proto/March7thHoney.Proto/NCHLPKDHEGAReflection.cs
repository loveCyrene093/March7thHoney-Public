using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NCHLPKDHEGAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NCHLPKDHEGAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQ0hMUEtESEVHQS5wcm90byI+CgtOQ0hMUEtESEVHQRITCgtEUEhPQVBQ" + "Q0JIQhgBIAEoDRINCgVsZXZlbBgCIAEoDRILCgNleHAYAyABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NCHLPKDHEGA), NCHLPKDHEGA.Parser, new string[3] { "DPHOAPPCBHB", "Level", "Exp" }, null, null, null, null)
		}));
	}
}
