using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MusicRhythmGroupReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MusicRhythmGroupReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZNdXNpY1JoeXRobUdyb3VwLnByb3RvIm8KEE11c2ljUmh5dGhtR3JvdXAS" + "FgoObXVzaWNfZ3JvdXBfaWQYAyABKA0SEwoLRklDQ1BFTUxNTk4YByADKA0S" + "EwoLTkNJSUlJQUJGRFAYCCADKA0SGQoRbXVzaWNfZ3JvdXBfcGhhc2UYDSAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MusicRhythmGroup), MusicRhythmGroup.Parser, new string[4] { "MusicGroupId", "FICCPEMLMNN", "NCIIIIABFDP", "MusicGroupPhase" }, null, null, null, null)
		}));
	}
}
