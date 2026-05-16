using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AMGMAIOKJLN : IMessage<AMGMAIOKJLN>, IMessage, IEquatable<AMGMAIOKJLN>, IDeepCloneable<AMGMAIOKJLN>, IBufferMessage
{
	private static readonly MessageParser<AMGMAIOKJLN> _parser = new MessageParser<AMGMAIOKJLN>(() => new AMGMAIOKJLN());

	private UnknownFieldSet _unknownFields;

	public const int OIAECFMLPHKFieldNumber = 5;

	private uint oIAECFMLPHK_;

	public const int FOMNFHJCDOCFieldNumber = 10;

	private uint fOMNFHJCDOC_;

	public const int BFAMFABBCIOFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_bFAMFABBCIO_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> bFAMFABBCIO_ = new RepeatedField<uint>();

	public const int BKDINONLAHDFieldNumber = 15;

	private bool bKDINONLAHD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AMGMAIOKJLN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AMGMAIOKJLNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OIAECFMLPHK
	{
		get
		{
			return oIAECFMLPHK_;
		}
		set
		{
			oIAECFMLPHK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FOMNFHJCDOC
	{
		get
		{
			return fOMNFHJCDOC_;
		}
		set
		{
			fOMNFHJCDOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BFAMFABBCIO => bFAMFABBCIO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BKDINONLAHD
	{
		get
		{
			return bKDINONLAHD_;
		}
		set
		{
			bKDINONLAHD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AMGMAIOKJLN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AMGMAIOKJLN(AMGMAIOKJLN other)
		: this()
	{
		oIAECFMLPHK_ = other.oIAECFMLPHK_;
		fOMNFHJCDOC_ = other.fOMNFHJCDOC_;
		bFAMFABBCIO_ = other.bFAMFABBCIO_.Clone();
		bKDINONLAHD_ = other.bKDINONLAHD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AMGMAIOKJLN Clone()
	{
		return new AMGMAIOKJLN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AMGMAIOKJLN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AMGMAIOKJLN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OIAECFMLPHK != other.OIAECFMLPHK)
		{
			return false;
		}
		if (FOMNFHJCDOC != other.FOMNFHJCDOC)
		{
			return false;
		}
		if (!bFAMFABBCIO_.Equals(other.bFAMFABBCIO_))
		{
			return false;
		}
		if (BKDINONLAHD != other.BKDINONLAHD)
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
		if (OIAECFMLPHK != 0)
		{
			num ^= OIAECFMLPHK.GetHashCode();
		}
		if (FOMNFHJCDOC != 0)
		{
			num ^= FOMNFHJCDOC.GetHashCode();
		}
		num ^= bFAMFABBCIO_.GetHashCode();
		if (BKDINONLAHD)
		{
			num ^= BKDINONLAHD.GetHashCode();
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
		if (OIAECFMLPHK != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(OIAECFMLPHK);
		}
		if (FOMNFHJCDOC != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(FOMNFHJCDOC);
		}
		bFAMFABBCIO_.WriteTo(ref output, _repeated_bFAMFABBCIO_codec);
		if (BKDINONLAHD)
		{
			output.WriteRawTag(120);
			output.WriteBool(BKDINONLAHD);
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
		if (OIAECFMLPHK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OIAECFMLPHK);
		}
		if (FOMNFHJCDOC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FOMNFHJCDOC);
		}
		num += bFAMFABBCIO_.CalculateSize(_repeated_bFAMFABBCIO_codec);
		if (BKDINONLAHD)
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
	public void MergeFrom(AMGMAIOKJLN other)
	{
		if (other != null)
		{
			if (other.OIAECFMLPHK != 0)
			{
				OIAECFMLPHK = other.OIAECFMLPHK;
			}
			if (other.FOMNFHJCDOC != 0)
			{
				FOMNFHJCDOC = other.FOMNFHJCDOC;
			}
			bFAMFABBCIO_.Add(other.bFAMFABBCIO_);
			if (other.BKDINONLAHD)
			{
				BKDINONLAHD = other.BKDINONLAHD;
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
			case 40u:
				OIAECFMLPHK = input.ReadUInt32();
				break;
			case 80u:
				FOMNFHJCDOC = input.ReadUInt32();
				break;
			case 112u:
			case 114u:
				bFAMFABBCIO_.AddEntriesFrom(ref input, _repeated_bFAMFABBCIO_codec);
				break;
			case 120u:
				BKDINONLAHD = input.ReadBool();
				break;
			}
		}
	}
}
