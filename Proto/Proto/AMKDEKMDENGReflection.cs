using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AMKDEKMDENGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AMKDEKMDENGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBTUtERUtNREVORy5wcm90byI+CgtBTUtERUtNREVORxIMCgRzbG90GAMg" + "ASgNEhMKC05DSEhPUEpKRENFGAYgASgNEgwKBHR5cGUYCSABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AMKDEKMDENG), AMKDEKMDENG.Parser, new string[3] { "Slot", "NCHHOPJJDCE", "Type" }, null, null, null, null)
		}));
	}
}
