using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GJKOPKLDFGBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GJKOPKLDFGBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHSktPUEtMREZHQi5wcm90bxoOSXRlbUxpc3QucHJvdG8iXQoLR0pLT1BL" + "TERGR0ISDwoHcmV0Y29kZRgCIAEoDRINCgVsZXZlbBgFIAEoDRITCgtMR0hP" + "T0tNTk1DTBgLIAEoDRIZCgZyZXdhcmQYDyABKAsyCS5JdGVtTGlzdEIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GJKOPKLDFGB), GJKOPKLDFGB.Parser, new string[4] { "Retcode", "Level", "LGHOOKMNMCL", "Reward" }, null, null, null, null)
		}));
	}
}
