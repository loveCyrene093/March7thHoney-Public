using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MDKPOAEEGJB : IMessage<MDKPOAEEGJB>, IMessage, IEquatable<MDKPOAEEGJB>, IDeepCloneable<MDKPOAEEGJB>, IBufferMessage
{
	private static readonly MessageParser<MDKPOAEEGJB> _parser = new MessageParser<MDKPOAEEGJB>(() => new MDKPOAEEGJB());

	private UnknownFieldSet _unknownFields;

	public const int BCNABLEDJBEFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_bCNABLEDJBE_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> bCNABLEDJBE_ = new RepeatedField<uint>();

	public const int LOPGHGKNBCJFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_lOPGHGKNBCJ_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> lOPGHGKNBCJ_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MDKPOAEEGJB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MDKPOAEEGJBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BCNABLEDJBE => bCNABLEDJBE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LOPGHGKNBCJ => lOPGHGKNBCJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDKPOAEEGJB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDKPOAEEGJB(MDKPOAEEGJB other)
		: this()
	{
		bCNABLEDJBE_ = other.bCNABLEDJBE_.Clone();
		lOPGHGKNBCJ_ = other.lOPGHGKNBCJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDKPOAEEGJB Clone()
	{
		return new MDKPOAEEGJB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MDKPOAEEGJB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MDKPOAEEGJB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bCNABLEDJBE_.Equals(other.bCNABLEDJBE_))
		{
			return false;
		}
		if (!lOPGHGKNBCJ_.Equals(other.lOPGHGKNBCJ_))
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
		num ^= bCNABLEDJBE_.GetHashCode();
		num ^= lOPGHGKNBCJ_.GetHashCode();
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
		bCNABLEDJBE_.WriteTo(ref output, _repeated_bCNABLEDJBE_codec);
		lOPGHGKNBCJ_.WriteTo(ref output, _repeated_lOPGHGKNBCJ_codec);
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
		num += bCNABLEDJBE_.CalculateSize(_repeated_bCNABLEDJBE_codec);
		num += lOPGHGKNBCJ_.CalculateSize(_repeated_lOPGHGKNBCJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MDKPOAEEGJB other)
	{
		if (other != null)
		{
			bCNABLEDJBE_.Add(other.bCNABLEDJBE_);
			lOPGHGKNBCJ_.Add(other.lOPGHGKNBCJ_);
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
			case 72u:
			case 74u:
				bCNABLEDJBE_.AddEntriesFrom(ref input, _repeated_bCNABLEDJBE_codec);
				break;
			case 120u:
			case 122u:
				lOPGHGKNBCJ_.AddEntriesFrom(ref input, _repeated_lOPGHGKNBCJ_codec);
				break;
			}
		}
	}
}
