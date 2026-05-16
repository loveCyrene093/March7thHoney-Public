using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FriendOnlineStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FriendOnlineStatusReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhGcmllbmRPbmxpbmVTdGF0dXMucHJvdG8qVwoSRnJpZW5kT25saW5lU3Rh" + "dHVzEiAKHEZSSUVORF9PTkxJTkVfU1RBVFVTX09GRkxJTkUQABIfChtGUklF" + "TkRfT05MSU5FX1NUQVRVU19PTkxJTkUQAUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FriendOnlineStatus) }, null, null));
	}
}
