using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGlobalHpChangeReasonReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGlobalHpChangeReasonReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "CiNHcmlkRmlnaHRHbG9iYWxIcENoYW5nZVJlYXNvbi5wcm90byrNAQodR3Jp";
		buffer[1] = "ZEZpZ2h0R2xvYmFsSHBDaGFuZ2VSZWFzb24SGwoXRk9PSE1OQUZLQk5fRUlH";
		buffer[2] = "T05NQUVGUEoQABIbChdGT09ITU5BRktCTl9JRk5JRUVBRkZORRABEhsKF0ZP";
		buffer[3] = "T0hNTkFGS0JOX0tDR1BKS0xMRkZHEAISGwoXRk9PSE1OQUZLQk5fSElDUEpK";
		buffer[4] = "TklBSkkQAxIbChdGT09ITU5BRktCTl9BTEFDQ0FGTUdIRRAEEhsKF0ZPT0hN";
		buffer[5] = "TkFGS0JOX0ZBS0FETk5HTENIEAVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[6] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GridFightGlobalHpChangeReason) }, null, null));
	}
}
