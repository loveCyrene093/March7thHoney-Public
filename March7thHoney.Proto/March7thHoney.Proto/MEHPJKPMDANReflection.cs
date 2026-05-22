using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MEHPJKPMDANReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MEHPJKPMDANReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNRUhQSktQTURBTi5wcm90bxoRREpNRU5OTUtITEMucHJvdG8aEU1EREhE" + "TkJFRUxGLnByb3RvIlMKC01FSFBKS1BNREFOEiEKC0pMQkNOTE9QTEhJGAEg" + "ASgLMgwuREpNRU5OTUtITEMSIQoLR0JQT1BDT0tNTk0YAiADKAsyDC5NRERI" + "RE5CRUVMRkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[2]
		{
			DJMENNMKHLCReflection.Descriptor,
			MDDHDNBEELFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MEHPJKPMDAN), MEHPJKPMDAN.Parser, new string[2] { "JLBCNLOPLHI", "GBPOPCOKMNM" }, null, null, null, null)
		}));
	}
}
