using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OEMOCFJLGFIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OEMOCFJLGFIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPRU1PQ0ZKTEdGSS5wcm90byJHCgtPRU1PQ0ZKTEdGSRITCgtBQU5FTktJ" + "SUlNRhgBIAEoCRINCgVjb3VudBgCIAEoDRIUCgx0b3RhbF9kYW1hZ2UYAyAB" + "KAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OEMOCFJLGFI), OEMOCFJLGFI.Parser, new string[3] { "AANENKIIIMF", "Count", "TotalDamage" }, null, null, null, null)
		}));
	}
}
