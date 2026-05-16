using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IEBAILGKMLB : IMessage<IEBAILGKMLB>, IMessage, IEquatable<IEBAILGKMLB>, IDeepCloneable<IEBAILGKMLB>, IBufferMessage
{
	private static readonly MessageParser<IEBAILGKMLB> _parser = new MessageParser<IEBAILGKMLB>(() => new IEBAILGKMLB());

	private UnknownFieldSet _unknownFields;

	public const int EFGOMGGGHCPFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_eFGOMGGGHCP_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> eFGOMGGGHCP_ = new RepeatedField<uint>();

	public const int IKEPBELACGPFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_iKEPBELACGP_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> iKEPBELACGP_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IEBAILGKMLB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IEBAILGKMLBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EFGOMGGGHCP => eFGOMGGGHCP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IKEPBELACGP => iKEPBELACGP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEBAILGKMLB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEBAILGKMLB(IEBAILGKMLB other)
		: this()
	{
		eFGOMGGGHCP_ = other.eFGOMGGGHCP_.Clone();
		iKEPBELACGP_ = other.iKEPBELACGP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEBAILGKMLB Clone()
	{
		return new IEBAILGKMLB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IEBAILGKMLB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IEBAILGKMLB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!eFGOMGGGHCP_.Equals(other.eFGOMGGGHCP_))
		{
			return false;
		}
		if (!iKEPBELACGP_.Equals(other.iKEPBELACGP_))
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
		num ^= eFGOMGGGHCP_.GetHashCode();
		num ^= iKEPBELACGP_.GetHashCode();
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
		eFGOMGGGHCP_.WriteTo(ref output, _repeated_eFGOMGGGHCP_codec);
		iKEPBELACGP_.WriteTo(ref output, _repeated_iKEPBELACGP_codec);
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
		num += eFGOMGGGHCP_.CalculateSize(_repeated_eFGOMGGGHCP_codec);
		num += iKEPBELACGP_.CalculateSize(_repeated_iKEPBELACGP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IEBAILGKMLB other)
	{
		if (other != null)
		{
			eFGOMGGGHCP_.Add(other.eFGOMGGGHCP_);
			iKEPBELACGP_.Add(other.iKEPBELACGP_);
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
			case 48u:
			case 50u:
				eFGOMGGGHCP_.AddEntriesFrom(ref input, _repeated_eFGOMGGGHCP_codec);
				break;
			case 72u:
			case 74u:
				iKEPBELACGP_.AddEntriesFrom(ref input, _repeated_iKEPBELACGP_codec);
				break;
			}
		}
	}
}
