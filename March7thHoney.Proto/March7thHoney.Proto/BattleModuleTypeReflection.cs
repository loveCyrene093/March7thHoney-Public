using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleModuleTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleModuleTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChZCYXR0bGVNb2R1bGVUeXBlLnByb3RvKt0BChBCYXR0bGVNb2R1bGVUeXBl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "EhsKF0lOSFBESExPSEhPX0hBSkRBS0ZJRU5NEAASGwoXSU5IUERITE9ISE9f";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "S0tITE1LSVBNRksQARIbChdJTkhQREhMT0hIT19MSEdPRExBQkVLSBACEhsK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "F0lOSFBESExPSEhPX0xKT1BBUEFLSElQEAMSGwoXSU5IUERITE9ISE9fRk5K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "SElPQ0pITE8QBBIbChdJTkhQREhMT0hIT19BRU5MUFBBRUFOSxAFEhsKF0lO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "SFBESExPSEhPX0VETE9FQkVKRkhOEAZCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(BattleModuleType) }, null, null));
	}
}
