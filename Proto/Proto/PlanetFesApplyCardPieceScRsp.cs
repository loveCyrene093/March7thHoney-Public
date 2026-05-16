using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesApplyCardPieceScRsp : IMessage<PlanetFesApplyCardPieceScRsp>, IMessage, IEquatable<PlanetFesApplyCardPieceScRsp>, IDeepCloneable<PlanetFesApplyCardPieceScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesApplyCardPieceScRsp> _parser = new MessageParser<PlanetFesApplyCardPieceScRsp>(() => new PlanetFesApplyCardPieceScRsp());

	private UnknownFieldSet _unknownFields;

	public const int EPGIKGCADHMFieldNumber = 1;

	private uint ePGIKGCADHM_;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int CHEHAODHAOCFieldNumber = 5;

	private bool cHEHAODHAOC_;

	public const int DJDEBKPGJDNFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_dJDEBKPGJDN_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> dJDEBKPGJDN_ = new RepeatedField<uint>();

	public const int TeleportIdFieldNumber = 11;

	private uint teleportId_;

	public const int ALJIBCCDHPJFieldNumber = 13;

	private long aLJIBCCDHPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesApplyCardPieceScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesApplyCardPieceScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EPGIKGCADHM
	{
		get
		{
			return ePGIKGCADHM_;
		}
		set
		{
			ePGIKGCADHM_ = value;
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
	public bool CHEHAODHAOC
	{
		get
		{
			return cHEHAODHAOC_;
		}
		set
		{
			cHEHAODHAOC_ = value;
		}
	}

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
	public long ALJIBCCDHPJ
	{
		get
		{
			return aLJIBCCDHPJ_;
		}
		set
		{
			aLJIBCCDHPJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesApplyCardPieceScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesApplyCardPieceScRsp(PlanetFesApplyCardPieceScRsp other)
		: this()
	{
		ePGIKGCADHM_ = other.ePGIKGCADHM_;
		retcode_ = other.retcode_;
		cHEHAODHAOC_ = other.cHEHAODHAOC_;
		dJDEBKPGJDN_ = other.dJDEBKPGJDN_.Clone();
		teleportId_ = other.teleportId_;
		aLJIBCCDHPJ_ = other.aLJIBCCDHPJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesApplyCardPieceScRsp Clone()
	{
		return new PlanetFesApplyCardPieceScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesApplyCardPieceScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesApplyCardPieceScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EPGIKGCADHM != other.EPGIKGCADHM)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (CHEHAODHAOC != other.CHEHAODHAOC)
		{
			return false;
		}
		if (!dJDEBKPGJDN_.Equals(other.dJDEBKPGJDN_))
		{
			return false;
		}
		if (TeleportId != other.TeleportId)
		{
			return false;
		}
		if (ALJIBCCDHPJ != other.ALJIBCCDHPJ)
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
		if (EPGIKGCADHM != 0)
		{
			num ^= EPGIKGCADHM.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (CHEHAODHAOC)
		{
			num ^= CHEHAODHAOC.GetHashCode();
		}
		num ^= dJDEBKPGJDN_.GetHashCode();
		if (TeleportId != 0)
		{
			num ^= TeleportId.GetHashCode();
		}
		if (ALJIBCCDHPJ != 0L)
		{
			num ^= ALJIBCCDHPJ.GetHashCode();
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
		if (EPGIKGCADHM != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(EPGIKGCADHM);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		if (CHEHAODHAOC)
		{
			output.WriteRawTag(40);
			output.WriteBool(CHEHAODHAOC);
		}
		dJDEBKPGJDN_.WriteTo(ref output, _repeated_dJDEBKPGJDN_codec);
		if (TeleportId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(TeleportId);
		}
		if (ALJIBCCDHPJ != 0L)
		{
			output.WriteRawTag(104);
			output.WriteInt64(ALJIBCCDHPJ);
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
		if (EPGIKGCADHM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EPGIKGCADHM);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (CHEHAODHAOC)
		{
			num += 2;
		}
		num += dJDEBKPGJDN_.CalculateSize(_repeated_dJDEBKPGJDN_codec);
		if (TeleportId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TeleportId);
		}
		if (ALJIBCCDHPJ != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(ALJIBCCDHPJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesApplyCardPieceScRsp other)
	{
		if (other != null)
		{
			if (other.EPGIKGCADHM != 0)
			{
				EPGIKGCADHM = other.EPGIKGCADHM;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.CHEHAODHAOC)
			{
				CHEHAODHAOC = other.CHEHAODHAOC;
			}
			dJDEBKPGJDN_.Add(other.dJDEBKPGJDN_);
			if (other.TeleportId != 0)
			{
				TeleportId = other.TeleportId;
			}
			if (other.ALJIBCCDHPJ != 0L)
			{
				ALJIBCCDHPJ = other.ALJIBCCDHPJ;
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
				EPGIKGCADHM = input.ReadUInt32();
				break;
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 40u:
				CHEHAODHAOC = input.ReadBool();
				break;
			case 72u:
			case 74u:
				dJDEBKPGJDN_.AddEntriesFrom(ref input, _repeated_dJDEBKPGJDN_codec);
				break;
			case 88u:
				TeleportId = input.ReadUInt32();
				break;
			case 104u:
				ALJIBCCDHPJ = input.ReadInt64();
				break;
			}
		}
	}
}
