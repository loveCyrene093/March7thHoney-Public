using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightRoleGoodsInfo : IMessage<GridFightRoleGoodsInfo>, IMessage, IEquatable<GridFightRoleGoodsInfo>, IDeepCloneable<GridFightRoleGoodsInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightRoleGoodsInfo> _parser = new MessageParser<GridFightRoleGoodsInfo>(() => new GridFightRoleGoodsInfo());

	private UnknownFieldSet _unknownFields;

	public const int RoleStarFieldNumber = 6;

	private uint roleStar_;

	public const int RoleIdFieldNumber = 14;

	private uint roleId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightRoleGoodsInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightRoleGoodsInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoleStar
	{
		get
		{
			return roleStar_;
		}
		set
		{
			roleStar_ = value;
		}
	}

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
	public GridFightRoleGoodsInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRoleGoodsInfo(GridFightRoleGoodsInfo other)
		: this()
	{
		roleStar_ = other.roleStar_;
		roleId_ = other.roleId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRoleGoodsInfo Clone()
	{
		return new GridFightRoleGoodsInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightRoleGoodsInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightRoleGoodsInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleStar != other.RoleStar)
		{
			return false;
		}
		if (RoleId != other.RoleId)
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
		if (RoleStar != 0)
		{
			num ^= RoleStar.GetHashCode();
		}
		if (RoleId != 0)
		{
			num ^= RoleId.GetHashCode();
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
		if (RoleStar != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(RoleStar);
		}
		if (RoleId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(RoleId);
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
		if (RoleStar != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleStar);
		}
		if (RoleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightRoleGoodsInfo other)
	{
		if (other != null)
		{
			if (other.RoleStar != 0)
			{
				RoleStar = other.RoleStar;
			}
			if (other.RoleId != 0)
			{
				RoleId = other.RoleId;
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
			case 48u:
				RoleStar = input.ReadUInt32();
				break;
			case 112u:
				RoleId = input.ReadUInt32();
				break;
			}
		}
	}
}
