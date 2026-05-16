using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class Equipment : IMessage<Equipment>, IMessage, IEquatable<Equipment>, IDeepCloneable<Equipment>, IBufferMessage
{
	private static readonly MessageParser<Equipment> _parser = new MessageParser<Equipment>(() => new Equipment());

	private UnknownFieldSet _unknownFields;

	public const int PromotionFieldNumber = 3;

	private uint promotion_;

	public const int DressAvatarIdFieldNumber = 4;

	private uint dressAvatarId_;

	public const int ExpFieldNumber = 5;

	private uint exp_;

	public const int LevelFieldNumber = 7;

	private uint level_;

	public const int IsProtectedFieldNumber = 8;

	private bool isProtected_;

	public const int RankFieldNumber = 10;

	private uint rank_;

	public const int UniqueIdFieldNumber = 11;

	private uint uniqueId_;

	public const int TidFieldNumber = 12;

	private uint tid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Equipment> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EquipmentReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Promotion
	{
		get
		{
			return promotion_;
		}
		set
		{
			promotion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DressAvatarId
	{
		get
		{
			return dressAvatarId_;
		}
		set
		{
			dressAvatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Exp
	{
		get
		{
			return exp_;
		}
		set
		{
			exp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsProtected
	{
		get
		{
			return isProtected_;
		}
		set
		{
			isProtected_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Tid
	{
		get
		{
			return tid_;
		}
		set
		{
			tid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Equipment()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Equipment(Equipment other)
		: this()
	{
		promotion_ = other.promotion_;
		dressAvatarId_ = other.dressAvatarId_;
		exp_ = other.exp_;
		level_ = other.level_;
		isProtected_ = other.isProtected_;
		rank_ = other.rank_;
		uniqueId_ = other.uniqueId_;
		tid_ = other.tid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Equipment Clone()
	{
		return new Equipment(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as Equipment);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Equipment other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Promotion != other.Promotion)
		{
			return false;
		}
		if (DressAvatarId != other.DressAvatarId)
		{
			return false;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (IsProtected != other.IsProtected)
		{
			return false;
		}
		if (Rank != other.Rank)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (Tid != other.Tid)
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
		if (Promotion != 0)
		{
			num ^= Promotion.GetHashCode();
		}
		if (DressAvatarId != 0)
		{
			num ^= DressAvatarId.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (IsProtected)
		{
			num ^= IsProtected.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (Tid != 0)
		{
			num ^= Tid.GetHashCode();
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
		if (Promotion != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Promotion);
		}
		if (DressAvatarId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DressAvatarId);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Exp);
		}
		if (Level != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Level);
		}
		if (IsProtected)
		{
			output.WriteRawTag(64);
			output.WriteBool(IsProtected);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Rank);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(UniqueId);
		}
		if (Tid != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Tid);
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
		if (Promotion != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Promotion);
		}
		if (DressAvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DressAvatarId);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (IsProtected)
		{
			num += 2;
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rank);
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (Tid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Tid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Equipment other)
	{
		if (other != null)
		{
			if (other.Promotion != 0)
			{
				Promotion = other.Promotion;
			}
			if (other.DressAvatarId != 0)
			{
				DressAvatarId = other.DressAvatarId;
			}
			if (other.Exp != 0)
			{
				Exp = other.Exp;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.IsProtected)
			{
				IsProtected = other.IsProtected;
			}
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			if (other.Tid != 0)
			{
				Tid = other.Tid;
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
				Promotion = input.ReadUInt32();
				break;
			case 32u:
				DressAvatarId = input.ReadUInt32();
				break;
			case 40u:
				Exp = input.ReadUInt32();
				break;
			case 56u:
				Level = input.ReadUInt32();
				break;
			case 64u:
				IsProtected = input.ReadBool();
				break;
			case 80u:
				Rank = input.ReadUInt32();
				break;
			case 88u:
				UniqueId = input.ReadUInt32();
				break;
			case 96u:
				Tid = input.ReadUInt32();
				break;
			}
		}
	}
}
