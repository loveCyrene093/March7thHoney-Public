using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PMBLADGCPMMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PMBLADGCPMMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQTUJMQURHQ1BNTS5wcm90bxoRSk9KTEFDREJQTkEucHJvdG8iWgoLUE1C" + "TEFER0NQTU0SEwoLRUROQ09BR0FJSksYASABKA0SIQoLT0lBUEhCQkRQSEwY" + "BCABKAsyDC5KT0pMQUNEQlBOQRITCgtFTExFTEpGR0RQSBgJIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { JOJLACDBPNAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PMBLADGCPMM), PMBLADGCPMM.Parser, new string[3] { "EDNCOAGAIJK", "OIAPHBBDPHL", "ELLELJFGDPH" }, null, null, null, null)
		}));
	}
}
