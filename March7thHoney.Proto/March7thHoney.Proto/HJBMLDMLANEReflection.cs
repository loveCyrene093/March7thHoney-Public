using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HJBMLDMLANEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HJBMLDMLANEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFISkJNTERNTEFORS5wcm90byJ2CgtISkJNTERNTEFORRITCgtKS0xGTU9I" + "SUNNTxgFIAEoCBITCgtFQU9GSkZBRkFITxgGIAMoDRITCgtEQUREUEpEQUhC" + "ThgLIAMoDRITCgtHSkxIS05HTElLQhgNIAMoDRITCgtGRkxGSUlPTUFMQxgP" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HJBMLDMLANE), HJBMLDMLANE.Parser, new string[5] { "JKLFMOHICMO", "EAOFJFAFAHO", "DADDPJDAHBN", "GJLHKNGLIKB", "FFLFIIOMALC" }, null, null, null, null)
		}));
	}
}
