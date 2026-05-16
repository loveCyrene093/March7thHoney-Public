using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LobbyGetInfoScRsp : IMessage<LobbyGetInfoScRsp>, IMessage, IEquatable<LobbyGetInfoScRsp>, IDeepCloneable<LobbyGetInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<LobbyGetInfoScRsp> _parser = new MessageParser<LobbyGetInfoScRsp>(() => new LobbyGetInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RoomIdFieldNumber = 2;

	private ulong roomId_;

	public const int CHEODMKAHJMFieldNumber = 6;

	private uint cHEODMKAHJM_;

	public const int BIEBFHECEPMFieldNumber = 8;

	private static readonly FieldCodec<ADHNJADIJAC> _repeated_bIEBFHECEPM_codec = FieldCodec.ForMessage(66u, ADHNJADIJAC.Parser);

	private readonly RepeatedField<ADHNJADIJAC> bIEBFHECEPM_ = new RepeatedField<ADHNJADIJAC>();

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int POFOCMIHJIAFieldNumber = 11;

	private PBICJCPDLGD pOFOCMIHJIA_;

	public const int EIFFDNNBGMCFieldNumber = 13;

	private ulong eIFFDNNBGMC_;

	public const int PLOBMBFPNFKFieldNumber = 14;

	private FightGameMode pLOBMBFPNFK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LobbyGetInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LobbyGetInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong RoomId
	{
		get
		{
			return roomId_;
		}
		set
		{
			roomId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CHEODMKAHJM
	{
		get
		{
			return cHEODMKAHJM_;
		}
		set
		{
			cHEODMKAHJM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ADHNJADIJAC> BIEBFHECEPM => bIEBFHECEPM_;

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
	public PBICJCPDLGD POFOCMIHJIA
	{
		get
		{
			return pOFOCMIHJIA_;
		}
		set
		{
			pOFOCMIHJIA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong EIFFDNNBGMC
	{
		get
		{
			return eIFFDNNBGMC_;
		}
		set
		{
			eIFFDNNBGMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightGameMode PLOBMBFPNFK
	{
		get
		{
			return pLOBMBFPNFK_;
		}
		set
		{
			pLOBMBFPNFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyGetInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyGetInfoScRsp(LobbyGetInfoScRsp other)
		: this()
	{
		roomId_ = other.roomId_;
		cHEODMKAHJM_ = other.cHEODMKAHJM_;
		bIEBFHECEPM_ = other.bIEBFHECEPM_.Clone();
		retcode_ = other.retcode_;
		pOFOCMIHJIA_ = ((other.pOFOCMIHJIA_ != null) ? other.pOFOCMIHJIA_.Clone() : null);
		eIFFDNNBGMC_ = other.eIFFDNNBGMC_;
		pLOBMBFPNFK_ = other.pLOBMBFPNFK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyGetInfoScRsp Clone()
	{
		return new LobbyGetInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LobbyGetInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LobbyGetInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoomId != other.RoomId)
		{
			return false;
		}
		if (CHEODMKAHJM != other.CHEODMKAHJM)
		{
			return false;
		}
		if (!bIEBFHECEPM_.Equals(other.bIEBFHECEPM_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(POFOCMIHJIA, other.POFOCMIHJIA))
		{
			return false;
		}
		if (EIFFDNNBGMC != other.EIFFDNNBGMC)
		{
			return false;
		}
		if (PLOBMBFPNFK != other.PLOBMBFPNFK)
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
		if (RoomId != 0L)
		{
			num ^= RoomId.GetHashCode();
		}
		if (CHEODMKAHJM != 0)
		{
			num ^= CHEODMKAHJM.GetHashCode();
		}
		num ^= bIEBFHECEPM_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (pOFOCMIHJIA_ != null)
		{
			num ^= POFOCMIHJIA.GetHashCode();
		}
		if (EIFFDNNBGMC != 0L)
		{
			num ^= EIFFDNNBGMC.GetHashCode();
		}
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num ^= PLOBMBFPNFK.GetHashCode();
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
		if (RoomId != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(RoomId);
		}
		if (CHEODMKAHJM != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(CHEODMKAHJM);
		}
		bIEBFHECEPM_.WriteTo(ref output, _repeated_bIEBFHECEPM_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		if (pOFOCMIHJIA_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(POFOCMIHJIA);
		}
		if (EIFFDNNBGMC != 0L)
		{
			output.WriteRawTag(104);
			output.WriteUInt64(EIFFDNNBGMC);
		}
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)PLOBMBFPNFK);
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
		if (RoomId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoomId);
		}
		if (CHEODMKAHJM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CHEODMKAHJM);
		}
		num += bIEBFHECEPM_.CalculateSize(_repeated_bIEBFHECEPM_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (pOFOCMIHJIA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(POFOCMIHJIA);
		}
		if (EIFFDNNBGMC != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(EIFFDNNBGMC);
		}
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PLOBMBFPNFK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LobbyGetInfoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RoomId != 0L)
		{
			RoomId = other.RoomId;
		}
		if (other.CHEODMKAHJM != 0)
		{
			CHEODMKAHJM = other.CHEODMKAHJM;
		}
		bIEBFHECEPM_.Add(other.bIEBFHECEPM_);
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.pOFOCMIHJIA_ != null)
		{
			if (pOFOCMIHJIA_ == null)
			{
				POFOCMIHJIA = new PBICJCPDLGD();
			}
			POFOCMIHJIA.MergeFrom(other.POFOCMIHJIA);
		}
		if (other.EIFFDNNBGMC != 0L)
		{
			EIFFDNNBGMC = other.EIFFDNNBGMC;
		}
		if (other.PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			PLOBMBFPNFK = other.PLOBMBFPNFK;
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
			case 16u:
				RoomId = input.ReadUInt64();
				break;
			case 48u:
				CHEODMKAHJM = input.ReadUInt32();
				break;
			case 66u:
				bIEBFHECEPM_.AddEntriesFrom(ref input, _repeated_bIEBFHECEPM_codec);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 90u:
				if (pOFOCMIHJIA_ == null)
				{
					POFOCMIHJIA = new PBICJCPDLGD();
				}
				input.ReadMessage(POFOCMIHJIA);
				break;
			case 104u:
				EIFFDNNBGMC = input.ReadUInt64();
				break;
			case 112u:
				PLOBMBFPNFK = (FightGameMode)input.ReadEnum();
				break;
			}
		}
	}
}
