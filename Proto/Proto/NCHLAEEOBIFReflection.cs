using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NCHLAEEOBIFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NCHLAEEOBIFReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		buffer[0] = "ChFOQ0hMQUVFT0JJRi5wcm90bxoRQ05MSUtBRFBDQkgucHJvdG8aEUVGRUdL";
		buffer[1] = "REhFTUZOLnByb3RvIuoCCgtOQ0hMQUVFT0JJRhIhCgtKQUFIRUxDTEhNSRgB";
		buffer[2] = "IAEoCzIMLkVGRUdLREhFTUZOEjIKC0dNREhQSExJTUFHGAIgAygLMh0uTkNI";
		buffer[3] = "TEFFRU9CSUYuR01ESFBITElNQUdFbnRyeRITCgtFQkZCTE1LSU9BSRgDIAEo";
		buffer[4] = "DRIhCgtCRk5QQ0pPTUdGTBgEIAEoCzIMLkVGRUdLREhFTUZOEhMKC0lBQUFB";
		buffer[5] = "RENMRkxGGAYgASgNEhMKC0VNR0VOSUlMSk1DGAcgASgNEiEKC09HT0RET0lH";
		buffer[6] = "T0pFGAggASgLMgwuRUZFR0tESEVNRk4SEwoLSlBHRkxLRExPT1AYDSABKA0S";
		buffer[7] = "IQoLTU1OT0xJTUJQQ0EYDiADKAsyDC5DTkxJS0FEUENCSBITCgtPUEJDQ0lC";
		buffer[8] = "RUNNSRgPIAEoDRoyChBHTURIUEhMSU1BR0VudHJ5EgsKA2tleRgBIAEoDRIN";
		buffer[9] = "CgV2YWx1ZRgCIAEoDToCOAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[10] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			CNLIKADPCBHReflection.Descriptor,
			EFEGKDHEMFNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NCHLAEEOBIF), NCHLAEEOBIF.Parser, new string[10] { "JAAHELCLHMI", "GMDHPHLIMAG", "EBFBLMKIOAI", "BFNPCJOMGFL", "IAAAADCLFLF", "EMGENIILJMC", "OGODDOIGOJE", "JPGFLKDLOOP", "MMNOLIMBPCA", "OPBCCIBECMI" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
