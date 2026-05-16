using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DrinkMakerChallengeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DrinkMakerChallengeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Ecmlua01ha2VyQ2hhbGxlbmdlQ3NSZXEucHJvdG8aEUNJR0tCRElHR09J" + "LnByb3RvIlMKGERyaW5rTWFrZXJDaGFsbGVuZ2VDc1JlcRIhCgtJSERNTEhG" + "QUVLSBgFIAEoCzIMLkNJR0tCRElHR09JEhQKDGNoYWxsZW5nZV9pZBgNIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { CIGKBDIGGOIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DrinkMakerChallengeCsReq), DrinkMakerChallengeCsReq.Parser, new string[2] { "IHDMLHFAEKH", "ChallengeId" }, null, null, null, null)
		}));
	}
}
