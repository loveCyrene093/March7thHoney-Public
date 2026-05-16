using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AGLBGFLKIMEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AGLBGFLKIMEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBR0xCR0ZMS0lNRS5wcm90bxoRSE9CSEdFR0pGRU4ucHJvdG8iRQoLQUdM" + "QkdGTEtJTUUSIQoLTkJBT0RGR0NFQkYYCSADKAsyDC5IT0JIR0VHSkZFThIT" + "CgtFQUxHTURESUxLQhgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { HOBHGEGJFENReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AGLBGFLKIME), AGLBGFLKIME.Parser, new string[2] { "NBAODFGCEBF", "EALGMDDILKB" }, null, null, null, null)
		}));
	}
}
