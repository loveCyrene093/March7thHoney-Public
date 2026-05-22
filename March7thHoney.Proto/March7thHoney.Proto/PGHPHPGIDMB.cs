using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PGHPHPGIDMB : IMessage<PGHPHPGIDMB>, IMessage, IEquatable<PGHPHPGIDMB>, IDeepCloneable<PGHPHPGIDMB>, IBufferMessage
{
	private static readonly MessageParser<PGHPHPGIDMB> _parser = new MessageParser<PGHPHPGIDMB>(() => new PGHPHPGIDMB());

	private UnknownFieldSet _unknownFields;

	public const int KJMJPDNMOIBFieldNumber = 5;

	private uint kJMJPDNMOIB_;

	public const int TypeFieldNumber = 8;

	private uint type_;

	public const int ENFOFEAKDDKFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_eNFOFEAKDDK_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> eNFOFEAKDDK_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PGHPHPGIDMB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PGHPHPGIDMBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KJMJPDNMOIB
	{
		get
		{
			return kJMJPDNMOIB_;
		}
		set
		{
			kJMJPDNMOIB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ENFOFEAKDDK => eNFOFEAKDDK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGHPHPGIDMB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGHPHPGIDMB(PGHPHPGIDMB other)
		: this()
	{
		kJMJPDNMOIB_ = other.kJMJPDNMOIB_;
		type_ = other.type_;
		eNFOFEAKDDK_ = other.eNFOFEAKDDK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGHPHPGIDMB Clone()
	{
		return new PGHPHPGIDMB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PGHPHPGIDMB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PGHPHPGIDMB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KJMJPDNMOIB != other.KJMJPDNMOIB)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (!eNFOFEAKDDK_.Equals(other.eNFOFEAKDDK_))
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
		if (KJMJPDNMOIB != 0)
		{
			num ^= KJMJPDNMOIB.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		num ^= eNFOFEAKDDK_.GetHashCode();
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
		if (KJMJPDNMOIB != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(KJMJPDNMOIB);
		}
		if (Type != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Type);
		}
		eNFOFEAKDDK_.WriteTo(ref output, _repeated_eNFOFEAKDDK_codec);
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
		if (KJMJPDNMOIB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KJMJPDNMOIB);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Type);
		}
		num += eNFOFEAKDDK_.CalculateSize(_repeated_eNFOFEAKDDK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PGHPHPGIDMB other)
	{
		if (other != null)
		{
			if (other.KJMJPDNMOIB != 0)
			{
				KJMJPDNMOIB = other.KJMJPDNMOIB;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			eNFOFEAKDDK_.Add(other.eNFOFEAKDDK_);
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
			case 40u:
				KJMJPDNMOIB = input.ReadUInt32();
				break;
			case 64u:
				Type = input.ReadUInt32();
				break;
			case 104u:
			case 106u:
				eNFOFEAKDDK_.AddEntriesFrom(ref input, _repeated_eNFOFEAKDDK_codec);
				break;
			}
		}
	}
}
