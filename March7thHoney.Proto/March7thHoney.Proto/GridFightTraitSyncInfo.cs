using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightTraitSyncInfo : IMessage<GridFightTraitSyncInfo>, IMessage, IEquatable<GridFightTraitSyncInfo>, IDeepCloneable<GridFightTraitSyncInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightTraitSyncInfo> _parser = new MessageParser<GridFightTraitSyncInfo>(() => new GridFightTraitSyncInfo());

	private UnknownFieldSet _unknownFields;

	public const int TraitEffectInfoFieldNumber = 12;

	private GridFightTraitEffectInfo traitEffectInfo_;

	public const int TraitIdFieldNumber = 13;

	private uint traitId_;

	public const int IsSyncEffectFieldNumber = 15;

	private bool isSyncEffect_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightTraitSyncInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightTraitSyncInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitEffectInfo TraitEffectInfo
	{
		get
		{
			return traitEffectInfo_;
		}
		set
		{
			traitEffectInfo_ = value;
		}
	}

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
	public bool IsSyncEffect
	{
		get
		{
			return isSyncEffect_;
		}
		set
		{
			isSyncEffect_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitSyncInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitSyncInfo(GridFightTraitSyncInfo other)
		: this()
	{
		traitEffectInfo_ = ((other.traitEffectInfo_ != null) ? other.traitEffectInfo_.Clone() : null);
		traitId_ = other.traitId_;
		isSyncEffect_ = other.isSyncEffect_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitSyncInfo Clone()
	{
		return new GridFightTraitSyncInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightTraitSyncInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightTraitSyncInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(TraitEffectInfo, other.TraitEffectInfo))
		{
			return false;
		}
		if (TraitId != other.TraitId)
		{
			return false;
		}
		if (IsSyncEffect != other.IsSyncEffect)
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
		if (traitEffectInfo_ != null)
		{
			num ^= TraitEffectInfo.GetHashCode();
		}
		if (TraitId != 0)
		{
			num ^= TraitId.GetHashCode();
		}
		if (IsSyncEffect)
		{
			num ^= IsSyncEffect.GetHashCode();
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
		if (traitEffectInfo_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(TraitEffectInfo);
		}
		if (TraitId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(TraitId);
		}
		if (IsSyncEffect)
		{
			output.WriteRawTag(120);
			output.WriteBool(IsSyncEffect);
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
		if (traitEffectInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TraitEffectInfo);
		}
		if (TraitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TraitId);
		}
		if (IsSyncEffect)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightTraitSyncInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.traitEffectInfo_ != null)
		{
			if (traitEffectInfo_ == null)
			{
				TraitEffectInfo = new GridFightTraitEffectInfo();
			}
			TraitEffectInfo.MergeFrom(other.TraitEffectInfo);
		}
		if (other.TraitId != 0)
		{
			TraitId = other.TraitId;
		}
		if (other.IsSyncEffect)
		{
			IsSyncEffect = other.IsSyncEffect;
		}
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
			case 98u:
				if (traitEffectInfo_ == null)
				{
					TraitEffectInfo = new GridFightTraitEffectInfo();
				}
				input.ReadMessage(TraitEffectInfo);
				break;
			case 104u:
				TraitId = input.ReadUInt32();
				break;
			case 120u:
				IsSyncEffect = input.ReadBool();
				break;
			}
		}
	}
}
