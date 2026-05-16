using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MHANIEBKGHHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MHANIEBKGHHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNSEFOSUVCS0dISC5wcm90bxoRSEhJUEtJTk5DQVAucHJvdG8iWgoLTUhB" + "TklFQktHSEgSEwoLRUtDUElLR0xJSkkYASABKA0SEwoLSExLQUZQQ0xNRU8Y" + "AiABKAgSIQoLS0JBS0pESlBDT0YYAyABKAsyDC5ISElQS0lOTkNBUEIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { HHIPKINNCAPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MHANIEBKGHH), MHANIEBKGHH.Parser, new string[3] { "EKCPIKGLIJI", "HLKAFPCLMEO", "KBAKJDJPCOF" }, null, null, null, null)
		}));
	}
}
