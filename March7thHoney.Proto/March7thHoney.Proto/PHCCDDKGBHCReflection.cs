using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PHCCDDKGBHCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PHCCDDKGBHCReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFQSENDRERLR0JIQy5wcm90bxoRSUdETUJBSUxFSEkucHJvdG8aEU9MSkpK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "QkNLTERLLnByb3RvImYKC1BIQ0NEREtHQkhDEh8KCWJ1ZmZfbGlzdBgDIAMo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "CzIMLk9MSkpKQkNLTERLEiEKC2F2YXRhcl9saXN0GAUgAygLMgwuSUdETUJB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "SUxFSEkSEwoLR0JIUEhDTUdCR0sYCiADKA1CFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			IGDMBAILEHIReflection.Descriptor,
			OLJJJBCKLDKReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PHCCDDKGBHC), PHCCDDKGBHC.Parser, new string[3] { "BuffList", "AvatarList", "GBHPHCMGBGK" }, null, null, null, null)
		}));
	}
}
