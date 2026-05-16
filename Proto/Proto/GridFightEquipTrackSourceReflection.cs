using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightEquipTrackSourceReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightEquipTrackSourceReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch9HcmlkRmlnaHRFcXVpcFRyYWNrU291cmNlLnByb3RvKo8BChlHcmlkRmln";
		buffer[1] = "aHRFcXVpcFRyYWNrU291cmNlEhsKF0hOS0tOREhMT0dOX0hMTk1NTUtIRUVN";
		buffer[2] = "EAASGwoXSE5LS05ESExPR05fSkZDQUFCUE5BR0cQARIbChdITktLTkRITE9H";
		buffer[3] = "Tl9LTUpDT1BJQU5DRxACEhsKF0hOS0tOREhMT0dOX0hIRkNOTENDR0hOEANC";
		buffer[4] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GridFightEquipTrackSource) }, null, null));
	}
}
