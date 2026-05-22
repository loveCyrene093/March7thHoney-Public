using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OEGICCFGHJEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OEGICCFGHJEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPRUdJQ0NGR0hKRS5wcm90byI7CgtPRUdJQ0NGR0hKRRITCgtES1BDRExE" + "RE9ORxgDIAEoDRIXCg9pc190YWtlbl9yZXdhcmQYDiABKAhCFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OEGICCFGHJE), OEGICCFGHJE.Parser, new string[2] { "DKPCDLDDONG", "IsTakenReward" }, null, null, null, null)
		}));
	}
}
