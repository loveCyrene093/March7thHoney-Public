using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdWolfBroTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdWolfBroTypeReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		buffer[0] = "ChRDbWRXb2xmQnJvVHlwZS5wcm90byq8AwoOQ21kV29sZkJyb1R5cGUSGwoX";
		buffer[1] = "SklPT0xCS0JFUENfUENQREhFTFBLRU0QABITCg5DbWRFSkdBSU5LS0JGTRCI";
		buffer[2] = "MxITCg5DbWRKTEpIT09CSERIUBDxMhITCg5DbWRLSE9IQ01NQ01CTBD3MhIT";
		buffer[3] = "Cg5DbWRCTEdOSkpORkRFQRDnMhITCg5DbWRCTkVHRUVCSkNNRBCWMxITCg5D";
		buffer[4] = "bWRFRUdBSU9DQ01LTRCHMxITCg5DbWRJUE5BRU9EQ1BERBDpMhITCg5DbWRN";
		buffer[5] = "T01BRVBQRUFKQRDmMhITCg5DbWRNR0RBR0FQQUlFShCDMxITCg5DbWRIQlBC";
		buffer[6] = "SE5QSUVBSxD2MhITCg5DbWRQQ0hMS0pDTkNFThD0MhITCg5DbWRQUEJKSUxH";
		buffer[7] = "QVBCRhCQMxITCg5DbWROSk1QQVBGTU5GTRCKMxITCg5DbWRFSUJOUElLR0NK";
		buffer[8] = "ThCCMxITCg5DbWRETkRISURLRkJLQRDrMhITCg5DbWREUFBEQ05CSUxNThDl";
		buffer[9] = "MhITCg5DbWRDTU9ISUdLS05FThD/MhITCg5DbWRPRkZCTkdFSURGTRCRMxIT";
		buffer[10] = "Cg5DbWRCQ0dJSEZHSUFFTRCTM0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[11] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdWolfBroType) }, null, null));
	}
}
