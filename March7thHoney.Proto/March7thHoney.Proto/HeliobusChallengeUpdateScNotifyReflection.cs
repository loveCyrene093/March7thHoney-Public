using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusChallengeUpdateScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusChallengeUpdateScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVIZWxpb2J1c0NoYWxsZW5nZVVwZGF0ZVNjTm90aWZ5LnByb3RvGhtIZWxp" + "b2J1c0NoYWxsZW5nZURhdGEucHJvdG8iTgofSGVsaW9idXNDaGFsbGVuZ2VV" + "cGRhdGVTY05vdGlmeRIrCgtPUENHTkpNR0pERRgGIAEoCzIWLkhlbGlvYnVz" + "Q2hhbGxlbmdlRGF0YUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { HeliobusChallengeDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusChallengeUpdateScNotify), HeliobusChallengeUpdateScNotify.Parser, new string[1] { "OPCGNJMGJDE" }, null, null, null, null)
		}));
	}
}
