using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CAEINLJIBPBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CAEINLJIBPBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDQUVJTkxKSUJQQi5wcm90bxoRQ0FFQUJISk5MTUkucHJvdG8iMAoLQ0FF" + "SU5MSklCUEISIQoLTU1BT09OUEFQRFAYBCABKAsyDC5DQUVBQkhKTkxNSUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { CAEABHJNLMIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CAEINLJIBPB), CAEINLJIBPB.Parser, new string[1] { "MMAOONPAPDP" }, null, null, null, null)
		}));
	}
}
