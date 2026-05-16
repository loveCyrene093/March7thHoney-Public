using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BHCMHNKONMJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BHCMHNKONMJReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFCSENNSE5LT05NSi5wcm90byqBAQoLQkhDTUhOS09OTUoSGwoXQkhDTUhO";
		buffer[1] = "S09OTUpfSEhHTUZMT0NFRkwQABIbChdCSENNSE5LT05NSl9BQ1BETkZBQ0tC";
		buffer[2] = "TBABEhsKF0JIQ01ITktPTk1KX0ZGQkxFSktOS0VMEAISGwoXQkhDTUhOS09O";
		buffer[3] = "TUpfUEFQSURLSE5KS0oQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(BHCMHNKONMJ) }, null, null));
	}
}
