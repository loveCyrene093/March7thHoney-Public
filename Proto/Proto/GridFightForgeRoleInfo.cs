using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightForgeRoleInfo : IMessage<GridFightForgeRoleInfo>, IMessage, IEquatable<GridFightForgeRoleInfo>, IDeepCloneable<GridFightForgeRoleInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightForgeRoleInfo> _parser = new MessageParser<GridFightForgeRoleInfo>(() => new GridFightForgeRoleInfo());

	private UnknownFieldSet _unknownFields;

	public const int RoleIdFieldNumber = 8;

	private uint roleId_;

	public const int GJFGFHFFCPJFieldNumber = 14;

	private uint gJFGFHFFCPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightForgeRoleInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightForgeRoleInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GJFGFHFFCPJ
	{
		get
		{
			return gJFGFHFFCPJ_;
		}
		set
		{
			gJFGFHFFCPJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeRoleInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeRoleInfo(GridFightForgeRoleInfo other)
		: this()
	{
		roleId_ = other.roleId_;
		gJFGFHFFCPJ_ = other.gJFGFHFFCPJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeRoleInfo Clone()
	{
		return new GridFightForgeRoleInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightForgeRoleInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightForgeRoleInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (GJFGFHFFCPJ != other.GJFGFHFFCPJ)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (RoleId != 0)
		{
			num ^= RoleId.GetHashCode();
		}
		if (GJFGFHFFCPJ != 0)
		{
			num ^= GJFGFHFFCPJ.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (RoleId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(RoleId);
		}
		if (GJFGFHFFCPJ != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(GJFGFHFFCPJ);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (RoleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleId);
		}
		if (GJFGFHFFCPJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GJFGFHFFCPJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightForgeRoleInfo other)
	{
		if (other != null)
		{
			if (other.RoleId != 0)
			{
				RoleId = other.RoleId;
			}
			if (other.GJFGFHFFCPJ != 0)
			{
				GJFGFHFFCPJ = other.GJFGFHFFCPJ;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 64u:
				RoleId = input.ReadUInt32();
				break;
			case 112u:
				GJFGFHFFCPJ = input.ReadUInt32();
				break;
			}
		}
	}
}
