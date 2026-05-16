using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PKAFDHFOMOL : IMessage<PKAFDHFOMOL>, IMessage, IEquatable<PKAFDHFOMOL>, IDeepCloneable<PKAFDHFOMOL>, IBufferMessage
{
	private static readonly MessageParser<PKAFDHFOMOL> _parser = new MessageParser<PKAFDHFOMOL>(() => new PKAFDHFOMOL());

	private UnknownFieldSet _unknownFields;

	public const int HGPGDCOCDFKFieldNumber = 2;

	private DLCCOJPHBCB hGPGDCOCDFK_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int BIEBFHECEPMFieldNumber = 11;

	private static readonly FieldCodec<ADHNJADIJAC> _repeated_bIEBFHECEPM_codec = FieldCodec.ForMessage(90u, ADHNJADIJAC.Parser);

	private readonly RepeatedField<ADHNJADIJAC> bIEBFHECEPM_ = new RepeatedField<ADHNJADIJAC>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PKAFDHFOMOL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PKAFDHFOMOLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLCCOJPHBCB HGPGDCOCDFK
	{
		get
		{
			return hGPGDCOCDFK_;
		}
		set
		{
			hGPGDCOCDFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ADHNJADIJAC> BIEBFHECEPM => bIEBFHECEPM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKAFDHFOMOL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKAFDHFOMOL(PKAFDHFOMOL other)
		: this()
	{
		hGPGDCOCDFK_ = ((other.hGPGDCOCDFK_ != null) ? other.hGPGDCOCDFK_.Clone() : null);
		retcode_ = other.retcode_;
		bIEBFHECEPM_ = other.bIEBFHECEPM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKAFDHFOMOL Clone()
	{
		return new PKAFDHFOMOL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PKAFDHFOMOL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PKAFDHFOMOL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(HGPGDCOCDFK, other.HGPGDCOCDFK))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!bIEBFHECEPM_.Equals(other.bIEBFHECEPM_))
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
		if (hGPGDCOCDFK_ != null)
		{
			num ^= HGPGDCOCDFK.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= bIEBFHECEPM_.GetHashCode();
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
		if (hGPGDCOCDFK_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(HGPGDCOCDFK);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		bIEBFHECEPM_.WriteTo(ref output, _repeated_bIEBFHECEPM_codec);
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
		if (hGPGDCOCDFK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HGPGDCOCDFK);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += bIEBFHECEPM_.CalculateSize(_repeated_bIEBFHECEPM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PKAFDHFOMOL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.hGPGDCOCDFK_ != null)
		{
			if (hGPGDCOCDFK_ == null)
			{
				HGPGDCOCDFK = new DLCCOJPHBCB();
			}
			HGPGDCOCDFK.MergeFrom(other.HGPGDCOCDFK);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		bIEBFHECEPM_.Add(other.bIEBFHECEPM_);
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
			case 18u:
				if (hGPGDCOCDFK_ == null)
				{
					HGPGDCOCDFK = new DLCCOJPHBCB();
				}
				input.ReadMessage(HGPGDCOCDFK);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 90u:
				bIEBFHECEPM_.AddEntriesFrom(ref input, _repeated_bIEBFHECEPM_codec);
				break;
			}
		}
	}
}
