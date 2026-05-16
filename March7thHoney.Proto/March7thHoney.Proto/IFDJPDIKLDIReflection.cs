using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IFDJPDIKLDIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IFDJPDIKLDIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJRkRKUERJS0xESS5wcm90byJZCgtJRkRKUERJS0xESRITCgtNT09PUEFN" + "Qk9GSxgCIAEoDRITCgtNRkpDREVLTU5MRxgJIAEoBBIRCgljb25maWdfaWQY" + "CiABKA0SDQoFbGV2ZWwYCyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IFDJPDIKLDI), IFDJPDIKLDI.Parser, new string[4] { "MOOOPAMBOFK", "MFJCDEKMNLG", "ConfigId", "Level" }, null, null, null, null)
		}));
	}
}
