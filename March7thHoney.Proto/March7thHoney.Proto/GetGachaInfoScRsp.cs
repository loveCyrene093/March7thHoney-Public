using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetGachaInfoScRsp : IMessage<GetGachaInfoScRsp>, IMessage, IEquatable<GetGachaInfoScRsp>, IDeepCloneable<GetGachaInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetGachaInfoScRsp> _parser = new MessageParser<GetGachaInfoScRsp>(() => new GetGachaInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int EHKFPMJCEMIFieldNumber = 2;

	private uint eHKFPMJCEMI_;

	public const int GachaInfoListFieldNumber = 3;

	private static readonly FieldCodec<GachaInfo> _repeated_gachaInfoList_codec = FieldCodec.ForMessage(26u, GachaInfo.Parser);

	private readonly RepeatedField<GachaInfo> gachaInfoList_ = new RepeatedField<GachaInfo>();

	public const int GachaRandomFieldNumber = 6;

	private uint gachaRandom_;

	public const int GLDPKKHODLJFieldNumber = 11;

	private uint gLDPKKHODLJ_;

	public const int NMBAAOBBJMIFieldNumber = 12;

	private static readonly FieldCodec<OEIEJHBCOOM> _repeated_nMBAAOBBJMI_codec = FieldCodec.ForMessage(98u, OEIEJHBCOOM.Parser);

	private readonly RepeatedField<OEIEJHBCOOM> nMBAAOBBJMI_ = new RepeatedField<OEIEJHBCOOM>();

	public const int CELFCELFMJDFieldNumber = 15;

	private uint cELFCELFMJD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetGachaInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetGachaInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint EHKFPMJCEMI
	{
		get
		{
			return eHKFPMJCEMI_;
		}
		set
		{
			eHKFPMJCEMI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GachaInfo> GachaInfoList => gachaInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GachaRandom
	{
		get
		{
			return gachaRandom_;
		}
		set
		{
			gachaRandom_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GLDPKKHODLJ
	{
		get
		{
			return gLDPKKHODLJ_;
		}
		set
		{
			gLDPKKHODLJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OEIEJHBCOOM> NMBAAOBBJMI => nMBAAOBBJMI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CELFCELFMJD
	{
		get
		{
			return cELFCELFMJD_;
		}
		set
		{
			cELFCELFMJD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetGachaInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetGachaInfoScRsp(GetGachaInfoScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		eHKFPMJCEMI_ = other.eHKFPMJCEMI_;
		gachaInfoList_ = other.gachaInfoList_.Clone();
		gachaRandom_ = other.gachaRandom_;
		gLDPKKHODLJ_ = other.gLDPKKHODLJ_;
		nMBAAOBBJMI_ = other.nMBAAOBBJMI_.Clone();
		cELFCELFMJD_ = other.cELFCELFMJD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetGachaInfoScRsp Clone()
	{
		return new GetGachaInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetGachaInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetGachaInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (EHKFPMJCEMI != other.EHKFPMJCEMI)
		{
			return false;
		}
		if (!gachaInfoList_.Equals(other.gachaInfoList_))
		{
			return false;
		}
		if (GachaRandom != other.GachaRandom)
		{
			return false;
		}
		if (GLDPKKHODLJ != other.GLDPKKHODLJ)
		{
			return false;
		}
		if (!nMBAAOBBJMI_.Equals(other.nMBAAOBBJMI_))
		{
			return false;
		}
		if (CELFCELFMJD != other.CELFCELFMJD)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (EHKFPMJCEMI != 0)
		{
			num ^= EHKFPMJCEMI.GetHashCode();
		}
		num ^= gachaInfoList_.GetHashCode();
		if (GachaRandom != 0)
		{
			num ^= GachaRandom.GetHashCode();
		}
		if (GLDPKKHODLJ != 0)
		{
			num ^= GLDPKKHODLJ.GetHashCode();
		}
		num ^= nMBAAOBBJMI_.GetHashCode();
		if (CELFCELFMJD != 0)
		{
			num ^= CELFCELFMJD.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (EHKFPMJCEMI != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(EHKFPMJCEMI);
		}
		gachaInfoList_.WriteTo(ref output, _repeated_gachaInfoList_codec);
		if (GachaRandom != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(GachaRandom);
		}
		if (GLDPKKHODLJ != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(GLDPKKHODLJ);
		}
		nMBAAOBBJMI_.WriteTo(ref output, _repeated_nMBAAOBBJMI_codec);
		if (CELFCELFMJD != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(CELFCELFMJD);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (EHKFPMJCEMI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EHKFPMJCEMI);
		}
		num += gachaInfoList_.CalculateSize(_repeated_gachaInfoList_codec);
		if (GachaRandom != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GachaRandom);
		}
		if (GLDPKKHODLJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GLDPKKHODLJ);
		}
		num += nMBAAOBBJMI_.CalculateSize(_repeated_nMBAAOBBJMI_codec);
		if (CELFCELFMJD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CELFCELFMJD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetGachaInfoScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.EHKFPMJCEMI != 0)
			{
				EHKFPMJCEMI = other.EHKFPMJCEMI;
			}
			gachaInfoList_.Add(other.gachaInfoList_);
			if (other.GachaRandom != 0)
			{
				GachaRandom = other.GachaRandom;
			}
			if (other.GLDPKKHODLJ != 0)
			{
				GLDPKKHODLJ = other.GLDPKKHODLJ;
			}
			nMBAAOBBJMI_.Add(other.nMBAAOBBJMI_);
			if (other.CELFCELFMJD != 0)
			{
				CELFCELFMJD = other.CELFCELFMJD;
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
			case 8u:
				Retcode = input.ReadUInt32();
				break;
			case 16u:
				EHKFPMJCEMI = input.ReadUInt32();
				break;
			case 26u:
				gachaInfoList_.AddEntriesFrom(ref input, _repeated_gachaInfoList_codec);
				break;
			case 48u:
				GachaRandom = input.ReadUInt32();
				break;
			case 88u:
				GLDPKKHODLJ = input.ReadUInt32();
				break;
			case 98u:
				nMBAAOBBJMI_.AddEntriesFrom(ref input, _repeated_nMBAAOBBJMI_codec);
				break;
			case 120u:
				CELFCELFMJD = input.ReadUInt32();
				break;
			}
		}
	}
}
