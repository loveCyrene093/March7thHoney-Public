using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ACBBLDJNOFEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ACBBLDJNOFEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBQ0JCTERKTk9GRS5wcm90byJaCgtBQ0JCTERKTk9GRRIPCgdyb2xlX2lk" + "GAMgASgNEhMKC05DSU5HRENPT0dLGAQgASgIEhMKC01BRUNDREFQS01EGAwg" + "ASgNEhAKCHRyYWl0X2lkGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ACBBLDJNOFE), ACBBLDJNOFE.Parser, new string[4] { "RoleId", "NCINGDCOOGK", "MAECCDAPKMD", "TraitId" }, null, null, null, null)
		}));
	}
}
