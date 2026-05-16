using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BAACLGINJFPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BAACLGINJFPReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		buffer[0] = "ChFCQUFDTEdJTkpGUC5wcm90byqGAwoLQkFBQ0xHSU5KRlASGwoXQkFBQ0xH";
		buffer[1] = "SU5KRlBfUENQREhFTFBLRU0QABIbChdCQUFDTEdJTkpGUF9JR0dGTU9CQktG";
		buffer[2] = "TRABEhsKF0JBQUNMR0lOSkZQX0VHTkRKR0tLSkhPEAISGwoXQkFBQ0xHSU5K";
		buffer[3] = "RlBfSEVNTUdLSUpMRUkQAxIbChdCQUFDTEdJTkpGUF9BT0dIRkJQRUxCUBAE";
		buffer[4] = "EhsKF0JBQUNMR0lOSkZQX0lNREtFTEZBRU9DEAUSGwoXQkFBQ0xHSU5KRlBf";
		buffer[5] = "TEVLR0lJSUdMS0IQBhIbChdCQUFDTEdJTkpGUF9ISFBKUEtBQUtFSxAHEhsK";
		buffer[6] = "F0JBQUNMR0lOSkZQX1BESE1DTUVCTU1CEAgSGwoXQkFBQ0xHSU5KRlBfSkFE";
		buffer[7] = "Q0xFQUZFSkMQCRIbChdCQUFDTEdJTkpGUF9CRkFHTkVOUEpKShAKEhsKF0JB";
		buffer[8] = "QUNMR0lOSkZQX0dBTEdGSU9NT0lPEAsSGwoXQkFBQ0xHSU5KRlBfT1BGUE5I";
		buffer[9] = "SUJFRUQQDEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(BAACLGINJFP) }, null, null));
	}
}
