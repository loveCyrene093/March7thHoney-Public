using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ReloginTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ReloginTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFSZWxvZ2luVHlwZS5wcm90bypGCgtSZWxvZ2luVHlwZRILCgdOT19LSUNL" + "EAASDgoKRk9SQ0VfS0lDSxABEg0KCUlETEVfS0lDSxACEgsKB1NJTEVOQ0UQ" + "A0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ReloginType) }, null, null));
	}
}
