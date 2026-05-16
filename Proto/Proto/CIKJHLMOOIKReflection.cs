using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CIKJHLMOOIKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CIKJHLMOOIKReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFDSUtKSExNT09JSy5wcm90bxoRSk9MREROTUdCSEQucHJvdG8aHFB1bmtM";
		buffer[1] = "b3JkQXR0YWNrZXJTdGF0dXMucHJvdG8aHlB1bmtMb3JkTW9uc3RlckJhc2lj";
		buffer[2] = "SW5mby5wcm90byKiAQoLQ0lLSkhMTU9PSUsSLAoLREhIQUxCSUFOT0cYAiAB";
		buffer[3] = "KA4yFy5QdW5rTG9yZEF0dGFja2VyU3RhdHVzEhMKC0dHR09PTUtPSkJGGAQg";
		buffer[4] = "ASgNEi0KCmJhc2ljX2luZm8YCyABKAsyGS5QdW5rTG9yZE1vbnN0ZXJCYXNp";
		buffer[5] = "Y0luZm8SIQoLRkhQT0lMSU1LSUkYDCABKAsyDC5KT0xERE5NR0JIREIWqgIT";
		buffer[6] = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			JOLDDNMGBHDReflection.Descriptor,
			PunkLordAttackerStatusReflection.Descriptor,
			PunkLordMonsterBasicInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CIKJHLMOOIK), CIKJHLMOOIK.Parser, new string[4] { "DHHALBIANOG", "GGGOOMKOJBF", "BasicInfo", "FHPOILIMKII" }, null, null, null, null)
		}));
	}
}
