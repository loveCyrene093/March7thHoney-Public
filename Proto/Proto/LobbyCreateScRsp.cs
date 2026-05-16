using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LobbyCreateScRsp : IMessage<LobbyCreateScRsp>, IMessage, IEquatable<LobbyCreateScRsp>, IDeepCloneable<LobbyCreateScRsp>, IBufferMessage
{
	private static readonly MessageParser<LobbyCreateScRsp> _parser = new MessageParser<LobbyCreateScRsp>(() => new LobbyCreateScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CHEODMKAHJMFieldNumber = 1;

	private uint cHEODMKAHJM_;

	public const int POFOCMIHJIAFieldNumber = 5;

	private PBICJCPDLGD pOFOCMIHJIA_;

	public const int PLOBMBFPNFKFieldNumber = 6;

	private FightGameMode pLOBMBFPNFK_;

	public const int RoomIdFieldNumber = 7;

	private ulong roomId_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int BIEBFHECEPMFieldNumber = 14;

	private static readonly FieldCodec<ADHNJADIJAC> _repeated_bIEBFHECEPM_codec = FieldCodec.ForMessage(114u, ADHNJADIJAC.Parser);

	private readonly RepeatedField<ADHNJADIJAC> bIEBFHECEPM_ = new RepeatedField<ADHNJADIJAC>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LobbyCreateScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LobbyCreateScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public LobbyCreateScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyCreateScRsp(LobbyCreateScRsp other)
		: this()
	{
		cHEODMKAHJM_ = other.cHEODMKAHJM_;
		pOFOCMIHJIA_ = ((other.pOFOCMIHJIA_ != null) ? other.pOFOCMIHJIA_.Clone() : null);
		pLOBMBFPNFK_ = other.pLOBMBFPNFK_;
		roomId_ = other.roomId_;
		retcode_ = other.retcode_;
		bIEBFHECEPM_ = other.bIEBFHECEPM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyCreateScRsp Clone()
	{
		return new LobbyCreateScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LobbyCreateScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LobbyCreateScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CHEODMKAHJM != other.CHEODMKAHJM)
		{
			return false;
		}
		if (!object.Equals(POFOCMIHJIA, other.POFOCMIHJIA))
		{
			return false;
		}
		if (PLOBMBFPNFK != other.PLOBMBFPNFK)
		{
			return false;
		}
		if (RoomId != other.RoomId)
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
		if (CHEODMKAHJM != 0)
		{
			num ^= CHEODMKAHJM.GetHashCode();
		}
		if (pOFOCMIHJIA_ != null)
		{
			num ^= POFOCMIHJIA.GetHashCode();
		}
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num ^= PLOBMBFPNFK.GetHashCode();
		}
		if (RoomId != 0L)
		{
			num ^= RoomId.GetHashCode();
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
		if (CHEODMKAHJM != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CHEODMKAHJM);
		}
		if (pOFOCMIHJIA_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(POFOCMIHJIA);
		}
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)PLOBMBFPNFK);
		}
		if (RoomId != 0L)
		{
			output.WriteRawTag(56);
			output.WriteUInt64(RoomId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
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
		if (CHEODMKAHJM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CHEODMKAHJM);
		}
		if (pOFOCMIHJIA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(POFOCMIHJIA);
		}
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PLOBMBFPNFK);
		}
		if (RoomId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoomId);
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
	public void MergeFrom(LobbyCreateScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.CHEODMKAHJM != 0)
		{
			CHEODMKAHJM = other.CHEODMKAHJM;
		}
		if (other.pOFOCMIHJIA_ != null)
		{
			if (pOFOCMIHJIA_ == null)
			{
				POFOCMIHJIA = new PBICJCPDLGD();
			}
			POFOCMIHJIA.MergeFrom(other.POFOCMIHJIA);
		}
		if (other.PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			PLOBMBFPNFK = other.PLOBMBFPNFK;
		}
		if (other.RoomId != 0L)
		{
			RoomId = other.RoomId;
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
			case 8u:
				CHEODMKAHJM = input.ReadUInt32();
				break;
			case 42u:
				if (pOFOCMIHJIA_ == null)
				{
					POFOCMIHJIA = new PBICJCPDLGD();
				}
				input.ReadMessage(POFOCMIHJIA);
				break;
			case 48u:
				PLOBMBFPNFK = (FightGameMode)input.ReadEnum();
				break;
			case 56u:
				RoomId = input.ReadUInt64();
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 114u:
				bIEBFHECEPM_.AddEntriesFrom(ref input, _repeated_bIEBFHECEPM_codec);
				break;
			}
		}
	}
}
