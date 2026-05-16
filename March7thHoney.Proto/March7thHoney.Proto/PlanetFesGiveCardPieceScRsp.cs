using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesGiveCardPieceScRsp : IMessage<PlanetFesGiveCardPieceScRsp>, IMessage, IEquatable<PlanetFesGiveCardPieceScRsp>, IDeepCloneable<PlanetFesGiveCardPieceScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesGiveCardPieceScRsp> _parser = new MessageParser<PlanetFesGiveCardPieceScRsp>(() => new PlanetFesGiveCardPieceScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ONBBNACBADFFieldNumber = 1;

	private long oNBBNACBADF_;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int MGAFDDCGJPMFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_mGAFDDCGJPM_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> mGAFDDCGJPM_ = new RepeatedField<uint>();

	public const int TeleportIdFieldNumber = 6;

	private uint teleportId_;

	public const int PHALKDHHPPBFieldNumber = 14;

	private ulong pHALKDHHPPB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesGiveCardPieceScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesGiveCardPieceScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ONBBNACBADF
	{
		get
		{
			return oNBBNACBADF_;
		}
		set
		{
			oNBBNACBADF_ = value;
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
	public RepeatedField<uint> MGAFDDCGJPM => mGAFDDCGJPM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TeleportId
	{
		get
		{
			return teleportId_;
		}
		set
		{
			teleportId_ = value;
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
	public PlanetFesGiveCardPieceScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGiveCardPieceScRsp(PlanetFesGiveCardPieceScRsp other)
		: this()
	{
		oNBBNACBADF_ = other.oNBBNACBADF_;
		retcode_ = other.retcode_;
		mGAFDDCGJPM_ = other.mGAFDDCGJPM_.Clone();
		teleportId_ = other.teleportId_;
		pHALKDHHPPB_ = other.pHALKDHHPPB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGiveCardPieceScRsp Clone()
	{
		return new PlanetFesGiveCardPieceScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesGiveCardPieceScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesGiveCardPieceScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ONBBNACBADF != other.ONBBNACBADF)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!mGAFDDCGJPM_.Equals(other.mGAFDDCGJPM_))
		{
			return false;
		}
		if (TeleportId != other.TeleportId)
		{
			return false;
		}
		if (PHALKDHHPPB != other.PHALKDHHPPB)
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
		if (ONBBNACBADF != 0L)
		{
			num ^= ONBBNACBADF.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= mGAFDDCGJPM_.GetHashCode();
		if (TeleportId != 0)
		{
			num ^= TeleportId.GetHashCode();
		}
		if (PHALKDHHPPB != 0L)
		{
			num ^= PHALKDHHPPB.GetHashCode();
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
		if (ONBBNACBADF != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(ONBBNACBADF);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		mGAFDDCGJPM_.WriteTo(ref output, _repeated_mGAFDDCGJPM_codec);
		if (TeleportId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(TeleportId);
		}
		if (PHALKDHHPPB != 0L)
		{
			output.WriteRawTag(112);
			output.WriteUInt64(PHALKDHHPPB);
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
		if (ONBBNACBADF != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(ONBBNACBADF);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += mGAFDDCGJPM_.CalculateSize(_repeated_mGAFDDCGJPM_codec);
		if (TeleportId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TeleportId);
		}
		if (PHALKDHHPPB != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(PHALKDHHPPB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesGiveCardPieceScRsp other)
	{
		if (other != null)
		{
			if (other.ONBBNACBADF != 0L)
			{
				ONBBNACBADF = other.ONBBNACBADF;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			mGAFDDCGJPM_.Add(other.mGAFDDCGJPM_);
			if (other.TeleportId != 0)
			{
				TeleportId = other.TeleportId;
			}
			if (other.PHALKDHHPPB != 0L)
			{
				PHALKDHHPPB = other.PHALKDHHPPB;
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
				ONBBNACBADF = input.ReadInt64();
				break;
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 40u:
			case 42u:
				mGAFDDCGJPM_.AddEntriesFrom(ref input, _repeated_mGAFDDCGJPM_codec);
				break;
			case 48u:
				TeleportId = input.ReadUInt32();
				break;
			case 112u:
				PHALKDHHPPB = input.ReadUInt64();
				break;
			}
		}
	}
}
