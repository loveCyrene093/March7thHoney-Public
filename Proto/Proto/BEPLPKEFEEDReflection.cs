using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BEPLPKEFEEDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BEPLPKEFEEDReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFCRVBMUEtFRkVFRC5wcm90byqBAQoLQkVQTFBLRUZFRUQSGwoXQkVQTFBL";
		buffer[1] = "RUZFRURfUENQREhFTFBLRU0QABIbChdCRVBMUEtFRkVFRF9GQ0VITk1KSkFC";
		buffer[2] = "RRABEhsKF0JFUExQS0VGRUVEX0lPSEZGR0hKT1BGEAISGwoXQkVQTFBLRUZF";
		buffer[3] = "RURfT01KSUNHTkNPSUQQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(BEPLPKEFEED) }, null, null));
	}
}
