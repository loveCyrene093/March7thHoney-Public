using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdSwitchHandTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdSwitchHandTypeReflection()
	{
		InlineArray13<string> buffer = default(InlineArray13<string>);
		buffer[0] = "ChdDbWRTd2l0Y2hIYW5kVHlwZS5wcm90byr2AwoRQ21kU3dpdGNoSGFuZFR5";
		buffer[1] = "cGUSGwoXSU5NS0dOTVBPRURfUENQREhFTFBLRU0QABImCiFDbWRHZXRTd2l0";
		buffer[2] = "Y2hIYW5kUmVzZXRIYW5kUG9zU2NSc3AQtj8SIAobQ21kU3dpdGNoSGFuZFJl";
		buffer[3] = "c2V0R2FtZUNzUmVxEKg/EhwKF0NtZFN3aXRjaEhhbmRTdGFydFNjUnNwEK4/";
		buffer[4] = "EhMKDkNtZElOREtITUFPQUtNELc/Eh0KGENtZFN3aXRjaEhhbmRVcGRhdGVD";
		buffer[5] = "c1JlcRCyPxIlCiBDbWRTd2l0Y2hIYW5kUmVzZXRUcmFuc2Zvcm1Dc1JlcRCv";
		buffer[6] = "PxIcChdDbWRTd2l0Y2hIYW5kU3RhcnRDc1JlcRCmPxIhChxDbWRTd2l0Y2hI";
		buffer[7] = "YW5kQ29pblVwZGF0ZUNzUmVxEKs/Eh0KGENtZFN3aXRjaEhhbmRGaW5pc2hD";
		buffer[8] = "c1JlcRCzPxIdChhDbWRTd2l0Y2hIYW5kRmluaXNoU2NSc3AQrD8SHgoZQ21k";
		buffer[9] = "R2V0U3dpdGNoSGFuZERhdGFTY1JzcBC4PxIbChZDbWRTd2l0Y2hIYW5kRGF0";
		buffer[10] = "YUNzUmVxEKU/EiMKHkNtZEdldFN3aXRjaEhhbmRSZXNldEdhbWVTY1JzcBCn";
		buffer[11] = "PxIgChtDbWRHZXRTd2l0Y2hIYW5kVXBkYXRlU2NSc3AQtT9CFqoCE01hcmNo";
		buffer[12] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdSwitchHandType) }, null, null));
	}
}
