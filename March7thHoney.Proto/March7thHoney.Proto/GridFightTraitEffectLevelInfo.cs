using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightTraitEffectLevelInfo : IMessage<GridFightTraitEffectLevelInfo>, IMessage, IEquatable<GridFightTraitEffectLevelInfo>, IDeepCloneable<GridFightTraitEffectLevelInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightTraitEffectLevelInfo> _parser = new MessageParser<GridFightTraitEffectLevelInfo>(() => new GridFightTraitEffectLevelInfo());

	private UnknownFieldSet _unknownFields;

	public const int TraitEffectLevelExpFieldNumber = 1;

	private uint traitEffectLevelExp_;

	public const int TraitEffectLevelRewardFieldNumber = 2;

	private static readonly MapField<uint, GridFightDropInfo>.Codec _map_traitEffectLevelReward_codec = new MapField<uint, GridFightDropInfo>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, GridFightDropInfo.Parser), 18u);

	private readonly MapField<uint, GridFightDropInfo> traitEffectLevelReward_ = new MapField<uint, GridFightDropInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightTraitEffectLevelInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightTraitEffectLevelInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TraitEffectLevelExp
	{
		get
		{
			return traitEffectLevelExp_;
		}
		set
		{
			traitEffectLevelExp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, GridFightDropInfo> TraitEffectLevelReward => traitEffectLevelReward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitEffectLevelInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitEffectLevelInfo(GridFightTraitEffectLevelInfo other)
		: this()
	{
		traitEffectLevelExp_ = other.traitEffectLevelExp_;
		traitEffectLevelReward_ = other.traitEffectLevelReward_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitEffectLevelInfo Clone()
	{
		return new GridFightTraitEffectLevelInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightTraitEffectLevelInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightTraitEffectLevelInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TraitEffectLevelExp != other.TraitEffectLevelExp)
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
		if (TraitEffectLevelExp != 0)
		{
			num ^= TraitEffectLevelExp.GetHashCode();
		}
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
		if (TraitEffectLevelExp != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(TraitEffectLevelExp);
		}
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
		if (TraitEffectLevelExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TraitEffectLevelExp);
		}
		num += traitEffectLevelReward_.CalculateSize(_map_traitEffectLevelReward_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightTraitEffectLevelInfo other)
	{
		if (other != null)
		{
			if (other.TraitEffectLevelExp != 0)
			{
				TraitEffectLevelExp = other.TraitEffectLevelExp;
			}
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
				TraitEffectLevelExp = input.ReadUInt32();
				break;
			case 18u:
				traitEffectLevelReward_.AddEntriesFrom(ref input, _map_traitEffectLevelReward_codec);
				break;
			}
		}
	}
}
