using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightTraitActionInfo : IMessage<GridFightTraitActionInfo>, IMessage, IEquatable<GridFightTraitActionInfo>, IDeepCloneable<GridFightTraitActionInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightTraitActionInfo> _parser = new MessageParser<GridFightTraitActionInfo>(() => new GridFightTraitActionInfo());

	private UnknownFieldSet _unknownFields;

	public const int GridFightTraitMemberUniqueIdListFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_gridFightTraitMemberUniqueIdList_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> gridFightTraitMemberUniqueIdList_ = new RepeatedField<uint>();

	public const int TraitIdFieldNumber = 14;

	private uint traitId_;

	public const int EffectIdFieldNumber = 15;

	private uint effectId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightTraitActionInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightTraitActionInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GridFightTraitMemberUniqueIdList => gridFightTraitMemberUniqueIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TraitId
	{
		get
		{
			return traitId_;
		}
		set
		{
			traitId_ = value;
		}
	}

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
	public GridFightTraitActionInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitActionInfo(GridFightTraitActionInfo other)
		: this()
	{
		gridFightTraitMemberUniqueIdList_ = other.gridFightTraitMemberUniqueIdList_.Clone();
		traitId_ = other.traitId_;
		effectId_ = other.effectId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitActionInfo Clone()
	{
		return new GridFightTraitActionInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightTraitActionInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightTraitActionInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gridFightTraitMemberUniqueIdList_.Equals(other.gridFightTraitMemberUniqueIdList_))
		{
			return false;
		}
		if (TraitId != other.TraitId)
		{
			return false;
		}
		if (EffectId != other.EffectId)
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
		num ^= gridFightTraitMemberUniqueIdList_.GetHashCode();
		if (TraitId != 0)
		{
			num ^= TraitId.GetHashCode();
		}
		if (EffectId != 0)
		{
			num ^= EffectId.GetHashCode();
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
		gridFightTraitMemberUniqueIdList_.WriteTo(ref output, _repeated_gridFightTraitMemberUniqueIdList_codec);
		if (TraitId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(TraitId);
		}
		if (EffectId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(EffectId);
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
		num += gridFightTraitMemberUniqueIdList_.CalculateSize(_repeated_gridFightTraitMemberUniqueIdList_codec);
		if (TraitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TraitId);
		}
		if (EffectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EffectId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightTraitActionInfo other)
	{
		if (other != null)
		{
			gridFightTraitMemberUniqueIdList_.Add(other.gridFightTraitMemberUniqueIdList_);
			if (other.TraitId != 0)
			{
				TraitId = other.TraitId;
			}
			if (other.EffectId != 0)
			{
				EffectId = other.EffectId;
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
			case 96u:
			case 98u:
				gridFightTraitMemberUniqueIdList_.AddEntriesFrom(ref input, _repeated_gridFightTraitMemberUniqueIdList_codec);
				break;
			case 112u:
				TraitId = input.ReadUInt32();
				break;
			case 120u:
				EffectId = input.ReadUInt32();
				break;
			}
		}
	}
}
