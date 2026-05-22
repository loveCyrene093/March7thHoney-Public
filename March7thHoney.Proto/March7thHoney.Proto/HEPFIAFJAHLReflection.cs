using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HEPFIAFJAHLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HEPFIAFJAHLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIRVBGSUFGSkFITC5wcm90byJxCgtIRVBGSUFGSkFITBIRCgllZmZlY3Rf" + "aWQYAiABKA0SEwoLREpCTEZHRkROQ0EYAyADKA0SEwoLQk5BTUVDTENKQUsY" + "BiADKA0SEwoLRE9HRkRETkNGT1AYCSABKAgSEAoIdHJhaXRfaWQYDCABKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HEPFIAFJAHL), HEPFIAFJAHL.Parser, new string[5] { "EffectId", "DJBLFGFDNCA", "BNAMECLCJAK", "DOGFDDNCFOP", "TraitId" }, null, null, null, null)
		}));
	}
}
