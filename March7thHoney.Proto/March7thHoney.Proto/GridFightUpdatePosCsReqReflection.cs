using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightUpdatePosCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightUpdatePosCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HcmlkRmlnaHRVcGRhdGVQb3NDc1JlcS5wcm90bxoWR3JpZEZpZ2h0UG9z" + "SW5mby5wcm90byJOChdHcmlkRmlnaHRVcGRhdGVQb3NDc1JlcRIzChhncmlk" + "X2ZpZ2h0X3Bvc19pbmZvX2xpc3QYCiADKAsyES5HcmlkRmlnaHRQb3NJbmZv" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { GridFightPosInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightUpdatePosCsReq), GridFightUpdatePosCsReq.Parser, new string[1] { "GridFightPosInfoList" }, null, null, null, null)
		}));
	}
}
