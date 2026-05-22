using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ReceiveReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ReceiveReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg1SZWNlaXZlLnByb3RvGhFNQUxHSEtNQktPSy5wcm90byI9CgdSZWNlaXZl" + "Eg8KB3JldGNvZGUYAyABKA0SIQoLZnJpZW5kX2xpc3QYDiADKAsyDC5NQUxH" + "SEtNQktPS0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { MALGHKMBKOKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Receive), Receive.Parser, new string[2] { "Retcode", "FriendList" }, null, null, null, null)
		}));
	}
}
