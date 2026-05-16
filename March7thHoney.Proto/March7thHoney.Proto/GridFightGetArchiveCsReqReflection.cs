using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGetArchiveCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGetArchiveCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HcmlkRmlnaHRHZXRBcmNoaXZlQ3NSZXEucHJvdG8aEUFQRFBBRUNKUElI" + "LnByb3RvIjYKGEdyaWRGaWdodEdldEFyY2hpdmVDc1JlcRIaCgR0eXBlGAgg" + "ASgOMgwuQVBEUEFFQ0pQSUhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[1] { APDPAECJPIHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGetArchiveCsReq), GridFightGetArchiveCsReq.Parser, new string[1] { "Type" }, null, null, null, null)
		}));
	}
}
