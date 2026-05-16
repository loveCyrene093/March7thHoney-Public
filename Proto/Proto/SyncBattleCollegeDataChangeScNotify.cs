using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncBattleCollegeDataChangeScNotify : IMessage<SyncBattleCollegeDataChangeScNotify>, IMessage, IEquatable<SyncBattleCollegeDataChangeScNotify>, IDeepCloneable<SyncBattleCollegeDataChangeScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncBattleCollegeDataChangeScNotify> _parser = new MessageParser<SyncBattleCollegeDataChangeScNotify>(() => new SyncBattleCollegeDataChangeScNotify());

	private UnknownFieldSet _unknownFields;

	public const int RewardFieldNumber = 4;

	private ItemList reward_;

	public const int LCDALEEEDJJFieldNumber = 5;

	private uint lCDALEEEDJJ_;

	public const int FinishedCollegeIdListFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_finishedCollegeIdList_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> finishedCollegeIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncBattleCollegeDataChangeScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncBattleCollegeDataChangeScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList Reward
	{
		get
		{
			return reward_;
		}
		set
		{
			reward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LCDALEEEDJJ
	{
		get
		{
			return lCDALEEEDJJ_;
		}
		set
		{
			lCDALEEEDJJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FinishedCollegeIdList => finishedCollegeIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncBattleCollegeDataChangeScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncBattleCollegeDataChangeScNotify(SyncBattleCollegeDataChangeScNotify other)
		: this()
	{
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		lCDALEEEDJJ_ = other.lCDALEEEDJJ_;
		finishedCollegeIdList_ = other.finishedCollegeIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncBattleCollegeDataChangeScNotify Clone()
	{
		return new SyncBattleCollegeDataChangeScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncBattleCollegeDataChangeScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncBattleCollegeDataChangeScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (LCDALEEEDJJ != other.LCDALEEEDJJ)
		{
			return false;
		}
		if (!finishedCollegeIdList_.Equals(other.finishedCollegeIdList_))
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
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		if (LCDALEEEDJJ != 0)
		{
			num ^= LCDALEEEDJJ.GetHashCode();
		}
		num ^= finishedCollegeIdList_.GetHashCode();
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
		if (reward_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Reward);
		}
		if (LCDALEEEDJJ != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(LCDALEEEDJJ);
		}
		finishedCollegeIdList_.WriteTo(ref output, _repeated_finishedCollegeIdList_codec);
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
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (LCDALEEEDJJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LCDALEEEDJJ);
		}
		num += finishedCollegeIdList_.CalculateSize(_repeated_finishedCollegeIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncBattleCollegeDataChangeScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
		}
		if (other.LCDALEEEDJJ != 0)
		{
			LCDALEEEDJJ = other.LCDALEEEDJJ;
		}
		finishedCollegeIdList_.Add(other.finishedCollegeIdList_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 34u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 40u:
				LCDALEEEDJJ = input.ReadUInt32();
				break;
			case 56u:
			case 58u:
				finishedCollegeIdList_.AddEntriesFrom(ref input, _repeated_finishedCollegeIdList_codec);
				break;
			}
		}
	}
}
