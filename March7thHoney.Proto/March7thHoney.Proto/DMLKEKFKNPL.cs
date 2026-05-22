using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DMLKEKFKNPL : IMessage<DMLKEKFKNPL>, IMessage, IEquatable<DMLKEKFKNPL>, IDeepCloneable<DMLKEKFKNPL>, IBufferMessage
{
	private static readonly MessageParser<DMLKEKFKNPL> _parser = new MessageParser<DMLKEKFKNPL>(() => new DMLKEKFKNPL());

	private UnknownFieldSet _unknownFields;

	public const int EffectIdFieldNumber = 1;

	private uint effectId_;

	public const int SwitchListFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_switchList_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> switchList_ = new RepeatedField<uint>();

	public const int TraitEffectLevelRewardFieldNumber = 5;

	private static readonly MapField<uint, GridFightDropInfo>.Codec _map_traitEffectLevelReward_codec = new MapField<uint, GridFightDropInfo>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, GridFightDropInfo.Parser), 42u);

	private readonly MapField<uint, GridFightDropInfo> traitEffectLevelReward_ = new MapField<uint, GridFightDropInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DMLKEKFKNPL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DMLKEKFKNPLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EffectId
	{
		get
		{
			return effectId_;
		}
		set
		{
			effectId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> SwitchList => switchList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, GridFightDropInfo> TraitEffectLevelReward => traitEffectLevelReward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMLKEKFKNPL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMLKEKFKNPL(DMLKEKFKNPL other)
		: this()
	{
		effectId_ = other.effectId_;
		switchList_ = other.switchList_.Clone();
		traitEffectLevelReward_ = other.traitEffectLevelReward_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMLKEKFKNPL Clone()
	{
		return new DMLKEKFKNPL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DMLKEKFKNPL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DMLKEKFKNPL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EffectId != other.EffectId)
		{
			return false;
		}
		if (!switchList_.Equals(other.switchList_))
		{
			return false;
		}
		if (!TraitEffectLevelReward.Equals(other.TraitEffectLevelReward))
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
		if (EffectId != 0)
		{
			num ^= EffectId.GetHashCode();
		}
		num ^= switchList_.GetHashCode();
		num ^= TraitEffectLevelReward.GetHashCode();
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
		if (EffectId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(EffectId);
		}
		switchList_.WriteTo(ref output, _repeated_switchList_codec);
		traitEffectLevelReward_.WriteTo(ref output, _map_traitEffectLevelReward_codec);
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
		if (EffectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EffectId);
		}
		num += switchList_.CalculateSize(_repeated_switchList_codec);
		num += traitEffectLevelReward_.CalculateSize(_map_traitEffectLevelReward_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DMLKEKFKNPL other)
	{
		if (other != null)
		{
			if (other.EffectId != 0)
			{
				EffectId = other.EffectId;
			}
			switchList_.Add(other.switchList_);
			traitEffectLevelReward_.MergeFrom(other.traitEffectLevelReward_);
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
			case 8u:
				EffectId = input.ReadUInt32();
				break;
			case 16u:
			case 18u:
				switchList_.AddEntriesFrom(ref input, _repeated_switchList_codec);
				break;
			case 42u:
				traitEffectLevelReward_.AddEntriesFrom(ref input, _map_traitEffectLevelReward_codec);
				break;
			}
		}
	}
}
