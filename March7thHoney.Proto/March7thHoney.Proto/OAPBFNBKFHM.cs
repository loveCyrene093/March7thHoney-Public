using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OAPBFNBKFHM : IMessage<OAPBFNBKFHM>, IMessage, IEquatable<OAPBFNBKFHM>, IDeepCloneable<OAPBFNBKFHM>, IBufferMessage
{
	private static readonly MessageParser<OAPBFNBKFHM> _parser = new MessageParser<OAPBFNBKFHM>(() => new OAPBFNBKFHM());

	private UnknownFieldSet _unknownFields;

	public const int KLNIAGAEFKEFieldNumber = 3;

	private uint kLNIAGAEFKE_;

	public const int LJFLBPDCJGJFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_lJFLBPDCJGJ_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> lJFLBPDCJGJ_ = new RepeatedField<uint>();

	public const int CHCGMAMOBMHFieldNumber = 11;

	private bool cHCGMAMOBMH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OAPBFNBKFHM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OAPBFNBKFHMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KLNIAGAEFKE
	{
		get
		{
			return kLNIAGAEFKE_;
		}
		set
		{
			kLNIAGAEFKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LJFLBPDCJGJ => lJFLBPDCJGJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CHCGMAMOBMH
	{
		get
		{
			return cHCGMAMOBMH_;
		}
		set
		{
			cHCGMAMOBMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OAPBFNBKFHM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OAPBFNBKFHM(OAPBFNBKFHM other)
		: this()
	{
		kLNIAGAEFKE_ = other.kLNIAGAEFKE_;
		lJFLBPDCJGJ_ = other.lJFLBPDCJGJ_.Clone();
		cHCGMAMOBMH_ = other.cHCGMAMOBMH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OAPBFNBKFHM Clone()
	{
		return new OAPBFNBKFHM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OAPBFNBKFHM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OAPBFNBKFHM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KLNIAGAEFKE != other.KLNIAGAEFKE)
		{
			return false;
		}
		if (!lJFLBPDCJGJ_.Equals(other.lJFLBPDCJGJ_))
		{
			return false;
		}
		if (CHCGMAMOBMH != other.CHCGMAMOBMH)
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
		if (KLNIAGAEFKE != 0)
		{
			num ^= KLNIAGAEFKE.GetHashCode();
		}
		num ^= lJFLBPDCJGJ_.GetHashCode();
		if (CHCGMAMOBMH)
		{
			num ^= CHCGMAMOBMH.GetHashCode();
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
		if (KLNIAGAEFKE != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(KLNIAGAEFKE);
		}
		lJFLBPDCJGJ_.WriteTo(ref output, _repeated_lJFLBPDCJGJ_codec);
		if (CHCGMAMOBMH)
		{
			output.WriteRawTag(88);
			output.WriteBool(CHCGMAMOBMH);
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
		if (KLNIAGAEFKE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KLNIAGAEFKE);
		}
		num += lJFLBPDCJGJ_.CalculateSize(_repeated_lJFLBPDCJGJ_codec);
		if (CHCGMAMOBMH)
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
	public void MergeFrom(OAPBFNBKFHM other)
	{
		if (other != null)
		{
			if (other.KLNIAGAEFKE != 0)
			{
				KLNIAGAEFKE = other.KLNIAGAEFKE;
			}
			lJFLBPDCJGJ_.Add(other.lJFLBPDCJGJ_);
			if (other.CHCGMAMOBMH)
			{
				CHCGMAMOBMH = other.CHCGMAMOBMH;
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
			case 24u:
				KLNIAGAEFKE = input.ReadUInt32();
				break;
			case 64u:
			case 66u:
				lJFLBPDCJGJ_.AddEntriesFrom(ref input, _repeated_lJFLBPDCJGJ_codec);
				break;
			case 88u:
				CHCGMAMOBMH = input.ReadBool();
				break;
			}
		}
	}
}
