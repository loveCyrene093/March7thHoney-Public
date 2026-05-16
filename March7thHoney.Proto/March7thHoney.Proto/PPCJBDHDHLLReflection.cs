using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PPCJBDHDHLLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PPCJBDHDHLLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQUENKQkRIREhMTC5wcm90byJHCgtQUENKQkRIREhMTBITCgtFSkFBUElL" + "TE1ORBgKIAEoDRIQCgh0cmFpdF9pZBgLIAEoDRIRCgllZmZlY3RfaWQYDiAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PPCJBDHDHLL), PPCJBDHDHLL.Parser, new string[3] { "EJAAPIKLMND", "TraitId", "EffectId" }, null, null, null, null)
		}));
	}
}
