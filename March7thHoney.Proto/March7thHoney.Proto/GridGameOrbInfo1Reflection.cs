using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridGameOrbInfo1Reflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridGameOrbInfo1Reflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZHcmlkR2FtZU9yYkluZm8xLnByb3RvIk8KEEdyaWRHYW1lT3JiSW5mbzES" + "EwoLRktQTk5PR1BDTkEYBSABKA0SEwoLRkNGRERCQ0FKT0QYCyABKA0SEQoJ" + "dW5pcXVlX2lkGAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridGameOrbInfo1), GridGameOrbInfo1.Parser, new string[3] { "FKPNNOGPCNA", "FCFDDBCAJOD", "UniqueId" }, null, null, null, null)
		}));
	}
}
