using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PPCJBDHDHLL : IMessage<PPCJBDHDHLL>, IMessage, IEquatable<PPCJBDHDHLL>, IDeepCloneable<PPCJBDHDHLL>, IBufferMessage
{
	private static readonly MessageParser<PPCJBDHDHLL> _parser = new MessageParser<PPCJBDHDHLL>(() => new PPCJBDHDHLL());

	private UnknownFieldSet _unknownFields;

	public const int EJAAPIKLMNDFieldNumber = 10;

	private uint eJAAPIKLMND_;

	public const int TraitIdFieldNumber = 11;

	private uint traitId_;

	public const int EffectIdFieldNumber = 14;

	private uint effectId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PPCJBDHDHLL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PPCJBDHDHLLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EJAAPIKLMND
	{
		get
		{
			return eJAAPIKLMND_;
		}
		set
		{
			eJAAPIKLMND_ = value;
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
	public PPCJBDHDHLL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPCJBDHDHLL(PPCJBDHDHLL other)
		: this()
	{
		eJAAPIKLMND_ = other.eJAAPIKLMND_;
		traitId_ = other.traitId_;
		effectId_ = other.effectId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPCJBDHDHLL Clone()
	{
		return new PPCJBDHDHLL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PPCJBDHDHLL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PPCJBDHDHLL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EJAAPIKLMND != other.EJAAPIKLMND)
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
		if (EJAAPIKLMND != 0)
		{
			num ^= EJAAPIKLMND.GetHashCode();
		}
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
		if (EJAAPIKLMND != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(EJAAPIKLMND);
		}
		if (TraitId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(TraitId);
		}
		if (EffectId != 0)
		{
			output.WriteRawTag(112);
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
		if (EJAAPIKLMND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EJAAPIKLMND);
		}
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
	public void MergeFrom(PPCJBDHDHLL other)
	{
		if (other != null)
		{
			if (other.EJAAPIKLMND != 0)
			{
				EJAAPIKLMND = other.EJAAPIKLMND;
			}
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
			case 80u:
				EJAAPIKLMND = input.ReadUInt32();
				break;
			case 88u:
				TraitId = input.ReadUInt32();
				break;
			case 112u:
				EffectId = input.ReadUInt32();
				break;
			}
		}
	}
}
