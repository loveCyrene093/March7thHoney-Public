using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SkillExtraTagReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SkillExtraTagReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChNTa2lsbEV4dHJhVGFnLnByb3RvKoABCg1Ta2lsbEV4dHJhVGFnEhkKFVND";
		buffer[1] = "RU5FX0NBU1RfU0tJTExfTk9ORRAAEiMKH1NDRU5FX0NBU1RfU0tJTExfUFJP";
		buffer[2] = "SkVDVElMRV9ISVQQARIvCitTQ0VORV9DQVNUX1NLSUxMX1BST0pFQ1RJTEVf";
		buffer[3] = "TElGRVRJTUVfRklOSVNIEAJCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[4] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(SkillExtraTag) }, null, null));
	}
}
