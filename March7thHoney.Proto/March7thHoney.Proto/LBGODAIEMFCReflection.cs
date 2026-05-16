using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LBGODAIEMFCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LBGODAIEMFCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMQkdPREFJRU1GQy5wcm90bxoRSklJQ1BKTklOQkIucHJvdG8iQQoLTEJH" + "T0RBSUVNRkMSDwoHcmV0Y29kZRgBIAEoDRIhCgtOTk5GQ09BRkZBTxgPIAEo" + "CzIMLkpJSUNQSk5JTkJCQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { JIICPJNINBBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LBGODAIEMFC), LBGODAIEMFC.Parser, new string[2] { "Retcode", "NNNFCOAFFAO" }, null, null, null, null)
		}));
	}
}
