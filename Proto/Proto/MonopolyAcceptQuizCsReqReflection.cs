using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyAcceptQuizCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyAcceptQuizCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Nb25vcG9seUFjY2VwdFF1aXpDc1JlcS5wcm90bxoRTk9LS0FQR0JOSFAu" + "cHJvdG8iPAoXTW9ub3BvbHlBY2NlcHRRdWl6Q3NSZXESIQoLTk5LSE1JRUpQ" + "T0kYDyADKAsyDC5OT0tLQVBHQk5IUEIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[1] { NOKKAPGBNHPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyAcceptQuizCsReq), MonopolyAcceptQuizCsReq.Parser, new string[1] { "NNKHMIEJPOI" }, null, null, null, null)
		}));
	}
}
