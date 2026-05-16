using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PGOGPOHEIEGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PGOGPOHEIEGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQR09HUE9IRUlFRy5wcm90byJKCgtQR09HUE9IRUlFRxITCgtGSUZIS05I" + "RUlCRBgBIAEoDRITCgtFTEhJQUJHQ0tJRRgCIAEoDRIRCgllbnRpdHlfaWQY" + "AyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PGOGPOHEIEG), PGOGPOHEIEG.Parser, new string[3] { "FIFHKNHEIBD", "ELHIABGCKIE", "EntityId" }, null, null, null, null)
		}));
	}
}
