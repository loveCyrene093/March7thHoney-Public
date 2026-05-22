using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NpcStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NpcStatusReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg9OcGNTdGF0dXMucHJvdG8iLgoJTnBjU3RhdHVzEg4KBm5wY19pZBgEIAEo" + "DRIRCglpc19maW5pc2gYDyABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NpcStatus), NpcStatus.Parser, new string[2] { "NpcId", "IsFinish" }, null, null, null, null)
		}));
	}
}
