using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ParkourGetRankingInfoScRsp : IMessage<ParkourGetRankingInfoScRsp>, IMessage, IEquatable<ParkourGetRankingInfoScRsp>, IDeepCloneable<ParkourGetRankingInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<ParkourGetRankingInfoScRsp> _parser = new MessageParser<ParkourGetRankingInfoScRsp>(() => new ParkourGetRankingInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int DEHBAPFMBMBFieldNumber = 2;

	private static readonly FieldCodec<AFDBEFKBBFM> _repeated_dEHBAPFMBMB_codec = FieldCodec.ForMessage(18u, AFDBEFKBBFM.Parser);

	private readonly RepeatedField<AFDBEFKBBFM> dEHBAPFMBMB_ = new RepeatedField<AFDBEFKBBFM>();

	public const int IMDCEFEGIPBFieldNumber = 4;

	private AFDBEFKBBFM iMDCEFEGIPB_;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ParkourGetRankingInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ParkourGetRankingInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AFDBEFKBBFM> DEHBAPFMBMB => dEHBAPFMBMB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFDBEFKBBFM IMDCEFEGIPB
	{
		get
		{
			return iMDCEFEGIPB_;
		}
		set
		{
			iMDCEFEGIPB_ = value;
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
	public ParkourGetRankingInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ParkourGetRankingInfoScRsp(ParkourGetRankingInfoScRsp other)
		: this()
	{
		dEHBAPFMBMB_ = other.dEHBAPFMBMB_.Clone();
		iMDCEFEGIPB_ = ((other.iMDCEFEGIPB_ != null) ? other.iMDCEFEGIPB_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ParkourGetRankingInfoScRsp Clone()
	{
		return new ParkourGetRankingInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ParkourGetRankingInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ParkourGetRankingInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dEHBAPFMBMB_.Equals(other.dEHBAPFMBMB_))
		{
			return false;
		}
		if (!object.Equals(IMDCEFEGIPB, other.IMDCEFEGIPB))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= dEHBAPFMBMB_.GetHashCode();
		if (iMDCEFEGIPB_ != null)
		{
			num ^= IMDCEFEGIPB.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		dEHBAPFMBMB_.WriteTo(ref output, _repeated_dEHBAPFMBMB_codec);
		if (iMDCEFEGIPB_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(IMDCEFEGIPB);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
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
		num += dEHBAPFMBMB_.CalculateSize(_repeated_dEHBAPFMBMB_codec);
		if (iMDCEFEGIPB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMDCEFEGIPB);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ParkourGetRankingInfoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		dEHBAPFMBMB_.Add(other.dEHBAPFMBMB_);
		if (other.iMDCEFEGIPB_ != null)
		{
			if (iMDCEFEGIPB_ == null)
			{
				IMDCEFEGIPB = new AFDBEFKBBFM();
			}
			IMDCEFEGIPB.MergeFrom(other.IMDCEFEGIPB);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
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
				dEHBAPFMBMB_.AddEntriesFrom(ref input, _repeated_dEHBAPFMBMB_codec);
				break;
			case 34u:
				if (iMDCEFEGIPB_ == null)
				{
					IMDCEFEGIPB = new AFDBEFKBBFM();
				}
				input.ReadMessage(IMDCEFEGIPB);
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
