using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class Relic : IMessage<Relic>, IMessage, IEquatable<Relic>, IDeepCloneable<Relic>, IBufferMessage
{
	private static readonly MessageParser<Relic> _parser = new MessageParser<Relic>(() => new Relic());

	private UnknownFieldSet _unknownFields;

	public const int ReforgeSubAffixListFieldNumber = 1;

	private static readonly FieldCodec<RelicAffix> _repeated_reforgeSubAffixList_codec = FieldCodec.ForMessage(10u, RelicAffix.Parser);

	private readonly RepeatedField<RelicAffix> reforgeSubAffixList_ = new RepeatedField<RelicAffix>();

	public const int IsDiscardedFieldNumber = 2;

	private bool isDiscarded_;

	public const int SubAffixListFieldNumber = 3;

	private static readonly FieldCodec<RelicAffix> _repeated_subAffixList_codec = FieldCodec.ForMessage(26u, RelicAffix.Parser);

	private readonly RepeatedField<RelicAffix> subAffixList_ = new RepeatedField<RelicAffix>();

	public const int EBEOECJMBKNFieldNumber = 4;

	private static readonly FieldCodec<RelicAffix> _repeated_eBEOECJMBKN_codec = FieldCodec.ForMessage(34u, RelicAffix.Parser);

	private readonly RepeatedField<RelicAffix> eBEOECJMBKN_ = new RepeatedField<RelicAffix>();

	public const int DressAvatarIdFieldNumber = 5;

	private uint dressAvatarId_;

	public const int IsProtectedFieldNumber = 6;

	private bool isProtected_;

	public const int LevelFieldNumber = 7;

	private uint level_;

	public const int TidFieldNumber = 8;

	private uint tid_;

	public const int MainAffixIdFieldNumber = 9;

	private uint mainAffixId_;

	public const int UniqueIdFieldNumber = 10;

	private uint uniqueId_;

	public const int ReforgeBlockSubAffixIdFieldNumber = 12;

	private uint reforgeBlockSubAffixId_;

	public const int ExpFieldNumber = 13;

	private uint exp_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Relic> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RelicReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RelicAffix> ReforgeSubAffixList => reforgeSubAffixList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsDiscarded
	{
		get
		{
			return isDiscarded_;
		}
		set
		{
			isDiscarded_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RelicAffix> SubAffixList => subAffixList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RelicAffix> EBEOECJMBKN => eBEOECJMBKN_;

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
	public uint MainAffixId
	{
		get
		{
			return mainAffixId_;
		}
		set
		{
			mainAffixId_ = value;
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
	public uint ReforgeBlockSubAffixId
	{
		get
		{
			return reforgeBlockSubAffixId_;
		}
		set
		{
			reforgeBlockSubAffixId_ = value;
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
	public Relic()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Relic(Relic other)
		: this()
	{
		reforgeSubAffixList_ = other.reforgeSubAffixList_.Clone();
		isDiscarded_ = other.isDiscarded_;
		subAffixList_ = other.subAffixList_.Clone();
		eBEOECJMBKN_ = other.eBEOECJMBKN_.Clone();
		dressAvatarId_ = other.dressAvatarId_;
		isProtected_ = other.isProtected_;
		level_ = other.level_;
		tid_ = other.tid_;
		mainAffixId_ = other.mainAffixId_;
		uniqueId_ = other.uniqueId_;
		reforgeBlockSubAffixId_ = other.reforgeBlockSubAffixId_;
		exp_ = other.exp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Relic Clone()
	{
		return new Relic(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as Relic);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Relic other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!reforgeSubAffixList_.Equals(other.reforgeSubAffixList_))
		{
			return false;
		}
		if (IsDiscarded != other.IsDiscarded)
		{
			return false;
		}
		if (!subAffixList_.Equals(other.subAffixList_))
		{
			return false;
		}
		if (!eBEOECJMBKN_.Equals(other.eBEOECJMBKN_))
		{
			return false;
		}
		if (DressAvatarId != other.DressAvatarId)
		{
			return false;
		}
		if (IsProtected != other.IsProtected)
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
		if (MainAffixId != other.MainAffixId)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (ReforgeBlockSubAffixId != other.ReforgeBlockSubAffixId)
		{
			return false;
		}
		if (Exp != other.Exp)
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
		num ^= reforgeSubAffixList_.GetHashCode();
		if (IsDiscarded)
		{
			num ^= IsDiscarded.GetHashCode();
		}
		num ^= subAffixList_.GetHashCode();
		num ^= eBEOECJMBKN_.GetHashCode();
		if (DressAvatarId != 0)
		{
			num ^= DressAvatarId.GetHashCode();
		}
		if (IsProtected)
		{
			num ^= IsProtected.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Tid != 0)
		{
			num ^= Tid.GetHashCode();
		}
		if (MainAffixId != 0)
		{
			num ^= MainAffixId.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (ReforgeBlockSubAffixId != 0)
		{
			num ^= ReforgeBlockSubAffixId.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
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
		reforgeSubAffixList_.WriteTo(ref output, _repeated_reforgeSubAffixList_codec);
		if (IsDiscarded)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsDiscarded);
		}
		subAffixList_.WriteTo(ref output, _repeated_subAffixList_codec);
		eBEOECJMBKN_.WriteTo(ref output, _repeated_eBEOECJMBKN_codec);
		if (DressAvatarId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(DressAvatarId);
		}
		if (IsProtected)
		{
			output.WriteRawTag(48);
			output.WriteBool(IsProtected);
		}
		if (Level != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Level);
		}
		if (Tid != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Tid);
		}
		if (MainAffixId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(MainAffixId);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(UniqueId);
		}
		if (ReforgeBlockSubAffixId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ReforgeBlockSubAffixId);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Exp);
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
		num += reforgeSubAffixList_.CalculateSize(_repeated_reforgeSubAffixList_codec);
		if (IsDiscarded)
		{
			num += 2;
		}
		num += subAffixList_.CalculateSize(_repeated_subAffixList_codec);
		num += eBEOECJMBKN_.CalculateSize(_repeated_eBEOECJMBKN_codec);
		if (DressAvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DressAvatarId);
		}
		if (IsProtected)
		{
			num += 2;
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (Tid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Tid);
		}
		if (MainAffixId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MainAffixId);
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (ReforgeBlockSubAffixId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ReforgeBlockSubAffixId);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Relic other)
	{
		if (other != null)
		{
			reforgeSubAffixList_.Add(other.reforgeSubAffixList_);
			if (other.IsDiscarded)
			{
				IsDiscarded = other.IsDiscarded;
			}
			subAffixList_.Add(other.subAffixList_);
			eBEOECJMBKN_.Add(other.eBEOECJMBKN_);
			if (other.DressAvatarId != 0)
			{
				DressAvatarId = other.DressAvatarId;
			}
			if (other.IsProtected)
			{
				IsProtected = other.IsProtected;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.Tid != 0)
			{
				Tid = other.Tid;
			}
			if (other.MainAffixId != 0)
			{
				MainAffixId = other.MainAffixId;
			}
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			if (other.ReforgeBlockSubAffixId != 0)
			{
				ReforgeBlockSubAffixId = other.ReforgeBlockSubAffixId;
			}
			if (other.Exp != 0)
			{
				Exp = other.Exp;
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
			case 10u:
				reforgeSubAffixList_.AddEntriesFrom(ref input, _repeated_reforgeSubAffixList_codec);
				break;
			case 16u:
				IsDiscarded = input.ReadBool();
				break;
			case 26u:
				subAffixList_.AddEntriesFrom(ref input, _repeated_subAffixList_codec);
				break;
			case 34u:
				eBEOECJMBKN_.AddEntriesFrom(ref input, _repeated_eBEOECJMBKN_codec);
				break;
			case 40u:
				DressAvatarId = input.ReadUInt32();
				break;
			case 48u:
				IsProtected = input.ReadBool();
				break;
			case 56u:
				Level = input.ReadUInt32();
				break;
			case 64u:
				Tid = input.ReadUInt32();
				break;
			case 72u:
				MainAffixId = input.ReadUInt32();
				break;
			case 80u:
				UniqueId = input.ReadUInt32();
				break;
			case 96u:
				ReforgeBlockSubAffixId = input.ReadUInt32();
				break;
			case 104u:
				Exp = input.ReadUInt32();
				break;
			}
		}
	}
}
