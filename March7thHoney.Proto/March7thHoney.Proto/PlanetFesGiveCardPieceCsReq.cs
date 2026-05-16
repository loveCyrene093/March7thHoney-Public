using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesGiveCardPieceCsReq : IMessage<PlanetFesGiveCardPieceCsReq>, IMessage, IEquatable<PlanetFesGiveCardPieceCsReq>, IDeepCloneable<PlanetFesGiveCardPieceCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesGiveCardPieceCsReq> _parser = new MessageParser<PlanetFesGiveCardPieceCsReq>(() => new PlanetFesGiveCardPieceCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MGAFDDCGJPMFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_mGAFDDCGJPM_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> mGAFDDCGJPM_ = new RepeatedField<uint>();

	public const int TeleportIdFieldNumber = 15;

	private uint teleportId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesGiveCardPieceCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesGiveCardPieceCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public PlanetFesGiveCardPieceCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGiveCardPieceCsReq(PlanetFesGiveCardPieceCsReq other)
		: this()
	{
		mGAFDDCGJPM_ = other.mGAFDDCGJPM_.Clone();
		teleportId_ = other.teleportId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGiveCardPieceCsReq Clone()
	{
		return new PlanetFesGiveCardPieceCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesGiveCardPieceCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesGiveCardPieceCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mGAFDDCGJPM_.Equals(other.mGAFDDCGJPM_))
		{
			return false;
		}
		if (TeleportId != other.TeleportId)
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
		num ^= mGAFDDCGJPM_.GetHashCode();
		if (TeleportId != 0)
		{
			num ^= TeleportId.GetHashCode();
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
		mGAFDDCGJPM_.WriteTo(ref output, _repeated_mGAFDDCGJPM_codec);
		if (TeleportId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(TeleportId);
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
		num += mGAFDDCGJPM_.CalculateSize(_repeated_mGAFDDCGJPM_codec);
		if (TeleportId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TeleportId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesGiveCardPieceCsReq other)
	{
		if (other != null)
		{
			mGAFDDCGJPM_.Add(other.mGAFDDCGJPM_);
			if (other.TeleportId != 0)
			{
				TeleportId = other.TeleportId;
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
			case 10u:
				mGAFDDCGJPM_.AddEntriesFrom(ref input, _repeated_mGAFDDCGJPM_codec);
				break;
			case 120u:
				TeleportId = input.ReadUInt32();
				break;
			}
		}
	}
}
