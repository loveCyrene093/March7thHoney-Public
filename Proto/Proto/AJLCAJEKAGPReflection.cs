using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AJLCAJEKAGPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AJLCAJEKAGPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBSkxDQUpFS0FHUC5wcm90bxobR3Jvd3RoVGFydGdldEZ1bmNUeXBlLnBy" + "b3RvIk8KC0FKTENBSkVLQUdQEisKC0RIQUlKTEpDSkFGGAcgAygOMhYuR3Jv" + "d3RoVGFydGdldEZ1bmNUeXBlEhMKC01NT1BDS0xQSElPGAsgASgNQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { GrowthTartgetFuncTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AJLCAJEKAGP), AJLCAJEKAGP.Parser, new string[2] { "DHAIJLJCJAF", "MMOPCKLPHIO" }, null, null, null, null)
		}));
	}
}
