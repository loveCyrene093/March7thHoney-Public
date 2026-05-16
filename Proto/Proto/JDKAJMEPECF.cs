using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JDKAJMEPECF : IMessage<JDKAJMEPECF>, IMessage, IEquatable<JDKAJMEPECF>, IDeepCloneable<JDKAJMEPECF>, IBufferMessage
{
	private static readonly MessageParser<JDKAJMEPECF> _parser = new MessageParser<JDKAJMEPECF>(() => new JDKAJMEPECF());

	private UnknownFieldSet _unknownFields;

	public const int EFOLENMOFKPFieldNumber = 7;

	private static readonly FieldCodec<ActiveTraitSourceList> _repeated_eFOLENMOFKP_codec = FieldCodec.ForMessage(58u, ActiveTraitSourceList.Parser);

	private readonly RepeatedField<ActiveTraitSourceList> eFOLENMOFKP_ = new RepeatedField<ActiveTraitSourceList>();

	public const int TraitIdFieldNumber = 9;

	private uint traitId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JDKAJMEPECF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JDKAJMEPECFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ActiveTraitSourceList> EFOLENMOFKP => eFOLENMOFKP_;

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
	public JDKAJMEPECF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JDKAJMEPECF(JDKAJMEPECF other)
		: this()
	{
		eFOLENMOFKP_ = other.eFOLENMOFKP_.Clone();
		traitId_ = other.traitId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JDKAJMEPECF Clone()
	{
		return new JDKAJMEPECF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JDKAJMEPECF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JDKAJMEPECF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!eFOLENMOFKP_.Equals(other.eFOLENMOFKP_))
		{
			return false;
		}
		if (TraitId != other.TraitId)
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
		num ^= eFOLENMOFKP_.GetHashCode();
		if (TraitId != 0)
		{
			num ^= TraitId.GetHashCode();
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
		eFOLENMOFKP_.WriteTo(ref output, _repeated_eFOLENMOFKP_codec);
		if (TraitId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(TraitId);
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
		num += eFOLENMOFKP_.CalculateSize(_repeated_eFOLENMOFKP_codec);
		if (TraitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TraitId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JDKAJMEPECF other)
	{
		if (other != null)
		{
			eFOLENMOFKP_.Add(other.eFOLENMOFKP_);
			if (other.TraitId != 0)
			{
				TraitId = other.TraitId;
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
			case 58u:
				eFOLENMOFKP_.AddEntriesFrom(ref input, _repeated_eFOLENMOFKP_codec);
				break;
			case 72u:
				TraitId = input.ReadUInt32();
				break;
			}
		}
	}
}
