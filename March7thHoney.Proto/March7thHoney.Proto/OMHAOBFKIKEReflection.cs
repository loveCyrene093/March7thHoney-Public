using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OMHAOBFKIKEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OMHAOBFKIKEReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFPTUhBT0JGS0lLRS5wcm90bxoRTURJS0FPQUVKSE4ucHJvdG8aEU1HR0xE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "SEhQTkJNLnByb3RvImYKC09NSEFPQkZLSUtFEiEKC0hJTUVDTUdKS09NGAIg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ASgOMgwuTURJS0FPQUVKSE4SIQoLQUFHQkxQS0RKSlAYBSABKAsyDC5NR0dM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "REhIUE5CTRIRCglhdmF0YXJfaWQYDCABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			MDIKAOAEJHNReflection.Descriptor,
			MGGLDHHPNBMReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OMHAOBFKIKE), OMHAOBFKIKE.Parser, new string[3] { "HIMECMGJKOM", "AAGBLPKDJJP", "AvatarId" }, null, null, null, null)
		}));
	}
}
