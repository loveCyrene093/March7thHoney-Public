using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightGameTraitEffectPb : IMessage<GridFightGameTraitEffectPb>, IMessage, IEquatable<GridFightGameTraitEffectPb>, IDeepCloneable<GridFightGameTraitEffectPb>, IBufferMessage
{
	public enum EffectParamOneofCase
	{
		None = 0,
		Threshold = 3,
		CoreRoleUniqueId = 4
	}

	private static readonly MessageParser<GridFightGameTraitEffectPb> _parser = new MessageParser<GridFightGameTraitEffectPb>(() => new GridFightGameTraitEffectPb());

	private UnknownFieldSet _unknownFields;

	public const int TraitIdFieldNumber = 1;

	private uint traitId_;

	public const int EffectIdFieldNumber = 2;

	private uint effectId_;

	public const int ThresholdFieldNumber = 3;

	public const int CoreRoleUniqueIdFieldNumber = 4;

	private object effectParam_;

	private EffectParamOneofCase effectParamCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightGameTraitEffectPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightDataReflection.Descriptor.MessageTypes[16];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint Threshold
	{
		get
		{
			if (!HasThreshold)
			{
				return 0u;
			}
			return (uint)effectParam_;
		}
		set
		{
			effectParam_ = value;
			effectParamCase_ = EffectParamOneofCase.Threshold;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasThreshold => effectParamCase_ == EffectParamOneofCase.Threshold;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CoreRoleUniqueId
	{
		get
		{
			if (!HasCoreRoleUniqueId)
			{
				return 0u;
			}
			return (uint)effectParam_;
		}
		set
		{
			effectParam_ = value;
			effectParamCase_ = EffectParamOneofCase.CoreRoleUniqueId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasCoreRoleUniqueId => effectParamCase_ == EffectParamOneofCase.CoreRoleUniqueId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EffectParamOneofCase EffectParamCase => effectParamCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameTraitEffectPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameTraitEffectPb(GridFightGameTraitEffectPb other)
		: this()
	{
		traitId_ = other.traitId_;
		effectId_ = other.effectId_;
		switch (other.EffectParamCase)
		{
		case EffectParamOneofCase.Threshold:
			Threshold = other.Threshold;
			break;
		case EffectParamOneofCase.CoreRoleUniqueId:
			CoreRoleUniqueId = other.CoreRoleUniqueId;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameTraitEffectPb Clone()
	{
		return new GridFightGameTraitEffectPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearThreshold()
	{
		if (HasThreshold)
		{
			ClearEffectParam();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearCoreRoleUniqueId()
	{
		if (HasCoreRoleUniqueId)
		{
			ClearEffectParam();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearEffectParam()
	{
		effectParamCase_ = EffectParamOneofCase.None;
		effectParam_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightGameTraitEffectPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightGameTraitEffectPb other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TraitId != other.TraitId)
		{
			return false;
		}
		if (EffectId != other.EffectId)
		{
			return false;
		}
		if (Threshold != other.Threshold)
		{
			return false;
		}
		if (CoreRoleUniqueId != other.CoreRoleUniqueId)
		{
			return false;
		}
		if (EffectParamCase != other.EffectParamCase)
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
		if (TraitId != 0)
		{
			num ^= TraitId.GetHashCode();
		}
		if (EffectId != 0)
		{
			num ^= EffectId.GetHashCode();
		}
		if (HasThreshold)
		{
			num ^= Threshold.GetHashCode();
		}
		if (HasCoreRoleUniqueId)
		{
			num ^= CoreRoleUniqueId.GetHashCode();
		}
		num ^= (int)effectParamCase_;
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
		if (TraitId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(TraitId);
		}
		if (EffectId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(EffectId);
		}
		if (HasThreshold)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Threshold);
		}
		if (HasCoreRoleUniqueId)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CoreRoleUniqueId);
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
		if (TraitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TraitId);
		}
		if (EffectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EffectId);
		}
		if (HasThreshold)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Threshold);
		}
		if (HasCoreRoleUniqueId)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CoreRoleUniqueId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightGameTraitEffectPb other)
	{
		if (other != null)
		{
			if (other.TraitId != 0)
			{
				TraitId = other.TraitId;
			}
			if (other.EffectId != 0)
			{
				EffectId = other.EffectId;
			}
			switch (other.EffectParamCase)
			{
			case EffectParamOneofCase.Threshold:
				Threshold = other.Threshold;
				break;
			case EffectParamOneofCase.CoreRoleUniqueId:
				CoreRoleUniqueId = other.CoreRoleUniqueId;
				break;
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
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				TraitId = input.ReadUInt32();
				break;
			case 16u:
				EffectId = input.ReadUInt32();
				break;
			case 24u:
				Threshold = input.ReadUInt32();
				break;
			case 32u:
				CoreRoleUniqueId = input.ReadUInt32();
				break;
			}
		}
	}
}
