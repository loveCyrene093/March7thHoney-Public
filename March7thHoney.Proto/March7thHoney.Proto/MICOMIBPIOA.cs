using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MICOMIBPIOA : IMessage<MICOMIBPIOA>, IMessage, IEquatable<MICOMIBPIOA>, IDeepCloneable<MICOMIBPIOA>, IBufferMessage
{
	private static readonly MessageParser<MICOMIBPIOA> _parser = new MessageParser<MICOMIBPIOA>(() => new MICOMIBPIOA());

	private UnknownFieldSet _unknownFields;

	public const int BAGFAOJMPHEFieldNumber = 3;

	private static readonly FieldCodec<CALIPIKFDEJ> _repeated_bAGFAOJMPHE_codec = FieldCodec.ForMessage(26u, CALIPIKFDEJ.Parser);

	private readonly RepeatedField<CALIPIKFDEJ> bAGFAOJMPHE_ = new RepeatedField<CALIPIKFDEJ>();

	public const int EBMKBDJMAAFFieldNumber = 8;

	private ItemCostData eBMKBDJMAAF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MICOMIBPIOA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MICOMIBPIOAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CALIPIKFDEJ> BAGFAOJMPHE => bAGFAOJMPHE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData EBMKBDJMAAF
	{
		get
		{
			return eBMKBDJMAAF_;
		}
		set
		{
			eBMKBDJMAAF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MICOMIBPIOA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MICOMIBPIOA(MICOMIBPIOA other)
		: this()
	{
		bAGFAOJMPHE_ = other.bAGFAOJMPHE_.Clone();
		eBMKBDJMAAF_ = ((other.eBMKBDJMAAF_ != null) ? other.eBMKBDJMAAF_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MICOMIBPIOA Clone()
	{
		return new MICOMIBPIOA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MICOMIBPIOA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MICOMIBPIOA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bAGFAOJMPHE_.Equals(other.bAGFAOJMPHE_))
		{
			return false;
		}
		if (!object.Equals(EBMKBDJMAAF, other.EBMKBDJMAAF))
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
		num ^= bAGFAOJMPHE_.GetHashCode();
		if (eBMKBDJMAAF_ != null)
		{
			num ^= EBMKBDJMAAF.GetHashCode();
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
		bAGFAOJMPHE_.WriteTo(ref output, _repeated_bAGFAOJMPHE_codec);
		if (eBMKBDJMAAF_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(EBMKBDJMAAF);
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
		num += bAGFAOJMPHE_.CalculateSize(_repeated_bAGFAOJMPHE_codec);
		if (eBMKBDJMAAF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EBMKBDJMAAF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MICOMIBPIOA other)
	{
		if (other == null)
		{
			return;
		}
		bAGFAOJMPHE_.Add(other.bAGFAOJMPHE_);
		if (other.eBMKBDJMAAF_ != null)
		{
			if (eBMKBDJMAAF_ == null)
			{
				EBMKBDJMAAF = new ItemCostData();
			}
			EBMKBDJMAAF.MergeFrom(other.EBMKBDJMAAF);
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
			case 26u:
				bAGFAOJMPHE_.AddEntriesFrom(ref input, _repeated_bAGFAOJMPHE_codec);
				break;
			case 66u:
				if (eBMKBDJMAAF_ == null)
				{
					EBMKBDJMAAF = new ItemCostData();
				}
				input.ReadMessage(EBMKBDJMAAF);
				break;
			}
		}
	}
}
