using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuitLineupCsReq : IMessage<QuitLineupCsReq>, IMessage, IEquatable<QuitLineupCsReq>, IDeepCloneable<QuitLineupCsReq>, IBufferMessage
{
	private static readonly MessageParser<QuitLineupCsReq> _parser = new MessageParser<QuitLineupCsReq>(() => new QuitLineupCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PlaneIdFieldNumber = 3;

	private uint planeId_;

	public const int IsVirtualFieldNumber = 4;

	private bool isVirtual_;

	public const int IndexFieldNumber = 6;

	private uint index_;

	public const int ExtraLineupTypeFieldNumber = 8;

	private ExtraLineupType extraLineupType_;

	public const int BaseAvatarIdFieldNumber = 9;

	private uint baseAvatarId_;

	public const int AvatarTypeFieldNumber = 13;

	private AvatarType avatarType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuitLineupCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => QuitLineupCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PlaneId
	{
		get
		{
			return planeId_;
		}
		set
		{
			planeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsVirtual
	{
		get
		{
			return isVirtual_;
		}
		set
		{
			isVirtual_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Index
	{
		get
		{
			return index_;
		}
		set
		{
			index_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExtraLineupType ExtraLineupType
	{
		get
		{
			return extraLineupType_;
		}
		set
		{
			extraLineupType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BaseAvatarId
	{
		get
		{
			return baseAvatarId_;
		}
		set
		{
			baseAvatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarType AvatarType
	{
		get
		{
			return avatarType_;
		}
		set
		{
			avatarType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuitLineupCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuitLineupCsReq(QuitLineupCsReq other)
		: this()
	{
		planeId_ = other.planeId_;
		isVirtual_ = other.isVirtual_;
		index_ = other.index_;
		extraLineupType_ = other.extraLineupType_;
		baseAvatarId_ = other.baseAvatarId_;
		avatarType_ = other.avatarType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuitLineupCsReq Clone()
	{
		return new QuitLineupCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QuitLineupCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuitLineupCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PlaneId != other.PlaneId)
		{
			return false;
		}
		if (IsVirtual != other.IsVirtual)
		{
			return false;
		}
		if (Index != other.Index)
		{
			return false;
		}
		if (ExtraLineupType != other.ExtraLineupType)
		{
			return false;
		}
		if (BaseAvatarId != other.BaseAvatarId)
		{
			return false;
		}
		if (AvatarType != other.AvatarType)
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
		if (PlaneId != 0)
		{
			num ^= PlaneId.GetHashCode();
		}
		if (IsVirtual)
		{
			num ^= IsVirtual.GetHashCode();
		}
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
		}
		if (ExtraLineupType != ExtraLineupType.LineupNone)
		{
			num ^= ExtraLineupType.GetHashCode();
		}
		if (BaseAvatarId != 0)
		{
			num ^= BaseAvatarId.GetHashCode();
		}
		if (AvatarType != AvatarType.None)
		{
			num ^= AvatarType.GetHashCode();
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
		if (PlaneId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PlaneId);
		}
		if (IsVirtual)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsVirtual);
		}
		if (Index != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Index);
		}
		if (ExtraLineupType != ExtraLineupType.LineupNone)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)ExtraLineupType);
		}
		if (BaseAvatarId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(BaseAvatarId);
		}
		if (AvatarType != AvatarType.None)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)AvatarType);
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
		if (PlaneId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PlaneId);
		}
		if (IsVirtual)
		{
			num += 2;
		}
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Index);
		}
		if (ExtraLineupType != ExtraLineupType.LineupNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ExtraLineupType);
		}
		if (BaseAvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BaseAvatarId);
		}
		if (AvatarType != AvatarType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AvatarType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuitLineupCsReq other)
	{
		if (other != null)
		{
			if (other.PlaneId != 0)
			{
				PlaneId = other.PlaneId;
			}
			if (other.IsVirtual)
			{
				IsVirtual = other.IsVirtual;
			}
			if (other.Index != 0)
			{
				Index = other.Index;
			}
			if (other.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				ExtraLineupType = other.ExtraLineupType;
			}
			if (other.BaseAvatarId != 0)
			{
				BaseAvatarId = other.BaseAvatarId;
			}
			if (other.AvatarType != AvatarType.None)
			{
				AvatarType = other.AvatarType;
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
			case 24u:
				PlaneId = input.ReadUInt32();
				break;
			case 32u:
				IsVirtual = input.ReadBool();
				break;
			case 48u:
				Index = input.ReadUInt32();
				break;
			case 64u:
				ExtraLineupType = (ExtraLineupType)input.ReadEnum();
				break;
			case 72u:
				BaseAvatarId = input.ReadUInt32();
				break;
			case 104u:
				AvatarType = (AvatarType)input.ReadEnum();
				break;
			}
		}
	}
}
