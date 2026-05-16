using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AGFFLADPOIJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AGFFLADPOIJReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFBR0ZGTEFEUE9JSi5wcm90byqeAQoLQUdGRkxBRFBPSUoSGwoXQUdGRkxB";
		buffer[1] = "RFBPSUpfSEZNQkxNT0dPS0IQABIbChdBR0ZGTEFEUE9JSl9GTUNBTENNTEVO";
		buffer[2] = "RBABEhsKF0FHRkZMQURQT0lKX0hNQUpMUEVJS0ZMEAISGwoXQUdGRkxBRFBP";
		buffer[3] = "SUpfS0xHR09KUExJRUIQAxIbChdBR0ZGTEFEUE9JSl9QS0FNQUZKUEhGSxAE";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(AGFFLADPOIJ) }, null, null));
	}
}
