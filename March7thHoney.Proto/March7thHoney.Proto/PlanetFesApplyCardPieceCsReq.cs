using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesApplyCardPieceCsReq : IMessage<PlanetFesApplyCardPieceCsReq>, IMessage, IEquatable<PlanetFesApplyCardPieceCsReq>, IDeepCloneable<PlanetFesApplyCardPieceCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesApplyCardPieceCsReq> _parser = new MessageParser<PlanetFesApplyCardPieceCsReq>(() => new PlanetFesApplyCardPieceCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DJDEBKPGJDNFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_dJDEBKPGJDN_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> dJDEBKPGJDN_ = new RepeatedField<uint>();

	public const int TeleportIdFieldNumber = 9;

	private uint teleportId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesApplyCardPieceCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesApplyCardPieceCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DJDEBKPGJDN => dJDEBKPGJDN_;

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
	public PlanetFesApplyCardPieceCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesApplyCardPieceCsReq(PlanetFesApplyCardPieceCsReq other)
		: this()
	{
		dJDEBKPGJDN_ = other.dJDEBKPGJDN_.Clone();
		teleportId_ = other.teleportId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesApplyCardPieceCsReq Clone()
	{
		return new PlanetFesApplyCardPieceCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesApplyCardPieceCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesApplyCardPieceCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dJDEBKPGJDN_.Equals(other.dJDEBKPGJDN_))
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
		num ^= dJDEBKPGJDN_.GetHashCode();
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
		dJDEBKPGJDN_.WriteTo(ref output, _repeated_dJDEBKPGJDN_codec);
		if (TeleportId != 0)
		{
			output.WriteRawTag(72);
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
		num += dJDEBKPGJDN_.CalculateSize(_repeated_dJDEBKPGJDN_codec);
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
	public void MergeFrom(PlanetFesApplyCardPieceCsReq other)
	{
		if (other != null)
		{
			dJDEBKPGJDN_.Add(other.dJDEBKPGJDN_);
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
			case 24u:
			case 26u:
				dJDEBKPGJDN_.AddEntriesFrom(ref input, _repeated_dJDEBKPGJDN_codec);
				break;
			case 72u:
				TeleportId = input.ReadUInt32();
				break;
			}
		}
	}
}
