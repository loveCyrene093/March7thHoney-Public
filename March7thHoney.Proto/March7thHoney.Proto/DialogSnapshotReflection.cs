using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DialogSnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DialogSnapshotReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChREaWFsb2dTbmFwc2hvdC5wcm90byI1Cg5EaWFsb2dTbmFwc2hvdBIQCghn" + "cm91cF9pZBgBIAEoDRIRCgllbnRpdHlfaWQYAiABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DialogSnapshot), DialogSnapshot.Parser, new string[2] { "GroupId", "EntityId" }, null, null, null, null)
		}));
	}
}
