using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MusicRhythmLevelReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MusicRhythmLevelReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZNdXNpY1JoeXRobUxldmVsLnByb3RvIk4KEE11c2ljUmh5dGhtTGV2ZWwS" + "FAoMdW5sb2NrX2xldmVsGAUgASgNEhIKCmZ1bGxfY29tYm8YBiABKAgSEAoI" + "bGV2ZWxfaWQYCCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MusicRhythmLevel), MusicRhythmLevel.Parser, new string[3] { "UnlockLevel", "FullCombo", "LevelId" }, null, null, null, null)
		}));
	}
}
