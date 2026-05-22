using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TreasureDungeonDataScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TreasureDungeonDataScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFUcmVhc3VyZUR1bmdlb25EYXRhU2NOb3RpZnkucHJvdG8aEUtQQkdNT0ND" + "TUxBLnByb3RvIkAKG1RyZWFzdXJlRHVuZ2VvbkRhdGFTY05vdGlmeRIhCgtJ" + "S0hKTE1BS05DRBgNIAEoCzIMLktQQkdNT0NDTUxBQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { KPBGMOCCMLAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TreasureDungeonDataScNotify), TreasureDungeonDataScNotify.Parser, new string[1] { "IKHJLMAKNCD" }, null, null, null, null)
		}));
	}
}
