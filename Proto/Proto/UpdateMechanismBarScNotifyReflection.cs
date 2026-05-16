using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateMechanismBarScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateMechanismBarScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiBVcGRhdGVNZWNoYW5pc21CYXJTY05vdGlmeS5wcm90bxoRTUNCRUtMT0tH";
		buffer[1] = "Q0QucHJvdG8iYwoaVXBkYXRlTWVjaGFuaXNtQmFyU2NOb3RpZnkSEAoIZmxv";
		buffer[2] = "b3JfaWQYBSABKA0SIQoLR01LRUFDQk1PSkEYCCABKAsyDC5NQ0JFS0xPS0dD";
		buffer[3] = "RBIQCghwbGFuZV9pZBgJIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[4] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MCBEKLOKGCDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateMechanismBarScNotify), UpdateMechanismBarScNotify.Parser, new string[3] { "FloorId", "GMKEACBMOJA", "PlaneId" }, null, null, null, null)
		}));
	}
}
