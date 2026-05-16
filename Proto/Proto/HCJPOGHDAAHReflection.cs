using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HCJPOGHDAAHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HCJPOGHDAAHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQ0pQT0dIREFBSC5wcm90bxoRT0pNTEtKSkNESUcucHJvdG8iWgoLSENK" + "UE9HSERBQUgSIQoLSUNITUtGTUFJQkIYAyADKAsyDC5PSk1MS0pKQ0RJRxIT" + "CgtFUExCQ05GTUxJTBgHIAEoDRITCgtLREFPS09ERUlFShgKIAEoAkIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { OJMLKJJCDIGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HCJPOGHDAAH), HCJPOGHDAAH.Parser, new string[3] { "ICHMKFMAIBB", "EPLBCNFMLIL", "KDAOKODEIEJ" }, null, null, null, null)
		}));
	}
}
