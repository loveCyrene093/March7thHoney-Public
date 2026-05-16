using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetTrainWorldIdCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetTrainWorldIdCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTZXRUcmFpbldvcmxkSWRDc1JlcS5wcm90byJAChRTZXRUcmFpbldvcmxk" + "SWRDc1JlcRITCgtMTE9MT0VIUEZIQRgNIAEoDRITCgtpbnRlcmFjdF9pZBgP" + "IAEoBEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetTrainWorldIdCsReq), SetTrainWorldIdCsReq.Parser, new string[2] { "LLOLOEHPFHA", "InteractId" }, null, null, null, null)
		}));
	}
}
