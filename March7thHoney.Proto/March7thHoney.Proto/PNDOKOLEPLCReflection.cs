using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PNDOKOLEPLCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PNDOKOLEPLCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQTkRPS09MRVBMQy5wcm90byJQCgtQTkRPS09MRVBMQxITCgtKQ09DS0pH" + "S0ZESxgEIAEoCBIXCg9pc190YWtlbl9yZXdhcmQYCSABKAgSEwoLQkdCRU9G" + "S0VKRUcYCiABKARCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PNDOKOLEPLC), PNDOKOLEPLC.Parser, new string[3] { "JCOCKJGKFDK", "IsTakenReward", "BGBEOFKEJEG" }, null, null, null, null)
		}));
	}
}
