using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesDoGachaScRsp : IMessage<PlanetFesDoGachaScRsp>, IMessage, IEquatable<PlanetFesDoGachaScRsp>, IDeepCloneable<PlanetFesDoGachaScRsp>, IBufferMessage
{
	public enum FNJJNAOCOIIOneofCase
	{
		None = 0,
		MAHHENHIHDK = 1,
		BBMGOFHLEAK = 9
	}

	private static readonly MessageParser<PlanetFesDoGachaScRsp> _parser = new MessageParser<PlanetFesDoGachaScRsp>(() => new PlanetFesDoGachaScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int GachaIdFieldNumber = 11;

	private uint gachaId_;

	public const int JIGIBLLFPKFFieldNumber = 14;

	private static readonly FieldCodec<FBBMDFDOEEF> _repeated_jIGIBLLFPKF_codec = FieldCodec.ForMessage(114u, FBBMDFDOEEF.Parser);

	private readonly RepeatedField<FBBMDFDOEEF> jIGIBLLFPKF_ = new RepeatedField<FBBMDFDOEEF>();

	public const int MAHHENHIHDKFieldNumber = 1;

	public const int BBMGOFHLEAKFieldNumber = 9;

	private object fNJJNAOCOII_;

	private FNJJNAOCOIIOneofCase fNJJNAOCOIICase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesDoGachaScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesDoGachaScRspReflection.Descriptor.MessageTypes[0];

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
	public uint GachaId
	{
		get
		{
			return gachaId_;
		}
		set
		{
			gachaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FBBMDFDOEEF> JIGIBLLFPKF => jIGIBLLFPKF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFBDADKFPBF MAHHENHIHDK
	{
		get
		{
			if (fNJJNAOCOIICase_ != FNJJNAOCOIIOneofCase.MAHHENHIHDK)
			{
				return null;
			}
			return (FFBDADKFPBF)fNJJNAOCOII_;
		}
		set
		{
			fNJJNAOCOII_ = value;
			fNJJNAOCOIICase_ = ((value != null) ? FNJJNAOCOIIOneofCase.MAHHENHIHDK : FNJJNAOCOIIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EIKLOCHPNBM BBMGOFHLEAK
	{
		get
		{
			if (fNJJNAOCOIICase_ != FNJJNAOCOIIOneofCase.BBMGOFHLEAK)
			{
				return null;
			}
			return (EIKLOCHPNBM)fNJJNAOCOII_;
		}
		set
		{
			fNJJNAOCOII_ = value;
			fNJJNAOCOIICase_ = ((value != null) ? FNJJNAOCOIIOneofCase.BBMGOFHLEAK : FNJJNAOCOIIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNJJNAOCOIIOneofCase FNJJNAOCOIICase => fNJJNAOCOIICase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesDoGachaScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesDoGachaScRsp(PlanetFesDoGachaScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		gachaId_ = other.gachaId_;
		jIGIBLLFPKF_ = other.jIGIBLLFPKF_.Clone();
		switch (other.FNJJNAOCOIICase)
		{
		case FNJJNAOCOIIOneofCase.MAHHENHIHDK:
			MAHHENHIHDK = other.MAHHENHIHDK.Clone();
			break;
		case FNJJNAOCOIIOneofCase.BBMGOFHLEAK:
			BBMGOFHLEAK = other.BBMGOFHLEAK.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesDoGachaScRsp Clone()
	{
		return new PlanetFesDoGachaScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFNJJNAOCOII()
	{
		fNJJNAOCOIICase_ = FNJJNAOCOIIOneofCase.None;
		fNJJNAOCOII_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesDoGachaScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesDoGachaScRsp other)
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
		if (GachaId != other.GachaId)
		{
			return false;
		}
		if (!jIGIBLLFPKF_.Equals(other.jIGIBLLFPKF_))
		{
			return false;
		}
		if (!object.Equals(MAHHENHIHDK, other.MAHHENHIHDK))
		{
			return false;
		}
		if (!object.Equals(BBMGOFHLEAK, other.BBMGOFHLEAK))
		{
			return false;
		}
		if (FNJJNAOCOIICase != other.FNJJNAOCOIICase)
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
		if (GachaId != 0)
		{
			num ^= GachaId.GetHashCode();
		}
		num ^= jIGIBLLFPKF_.GetHashCode();
		if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.MAHHENHIHDK)
		{
			num ^= MAHHENHIHDK.GetHashCode();
		}
		if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.BBMGOFHLEAK)
		{
			num ^= BBMGOFHLEAK.GetHashCode();
		}
		num ^= (int)fNJJNAOCOIICase_;
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
		if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.MAHHENHIHDK)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MAHHENHIHDK);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.BBMGOFHLEAK)
		{
			output.WriteRawTag(74);
			output.WriteMessage(BBMGOFHLEAK);
		}
		if (GachaId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(GachaId);
		}
		jIGIBLLFPKF_.WriteTo(ref output, _repeated_jIGIBLLFPKF_codec);
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
		if (GachaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GachaId);
		}
		num += jIGIBLLFPKF_.CalculateSize(_repeated_jIGIBLLFPKF_codec);
		if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.MAHHENHIHDK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MAHHENHIHDK);
		}
		if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.BBMGOFHLEAK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BBMGOFHLEAK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesDoGachaScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.GachaId != 0)
		{
			GachaId = other.GachaId;
		}
		jIGIBLLFPKF_.Add(other.jIGIBLLFPKF_);
		switch (other.FNJJNAOCOIICase)
		{
		case FNJJNAOCOIIOneofCase.MAHHENHIHDK:
			if (MAHHENHIHDK == null)
			{
				MAHHENHIHDK = new FFBDADKFPBF();
			}
			MAHHENHIHDK.MergeFrom(other.MAHHENHIHDK);
			break;
		case FNJJNAOCOIIOneofCase.BBMGOFHLEAK:
			if (BBMGOFHLEAK == null)
			{
				BBMGOFHLEAK = new EIKLOCHPNBM();
			}
			BBMGOFHLEAK.MergeFrom(other.BBMGOFHLEAK);
			break;
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
			case 10u:
			{
				FFBDADKFPBF fFBDADKFPBF = new FFBDADKFPBF();
				if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.MAHHENHIHDK)
				{
					fFBDADKFPBF.MergeFrom(MAHHENHIHDK);
				}
				input.ReadMessage(fFBDADKFPBF);
				MAHHENHIHDK = fFBDADKFPBF;
				break;
			}
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 74u:
			{
				EIKLOCHPNBM eIKLOCHPNBM = new EIKLOCHPNBM();
				if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.BBMGOFHLEAK)
				{
					eIKLOCHPNBM.MergeFrom(BBMGOFHLEAK);
				}
				input.ReadMessage(eIKLOCHPNBM);
				BBMGOFHLEAK = eIKLOCHPNBM;
				break;
			}
			case 88u:
				GachaId = input.ReadUInt32();
				break;
			case 114u:
				jIGIBLLFPKF_.AddEntriesFrom(ref input, _repeated_jIGIBLLFPKF_codec);
				break;
			}
		}
	}
}
