using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridEncounterMonsterWaveReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridEncounterMonsterWaveReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HcmlkRW5jb3VudGVyTW9uc3RlcldhdmUucHJvdG8aEVBKTEJETVBFS0ZQ" + "LnByb3RvIlIKGEdyaWRFbmNvdW50ZXJNb25zdGVyV2F2ZRITCgtJR01NUERE" + "Q0pJThgBIAEoDRIhCgtQUE9FRERGRkVLSxgEIAMoCzIMLlBKTEJETVBFS0ZQ" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { PJLBDMPEKFPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridEncounterMonsterWave), GridEncounterMonsterWave.Parser, new string[2] { "IGMMPDDCJIN", "PPOEDDFFEKK" }, null, null, null, null)
		}));
	}
}
