using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LGGABHPGPDD : IMessage<LGGABHPGPDD>, IMessage, IEquatable<LGGABHPGPDD>, IDeepCloneable<LGGABHPGPDD>, IBufferMessage
{
	private static readonly MessageParser<LGGABHPGPDD> _parser = new MessageParser<LGGABHPGPDD>(() => new LGGABHPGPDD());

	private UnknownFieldSet _unknownFields;

	public const int LIPHDPLGMNPFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_lIPHDPLGMNP_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> lIPHDPLGMNP_ = new RepeatedField<uint>();

	public const int HCJPDNDOHAMFieldNumber = 13;

	private uint hCJPDNDOHAM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LGGABHPGPDD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LGGABHPGPDDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LIPHDPLGMNP => lIPHDPLGMNP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HCJPDNDOHAM
	{
		get
		{
			return hCJPDNDOHAM_;
		}
		set
		{
			hCJPDNDOHAM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGGABHPGPDD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGGABHPGPDD(LGGABHPGPDD other)
		: this()
	{
		lIPHDPLGMNP_ = other.lIPHDPLGMNP_.Clone();
		hCJPDNDOHAM_ = other.hCJPDNDOHAM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGGABHPGPDD Clone()
	{
		return new LGGABHPGPDD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LGGABHPGPDD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LGGABHPGPDD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lIPHDPLGMNP_.Equals(other.lIPHDPLGMNP_))
		{
			return false;
		}
		if (HCJPDNDOHAM != other.HCJPDNDOHAM)
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
		num ^= lIPHDPLGMNP_.GetHashCode();
		if (HCJPDNDOHAM != 0)
		{
			num ^= HCJPDNDOHAM.GetHashCode();
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
		lIPHDPLGMNP_.WriteTo(ref output, _repeated_lIPHDPLGMNP_codec);
		if (HCJPDNDOHAM != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(HCJPDNDOHAM);
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
		num += lIPHDPLGMNP_.CalculateSize(_repeated_lIPHDPLGMNP_codec);
		if (HCJPDNDOHAM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCJPDNDOHAM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LGGABHPGPDD other)
	{
		if (other != null)
		{
			lIPHDPLGMNP_.Add(other.lIPHDPLGMNP_);
			if (other.HCJPDNDOHAM != 0)
			{
				HCJPDNDOHAM = other.HCJPDNDOHAM;
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
			case 96u:
			case 98u:
				lIPHDPLGMNP_.AddEntriesFrom(ref input, _repeated_lIPHDPLGMNP_codec);
				break;
			case 104u:
				HCJPDNDOHAM = input.ReadUInt32();
				break;
			}
		}
	}
}
