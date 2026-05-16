using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IEDEMFKBHFL : IMessage<IEDEMFKBHFL>, IMessage, IEquatable<IEDEMFKBHFL>, IDeepCloneable<IEDEMFKBHFL>, IBufferMessage
{
	private static readonly MessageParser<IEDEMFKBHFL> _parser = new MessageParser<IEDEMFKBHFL>(() => new IEDEMFKBHFL());

	private UnknownFieldSet _unknownFields;

	public const int HJFBAAHDHBHFieldNumber = 13;

	private static readonly FieldCodec<AKCNBOEOAPA> _repeated_hJFBAAHDHBH_codec = FieldCodec.ForMessage(106u, AKCNBOEOAPA.Parser);

	private readonly RepeatedField<AKCNBOEOAPA> hJFBAAHDHBH_ = new RepeatedField<AKCNBOEOAPA>();

	public const int IAPFJINFNLOFieldNumber = 14;

	private uint iAPFJINFNLO_;

	public const int HFEAPHKJDJPFieldNumber = 15;

	private bool hFEAPHKJDJP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IEDEMFKBHFL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IEDEMFKBHFLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AKCNBOEOAPA> HJFBAAHDHBH => hJFBAAHDHBH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IAPFJINFNLO
	{
		get
		{
			return iAPFJINFNLO_;
		}
		set
		{
			iAPFJINFNLO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HFEAPHKJDJP
	{
		get
		{
			return hFEAPHKJDJP_;
		}
		set
		{
			hFEAPHKJDJP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEDEMFKBHFL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEDEMFKBHFL(IEDEMFKBHFL other)
		: this()
	{
		hJFBAAHDHBH_ = other.hJFBAAHDHBH_.Clone();
		iAPFJINFNLO_ = other.iAPFJINFNLO_;
		hFEAPHKJDJP_ = other.hFEAPHKJDJP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEDEMFKBHFL Clone()
	{
		return new IEDEMFKBHFL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IEDEMFKBHFL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IEDEMFKBHFL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hJFBAAHDHBH_.Equals(other.hJFBAAHDHBH_))
		{
			return false;
		}
		if (IAPFJINFNLO != other.IAPFJINFNLO)
		{
			return false;
		}
		if (HFEAPHKJDJP != other.HFEAPHKJDJP)
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
		num ^= hJFBAAHDHBH_.GetHashCode();
		if (IAPFJINFNLO != 0)
		{
			num ^= IAPFJINFNLO.GetHashCode();
		}
		if (HFEAPHKJDJP)
		{
			num ^= HFEAPHKJDJP.GetHashCode();
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
		hJFBAAHDHBH_.WriteTo(ref output, _repeated_hJFBAAHDHBH_codec);
		if (IAPFJINFNLO != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(IAPFJINFNLO);
		}
		if (HFEAPHKJDJP)
		{
			output.WriteRawTag(120);
			output.WriteBool(HFEAPHKJDJP);
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
		num += hJFBAAHDHBH_.CalculateSize(_repeated_hJFBAAHDHBH_codec);
		if (IAPFJINFNLO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IAPFJINFNLO);
		}
		if (HFEAPHKJDJP)
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
	public void MergeFrom(IEDEMFKBHFL other)
	{
		if (other != null)
		{
			hJFBAAHDHBH_.Add(other.hJFBAAHDHBH_);
			if (other.IAPFJINFNLO != 0)
			{
				IAPFJINFNLO = other.IAPFJINFNLO;
			}
			if (other.HFEAPHKJDJP)
			{
				HFEAPHKJDJP = other.HFEAPHKJDJP;
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
			case 106u:
				hJFBAAHDHBH_.AddEntriesFrom(ref input, _repeated_hJFBAAHDHBH_codec);
				break;
			case 112u:
				IAPFJINFNLO = input.ReadUInt32();
				break;
			case 120u:
				HFEAPHKJDJP = input.ReadBool();
				break;
			}
		}
	}
}
