using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeBossBuffListReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeBossBuffListReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDaGFsbGVuZ2VCb3NzQnVmZkxpc3QucHJvdG8iSAoVQ2hhbGxlbmdlQm9z" + "c0J1ZmZMaXN0EhEKCWJ1ZmZfbGlzdBgEIAMoDRIcChRjaGFsbGVuZ2VfYm9z" + "c19jb25zdBgIIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBossBuffList), ChallengeBossBuffList.Parser, new string[2] { "BuffList", "ChallengeBossConst" }, null, null, null, null)
		}));
	}
}
