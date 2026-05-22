using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FiveDimFluteDataChangeNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FiveDimFluteDataChangeNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJGaXZlRGltRmx1dGVEYXRhQ2hhbmdlTm90aWZ5LnByb3RvIkgKHEZpdmVE" + "aW1GbHV0ZURhdGFDaGFuZ2VOb3RpZnkSEwoLT0hHRkVHREZLTkcYASADKA0S" + "EwoLRVBQSEdPQkFGTVAYDCADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FiveDimFluteDataChangeNotify), FiveDimFluteDataChangeNotify.Parser, new string[2] { "OHGFEGDFKNG", "EPPHGOBAFMP" }, null, null, null, null)
		}));
	}
}
