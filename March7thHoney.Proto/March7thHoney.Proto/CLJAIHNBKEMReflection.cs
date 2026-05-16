using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CLJAIHNBKEMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CLJAIHNBKEMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTEpBSUhOQktFTS5wcm90bxoRR0dDRkZKR0NQS0QucHJvdG8aEUpBRk1G" + "R0pMR0dBLnByb3RvIlMKC0NMSkFJSE5CS0VNEiEKC0JGQ0JHUEVJQ0hHGAEg" + "ASgOMgwuR0dDRkZKR0NQS0QSIQoLbGluZXVwX2xpc3QYAiADKAsyDC5KQUZN" + "RkdKTEdHQUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[2]
		{
			GGCFFJGCPKDReflection.Descriptor,
			JAFMFGJLGGAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CLJAIHNBKEM), CLJAIHNBKEM.Parser, new string[2] { "BFCBGPEICHG", "LineupList" }, null, null, null, null)
		}));
	}
}
