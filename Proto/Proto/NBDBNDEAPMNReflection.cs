using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NBDBNDEAPMNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NBDBNDEAPMNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQkRCTkRFQVBNTi5wcm90bxoRQ0FFQUJISk5MTUkucHJvdG8iMAoLTkJE" + "Qk5ERUFQTU4SIQoLTU1BT09OUEFQRFAYAyABKAsyDC5DQUVBQkhKTkxNSUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { CAEABHJNLMIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NBDBNDEAPMN), NBDBNDEAPMN.Parser, new string[1] { "MMAOONPAPDP" }, null, null, null, null)
		}));
	}
}
