using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ReportPlayerCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ReportPlayerCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdSZXBvcnRQbGF5ZXJDc1JlcS5wcm90byJKChFSZXBvcnRQbGF5ZXJDc1Jl" + "cRITCgtIRUxIUERNRExCTxgIIAEoDRITCgtNUENPTEhCSlBCUBgLIAEoCRIL" + "CgN1aWQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ReportPlayerCsReq), ReportPlayerCsReq.Parser, new string[3] { "HELHPDMDLBO", "MPCOLHBJPBP", "Uid" }, null, null, null, null)
		}));
	}
}
