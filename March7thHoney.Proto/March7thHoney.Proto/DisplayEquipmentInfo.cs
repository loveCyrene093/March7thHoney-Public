using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DisplayEquipmentInfo : IMessage<DisplayEquipmentInfo>, IMessage, IEquatable<DisplayEquipmentInfo>, IDeepCloneable<DisplayEquipmentInfo>, IBufferMessage
{
	private static readonly MessageParser<DisplayEquipmentInfo> _parser = new MessageParser<DisplayEquipmentInfo>(() => new DisplayEquipmentInfo());

	private UnknownFieldSet _unknownFields;

	public const int ExpFieldNumber = 2;

	private uint exp_;

	public const int RankFieldNumber = 8;

	private uint rank_;

	public const int LevelFieldNumber = 9;

	private uint level_;

	public const int TidFieldNumber = 11;

	private uint tid_;

	public const int PromotionFieldNumber = 13;

	private uint promotion_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DisplayEquipmentInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DisplayEquipmentInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public DisplayEquipmentInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DisplayEquipmentInfo(DisplayEquipmentInfo other)
		: this()
	{
		exp_ = other.exp_;
		rank_ = other.rank_;
		level_ = other.level_;
		tid_ = other.tid_;
		promotion_ = other.promotion_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DisplayEquipmentInfo Clone()
	{
		return new DisplayEquipmentInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DisplayEquipmentInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DisplayEquipmentInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (Rank != other.Rank)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Tid != other.Tid)
		{
			return false;
		}
		if (Promotion != other.Promotion)
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
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Tid != 0)
		{
			num ^= Tid.GetHashCode();
		}
		if (Promotion != 0)
		{
			num ^= Promotion.GetHashCode();
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
		if (Exp != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Exp);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Rank);
		}
		if (Level != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Level);
		}
		if (Tid != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Tid);
		}
		if (Promotion != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Promotion);
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
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rank);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (Tid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Tid);
		}
		if (Promotion != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Promotion);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DisplayEquipmentInfo other)
	{
		if (other != null)
		{
			if (other.Exp != 0)
			{
				Exp = other.Exp;
			}
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.Tid != 0)
			{
				Tid = other.Tid;
			}
			if (other.Promotion != 0)
			{
				Promotion = other.Promotion;
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
			case 16u:
				Exp = input.ReadUInt32();
				break;
			case 64u:
				Rank = input.ReadUInt32();
				break;
			case 72u:
				Level = input.ReadUInt32();
				break;
			case 88u:
				Tid = input.ReadUInt32();
				break;
			case 104u:
				Promotion = input.ReadUInt32();
				break;
			}
		}
	}
}
