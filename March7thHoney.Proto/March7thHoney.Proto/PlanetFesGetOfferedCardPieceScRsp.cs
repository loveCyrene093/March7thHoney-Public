using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesGetOfferedCardPieceScRsp : IMessage<PlanetFesGetOfferedCardPieceScRsp>, IMessage, IEquatable<PlanetFesGetOfferedCardPieceScRsp>, IDeepCloneable<PlanetFesGetOfferedCardPieceScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesGetOfferedCardPieceScRsp> _parser = new MessageParser<PlanetFesGetOfferedCardPieceScRsp>(() => new PlanetFesGetOfferedCardPieceScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CAOBLDAJOHKFieldNumber = 3;

	private long cAOBLDAJOHK_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int JFHMCDFDABIFieldNumber = 8;

	private bool jFHMCDFDABI_;

	public const int PHALKDHHPPBFieldNumber = 9;

	private ulong pHALKDHHPPB_;

	public const int CGOMCPEBBIAFieldNumber = 11;

	private static readonly FieldCodec<FBBMDFDOEEF> _repeated_cGOMCPEBBIA_codec = FieldCodec.ForMessage(90u, FBBMDFDOEEF.Parser);

	private readonly RepeatedField<FBBMDFDOEEF> cGOMCPEBBIA_ = new RepeatedField<FBBMDFDOEEF>();

	public const int CLFPBNGKLAAFieldNumber = 12;

	private static readonly FieldCodec<HBMNFGPKECH> _repeated_cLFPBNGKLAA_codec = FieldCodec.ForMessage(98u, HBMNFGPKECH.Parser);

	private readonly RepeatedField<HBMNFGPKECH> cLFPBNGKLAA_ = new RepeatedField<HBMNFGPKECH>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesGetOfferedCardPieceScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesGetOfferedCardPieceScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CAOBLDAJOHK
	{
		get
		{
			return cAOBLDAJOHK_;
		}
		set
		{
			cAOBLDAJOHK_ = value;
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
	public bool JFHMCDFDABI
	{
		get
		{
			return jFHMCDFDABI_;
		}
		set
		{
			jFHMCDFDABI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong PHALKDHHPPB
	{
		get
		{
			return pHALKDHHPPB_;
		}
		set
		{
			pHALKDHHPPB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FBBMDFDOEEF> CGOMCPEBBIA => cGOMCPEBBIA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HBMNFGPKECH> CLFPBNGKLAA => cLFPBNGKLAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGetOfferedCardPieceScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGetOfferedCardPieceScRsp(PlanetFesGetOfferedCardPieceScRsp other)
		: this()
	{
		cAOBLDAJOHK_ = other.cAOBLDAJOHK_;
		retcode_ = other.retcode_;
		jFHMCDFDABI_ = other.jFHMCDFDABI_;
		pHALKDHHPPB_ = other.pHALKDHHPPB_;
		cGOMCPEBBIA_ = other.cGOMCPEBBIA_.Clone();
		cLFPBNGKLAA_ = other.cLFPBNGKLAA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGetOfferedCardPieceScRsp Clone()
	{
		return new PlanetFesGetOfferedCardPieceScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesGetOfferedCardPieceScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesGetOfferedCardPieceScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CAOBLDAJOHK != other.CAOBLDAJOHK)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (JFHMCDFDABI != other.JFHMCDFDABI)
		{
			return false;
		}
		if (PHALKDHHPPB != other.PHALKDHHPPB)
		{
			return false;
		}
		if (!cGOMCPEBBIA_.Equals(other.cGOMCPEBBIA_))
		{
			return false;
		}
		if (!cLFPBNGKLAA_.Equals(other.cLFPBNGKLAA_))
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
		if (CAOBLDAJOHK != 0L)
		{
			num ^= CAOBLDAJOHK.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (JFHMCDFDABI)
		{
			num ^= JFHMCDFDABI.GetHashCode();
		}
		if (PHALKDHHPPB != 0L)
		{
			num ^= PHALKDHHPPB.GetHashCode();
		}
		num ^= cGOMCPEBBIA_.GetHashCode();
		num ^= cLFPBNGKLAA_.GetHashCode();
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
		if (CAOBLDAJOHK != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(CAOBLDAJOHK);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (JFHMCDFDABI)
		{
			output.WriteRawTag(64);
			output.WriteBool(JFHMCDFDABI);
		}
		if (PHALKDHHPPB != 0L)
		{
			output.WriteRawTag(72);
			output.WriteUInt64(PHALKDHHPPB);
		}
		cGOMCPEBBIA_.WriteTo(ref output, _repeated_cGOMCPEBBIA_codec);
		cLFPBNGKLAA_.WriteTo(ref output, _repeated_cLFPBNGKLAA_codec);
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
		if (CAOBLDAJOHK != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CAOBLDAJOHK);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (JFHMCDFDABI)
		{
			num += 2;
		}
		if (PHALKDHHPPB != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(PHALKDHHPPB);
		}
		num += cGOMCPEBBIA_.CalculateSize(_repeated_cGOMCPEBBIA_codec);
		num += cLFPBNGKLAA_.CalculateSize(_repeated_cLFPBNGKLAA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesGetOfferedCardPieceScRsp other)
	{
		if (other != null)
		{
			if (other.CAOBLDAJOHK != 0L)
			{
				CAOBLDAJOHK = other.CAOBLDAJOHK;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.JFHMCDFDABI)
			{
				JFHMCDFDABI = other.JFHMCDFDABI;
			}
			if (other.PHALKDHHPPB != 0L)
			{
				PHALKDHHPPB = other.PHALKDHHPPB;
			}
			cGOMCPEBBIA_.Add(other.cGOMCPEBBIA_);
			cLFPBNGKLAA_.Add(other.cLFPBNGKLAA_);
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
				CAOBLDAJOHK = input.ReadInt64();
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 64u:
				JFHMCDFDABI = input.ReadBool();
				break;
			case 72u:
				PHALKDHHPPB = input.ReadUInt64();
				break;
			case 90u:
				cGOMCPEBBIA_.AddEntriesFrom(ref input, _repeated_cGOMCPEBBIA_codec);
				break;
			case 98u:
				cLFPBNGKLAA_.AddEntriesFrom(ref input, _repeated_cLFPBNGKLAA_codec);
				break;
			}
		}
	}
}
