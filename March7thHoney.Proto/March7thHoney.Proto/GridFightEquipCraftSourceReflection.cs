using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightEquipCraftSourceReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightEquipCraftSourceReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch9HcmlkRmlnaHRFcXVpcENyYWZ0U291cmNlLnByb3RvKo8BChlHcmlkRmln";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "aHRFcXVpcENyYWZ0U291cmNlEhsKF0JOTUxFUENOQ0lIX0FJQUxQREVKSUpL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EAASGwoXQk5NTEVQQ05DSUhfTEhOTU1DRkNKR0QQARIbChdCTk1MRVBDTkNJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "SF9BTElOSkROR0tDRRACEhsKF0JOTUxFUENOQ0lIX0hHRUFFRUdNQkFQEANC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GridFightEquipCraftSource) }, null, null));
	}
}
