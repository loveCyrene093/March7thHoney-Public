using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CFHFFEKEKJH : IMessage<CFHFFEKEKJH>, IMessage, IEquatable<CFHFFEKEKJH>, IDeepCloneable<CFHFFEKEKJH>, IBufferMessage
{
	private static readonly MessageParser<CFHFFEKEKJH> _parser = new MessageParser<CFHFFEKEKJH>(() => new CFHFFEKEKJH());

	private UnknownFieldSet _unknownFields;

	public const int EffectIdFieldNumber = 1;

	private uint effectId_;

	public const int HCCKJOKKADEFieldNumber = 2;

	private uint hCCKJOKKADE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CFHFFEKEKJH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CFHFFEKEKJHReflection.Descriptor.MessageTypes[0];

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
	public uint HCCKJOKKADE
	{
		get
		{
			return hCCKJOKKADE_;
		}
		set
		{
			hCCKJOKKADE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CFHFFEKEKJH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CFHFFEKEKJH(CFHFFEKEKJH other)
		: this()
	{
		effectId_ = other.effectId_;
		hCCKJOKKADE_ = other.hCCKJOKKADE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CFHFFEKEKJH Clone()
	{
		return new CFHFFEKEKJH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CFHFFEKEKJH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CFHFFEKEKJH other)
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
		if (HCCKJOKKADE != other.HCCKJOKKADE)
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
		if (HCCKJOKKADE != 0)
		{
			num ^= HCCKJOKKADE.GetHashCode();
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
		if (EffectId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(EffectId);
		}
		if (HCCKJOKKADE != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(HCCKJOKKADE);
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
		if (EffectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EffectId);
		}
		if (HCCKJOKKADE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCCKJOKKADE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CFHFFEKEKJH other)
	{
		if (other != null)
		{
			if (other.EffectId != 0)
			{
				EffectId = other.EffectId;
			}
			if (other.HCCKJOKKADE != 0)
			{
				HCCKJOKKADE = other.HCCKJOKKADE;
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
			case 8u:
				EffectId = input.ReadUInt32();
				break;
			case 16u:
				HCCKJOKKADE = input.ReadUInt32();
				break;
			}
		}
	}
}
