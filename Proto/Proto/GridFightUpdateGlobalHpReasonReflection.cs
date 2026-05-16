using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightUpdateGlobalHpReasonReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightUpdateGlobalHpReasonReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "CiNHcmlkRmlnaHRVcGRhdGVHbG9iYWxIcFJlYXNvbi5wcm90byqlAgodR3Jp";
		buffer[1] = "ZEZpZ2h0VXBkYXRlR2xvYmFsSHBSZWFzb24SGwoXQkFLR0dQTkhOTkVfQUpC";
		buffer[2] = "TUFETkRJR0gQABIbChdCQUtHR1BOSE5ORV9BSElLT05GRUJNShABEhsKF0JB";
		buffer[3] = "S0dHUE5ITk5FX0lLSExJTEhBSU9MEAISGwoXQkFLR0dQTkhOTkVfUE9OSUNK";
		buffer[4] = "SkFCRUsQAxIbChdCQUtHR1BOSE5ORV9HUERISUJBRkRDRxAEEhsKF0JBS0dH";
		buffer[5] = "UE5ITk5FX0dGSU1OQ0NGS0lLEGUSGwoXQkFLR0dQTkhOTkVfQkNHUE9MSE9I";
		buffer[6] = "S0YQZhIbChdCQUtHR1BOSE5ORV9EQUhOQ0lES0ZDUBBnEhwKF0JBS0dHUE5I";
		buffer[7] = "Tk5FX0RDS0dEQURQSkxIEMkBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[8] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GridFightUpdateGlobalHpReason) }, null, null));
	}
}
