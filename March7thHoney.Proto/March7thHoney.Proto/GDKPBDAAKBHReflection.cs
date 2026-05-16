using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GDKPBDAAKBHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GDKPBDAAKBHReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFHREtQQkRBQUtCSC5wcm90byKLAQoLR0RLUEJEQUFLQkgSEwoLTVBKUEJM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "TENNSEsYBCABKA0SEwoLREdHQUlFQU5OQkoYByABKA0SEwoLSUdGSEVHQkNH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "QkgYCCABKA0SEwoLRkVMQUFEQk9BS0QYCyABKA0SEwoLRFBFSk5HTkJIRE0Y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "DSADKA0SEwoLREhGR0xMQUlGSFAYDyABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GDKPBDAAKBH), GDKPBDAAKBH.Parser, new string[6] { "MPJPBLLCMHK", "DGGAIEANNBJ", "IGFHEGBCGBH", "FELAADBOAKD", "DPEJNGNBHDM", "DHFGLLAIFHP" }, null, null, null, null)
		}));
	}
}
