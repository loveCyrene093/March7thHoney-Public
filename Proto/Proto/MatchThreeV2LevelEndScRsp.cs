using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MatchThreeV2LevelEndScRsp : IMessage<MatchThreeV2LevelEndScRsp>, IMessage, IEquatable<MatchThreeV2LevelEndScRsp>, IDeepCloneable<MatchThreeV2LevelEndScRsp>, IBufferMessage
{
	private static readonly MessageParser<MatchThreeV2LevelEndScRsp> _parser = new MessageParser<MatchThreeV2LevelEndScRsp>(() => new MatchThreeV2LevelEndScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MODDIBHCPPDFieldNumber = 1;

	private BEOPDMLKGLP mODDIBHCPPD_;

	public const int LAEJLLCGFDMFieldNumber = 2;

	private ItemList lAEJLLCGFDM_;

	public const int AMGMADNBFIFFieldNumber = 7;

	private uint aMGMADNBFIF_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int LevelIdFieldNumber = 9;

	private uint levelId_;

	public const int HNAGOEEPBJNFieldNumber = 10;

	private static readonly FieldCodec<ItemList> _repeated_hNAGOEEPBJN_codec = FieldCodec.ForMessage(82u, ItemList.Parser);

	private readonly RepeatedField<ItemList> hNAGOEEPBJN_ = new RepeatedField<ItemList>();

	public const int EBJHKIKOLHJFieldNumber = 13;

	private DAPDOHOADDB eBJHKIKOLHJ_;

	public const int PKINFPGFINAFieldNumber = 14;

	private uint pKINFPGFINA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MatchThreeV2LevelEndScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MatchThreeV2LevelEndScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BEOPDMLKGLP MODDIBHCPPD
	{
		get
		{
			return mODDIBHCPPD_;
		}
		set
		{
			mODDIBHCPPD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList LAEJLLCGFDM
	{
		get
		{
			return lAEJLLCGFDM_;
		}
		set
		{
			lAEJLLCGFDM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AMGMADNBFIF
	{
		get
		{
			return aMGMADNBFIF_;
		}
		set
		{
			aMGMADNBFIF_ = value;
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
	public uint LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ItemList> HNAGOEEPBJN => hNAGOEEPBJN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAPDOHOADDB EBJHKIKOLHJ
	{
		get
		{
			return eBJHKIKOLHJ_;
		}
		set
		{
			eBJHKIKOLHJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PKINFPGFINA
	{
		get
		{
			return pKINFPGFINA_;
		}
		set
		{
			pKINFPGFINA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2LevelEndScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2LevelEndScRsp(MatchThreeV2LevelEndScRsp other)
		: this()
	{
		mODDIBHCPPD_ = ((other.mODDIBHCPPD_ != null) ? other.mODDIBHCPPD_.Clone() : null);
		lAEJLLCGFDM_ = ((other.lAEJLLCGFDM_ != null) ? other.lAEJLLCGFDM_.Clone() : null);
		aMGMADNBFIF_ = other.aMGMADNBFIF_;
		retcode_ = other.retcode_;
		levelId_ = other.levelId_;
		hNAGOEEPBJN_ = other.hNAGOEEPBJN_.Clone();
		eBJHKIKOLHJ_ = ((other.eBJHKIKOLHJ_ != null) ? other.eBJHKIKOLHJ_.Clone() : null);
		pKINFPGFINA_ = other.pKINFPGFINA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2LevelEndScRsp Clone()
	{
		return new MatchThreeV2LevelEndScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MatchThreeV2LevelEndScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MatchThreeV2LevelEndScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MODDIBHCPPD, other.MODDIBHCPPD))
		{
			return false;
		}
		if (!object.Equals(LAEJLLCGFDM, other.LAEJLLCGFDM))
		{
			return false;
		}
		if (AMGMADNBFIF != other.AMGMADNBFIF)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (!hNAGOEEPBJN_.Equals(other.hNAGOEEPBJN_))
		{
			return false;
		}
		if (!object.Equals(EBJHKIKOLHJ, other.EBJHKIKOLHJ))
		{
			return false;
		}
		if (PKINFPGFINA != other.PKINFPGFINA)
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
		if (mODDIBHCPPD_ != null)
		{
			num ^= MODDIBHCPPD.GetHashCode();
		}
		if (lAEJLLCGFDM_ != null)
		{
			num ^= LAEJLLCGFDM.GetHashCode();
		}
		if (AMGMADNBFIF != 0)
		{
			num ^= AMGMADNBFIF.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		num ^= hNAGOEEPBJN_.GetHashCode();
		if (eBJHKIKOLHJ_ != null)
		{
			num ^= EBJHKIKOLHJ.GetHashCode();
		}
		if (PKINFPGFINA != 0)
		{
			num ^= PKINFPGFINA.GetHashCode();
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
		if (mODDIBHCPPD_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MODDIBHCPPD);
		}
		if (lAEJLLCGFDM_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(LAEJLLCGFDM);
		}
		if (AMGMADNBFIF != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(AMGMADNBFIF);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(LevelId);
		}
		hNAGOEEPBJN_.WriteTo(ref output, _repeated_hNAGOEEPBJN_codec);
		if (eBJHKIKOLHJ_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(EBJHKIKOLHJ);
		}
		if (PKINFPGFINA != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(PKINFPGFINA);
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
		if (mODDIBHCPPD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MODDIBHCPPD);
		}
		if (lAEJLLCGFDM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LAEJLLCGFDM);
		}
		if (AMGMADNBFIF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AMGMADNBFIF);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		num += hNAGOEEPBJN_.CalculateSize(_repeated_hNAGOEEPBJN_codec);
		if (eBJHKIKOLHJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EBJHKIKOLHJ);
		}
		if (PKINFPGFINA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PKINFPGFINA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MatchThreeV2LevelEndScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mODDIBHCPPD_ != null)
		{
			if (mODDIBHCPPD_ == null)
			{
				MODDIBHCPPD = new BEOPDMLKGLP();
			}
			MODDIBHCPPD.MergeFrom(other.MODDIBHCPPD);
		}
		if (other.lAEJLLCGFDM_ != null)
		{
			if (lAEJLLCGFDM_ == null)
			{
				LAEJLLCGFDM = new ItemList();
			}
			LAEJLLCGFDM.MergeFrom(other.LAEJLLCGFDM);
		}
		if (other.AMGMADNBFIF != 0)
		{
			AMGMADNBFIF = other.AMGMADNBFIF;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.LevelId != 0)
		{
			LevelId = other.LevelId;
		}
		hNAGOEEPBJN_.Add(other.hNAGOEEPBJN_);
		if (other.eBJHKIKOLHJ_ != null)
		{
			if (eBJHKIKOLHJ_ == null)
			{
				EBJHKIKOLHJ = new DAPDOHOADDB();
			}
			EBJHKIKOLHJ.MergeFrom(other.EBJHKIKOLHJ);
		}
		if (other.PKINFPGFINA != 0)
		{
			PKINFPGFINA = other.PKINFPGFINA;
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
				if (mODDIBHCPPD_ == null)
				{
					MODDIBHCPPD = new BEOPDMLKGLP();
				}
				input.ReadMessage(MODDIBHCPPD);
				break;
			case 18u:
				if (lAEJLLCGFDM_ == null)
				{
					LAEJLLCGFDM = new ItemList();
				}
				input.ReadMessage(LAEJLLCGFDM);
				break;
			case 56u:
				AMGMADNBFIF = input.ReadUInt32();
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 72u:
				LevelId = input.ReadUInt32();
				break;
			case 82u:
				hNAGOEEPBJN_.AddEntriesFrom(ref input, _repeated_hNAGOEEPBJN_codec);
				break;
			case 106u:
				if (eBJHKIKOLHJ_ == null)
				{
					EBJHKIKOLHJ = new DAPDOHOADDB();
				}
				input.ReadMessage(EBJHKIKOLHJ);
				break;
			case 112u:
				PKINFPGFINA = input.ReadUInt32();
				break;
			}
		}
	}
}
