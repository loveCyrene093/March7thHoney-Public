using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueDiceTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueDiceTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhDaGVzc1JvZ3VlRGljZVR5cGUucHJvdG8qTgoSQ2hlc3NSb2d1ZURpY2VU" + "eXBlEhsKF0hCQ09LRElKTUJLX0lDSkxHSExPS0ZHEAASGwoXSEJDT0tESUpN" + "QktfT0hHR0NLTExMRVAQAUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ChessRogueDiceType) }, null, null));
	}
}
