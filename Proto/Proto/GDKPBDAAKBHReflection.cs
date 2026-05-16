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
		buffer[0] = "ChFHREtQQkRBQUtCSC5wcm90byKLAQoLR0RLUEJEQUFLQkgSEwoLTVBKUEJM";
		buffer[1] = "TENNSEsYBCABKA0SEwoLREdHQUlFQU5OQkoYByABKA0SEwoLSUdGSEVHQkNH";
		buffer[2] = "QkgYCCABKA0SEwoLRkVMQUFEQk9BS0QYCyABKA0SEwoLRFBFSk5HTkJIRE0Y";
		buffer[3] = "DSADKA0SEwoLREhGR0xMQUlGSFAYDyABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		buffer[4] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GDKPBDAAKBH), GDKPBDAAKBH.Parser, new string[6] { "MPJPBLLCMHK", "DGGAIEANNBJ", "IGFHEGBCGBH", "FELAADBOAKD", "DPEJNGNBHDM", "DHFGLLAIFHP" }, null, null, null, null)
		}));
	}
}
