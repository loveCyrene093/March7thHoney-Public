using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AAEFGPIIHLKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AAEFGPIIHLKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBQUVGR1BJSUhMSy5wcm90byJ9CgtBQUVGR1BJSUhMSxITCgtNT09PUEFN" + "Qk9GSxgBIAEoDRINCgVsZXZlbBgCIAEoDRITCgtEREFPQkZKRk1MTBgDIAMo" + "DRITCgtOQkJISUhBT0xKRRgLIAMoDRILCgNleHAYDSABKA0SEwoLTEdIT09L" + "TU5NQ0wYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AAEFGPIIHLK), AAEFGPIIHLK.Parser, new string[6] { "MOOOPAMBOFK", "Level", "DDAOBFJFMLL", "NBBHIHAOLJE", "Exp", "LGHOOKMNMCL" }, null, null, null, null)
		}));
	}
}
