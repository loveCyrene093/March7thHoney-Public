using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EINJLBBAGDLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EINJLBBAGDLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFSU5KTEJCQUdETC5wcm90byIyCgtFSU5KTEJCQUdETBITCgtEUEJNQUZC" + "QUpIRBgCIAEoDRIOCgZtYXBfaWQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EINJLBBAGDL), EINJLBBAGDL.Parser, new string[2] { "DPBMAFBAJHD", "MapId" }, null, null, null, null)
		}));
	}
}
