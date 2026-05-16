using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FIKNLFBIPHKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FIKNLFBIPHKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGSUtOTEZCSVBISy5wcm90bxoRTEhKQ0ZOTFBGSUwucHJvdG8iWgoLRklL" + "TkxGQklQSEsSEwoLS0lDTU5OUEZFR0sYASABKA0SEwoLSklGUEdEQ0ZERUsY" + "AiABKAgSIQoLRUFNRElDTkJOSUwYAyABKAsyDC5MSEpDRk5MUEZJTEIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { LHJCFNLPFILReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FIKNLFBIPHK), FIKNLFBIPHK.Parser, new string[3] { "KICMNNPFEGK", "JIFPGDCFDEK", "EAMDICNBNIL" }, null, null, null, null)
		}));
	}
}
