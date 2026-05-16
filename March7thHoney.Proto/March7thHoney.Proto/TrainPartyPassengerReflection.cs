using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyPassengerReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyPassengerReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlUcmFpblBhcnR5UGFzc2VuZ2VyLnByb3RvImgKE1RyYWluUGFydHlQYXNz" + "ZW5nZXISFAoMcGFzc2VuZ2VyX2lkGAIgASgNEhEKCXJlY29yZF9pZBgGIAEo" + "DRITCgtERUxFS0NJSk1JTBgNIAEoCBITCgtEQUNFRE5HSkxCTRgOIAMoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyPassenger), TrainPartyPassenger.Parser, new string[4] { "PassengerId", "RecordId", "DELEKCIJMIL", "DACEDNGJLBM" }, null, null, null, null)
		}));
	}
}
