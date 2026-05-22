using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CLFIIPBIBBGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CLFIIPBIBBGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTEZJSVBCSUJCRy5wcm90bxoRUEtKR0dBUExPTkMucHJvdG8iTgoLQ0xG" + "SUlQQklCQkcSHAoUZmluaXNoZWRfdGFyZ2V0X2xpc3QYCSADKA0SIQoLYXZh" + "dGFyX2xpc3QYDyADKAsyDC5QS0pHR0FQTE9OQ0IWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { PKJGGAPLONCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CLFIIPBIBBG), CLFIIPBIBBG.Parser, new string[2] { "FinishedTargetList", "AvatarList" }, null, null, null, null)
		}));
	}
}
