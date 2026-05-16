using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DKBCDGFJADM : IMessage<DKBCDGFJADM>, IMessage, IEquatable<DKBCDGFJADM>, IDeepCloneable<DKBCDGFJADM>, IBufferMessage
{
	private static readonly MessageParser<DKBCDGFJADM> _parser = new MessageParser<DKBCDGFJADM>(() => new DKBCDGFJADM());

	private UnknownFieldSet _unknownFields;

	public const int DMHLLKBMHELFieldNumber = 4;

	private uint dMHLLKBMHEL_;

	public const int FPHGHAPGNAEFieldNumber = 6;

	private MHMFAMHHJAA fPHGHAPGNAE_;

	public const int ItemIdFieldNumber = 10;

	private uint itemId_;

	public const int MAGPAONJOBDFieldNumber = 13;

	private uint mAGPAONJOBD_;

	public const int BMNDBKBHIOCFieldNumber = 14;

	private OIDHAGNGKLG bMNDBKBHIOC_;

	public const int NJPCMDNHOFLFieldNumber = 15;

	private uint nJPCMDNHOFL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DKBCDGFJADM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DKBCDGFJADMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DMHLLKBMHEL
	{
		get
		{
			return dMHLLKBMHEL_;
		}
		set
		{
			dMHLLKBMHEL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MHMFAMHHJAA FPHGHAPGNAE
	{
		get
		{
			return fPHGHAPGNAE_;
		}
		set
		{
			fPHGHAPGNAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MAGPAONJOBD
	{
		get
		{
			return mAGPAONJOBD_;
		}
		set
		{
			mAGPAONJOBD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OIDHAGNGKLG BMNDBKBHIOC
	{
		get
		{
			return bMNDBKBHIOC_;
		}
		set
		{
			bMNDBKBHIOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NJPCMDNHOFL
	{
		get
		{
			return nJPCMDNHOFL_;
		}
		set
		{
			nJPCMDNHOFL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKBCDGFJADM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKBCDGFJADM(DKBCDGFJADM other)
		: this()
	{
		dMHLLKBMHEL_ = other.dMHLLKBMHEL_;
		fPHGHAPGNAE_ = other.fPHGHAPGNAE_;
		itemId_ = other.itemId_;
		mAGPAONJOBD_ = other.mAGPAONJOBD_;
		bMNDBKBHIOC_ = ((other.bMNDBKBHIOC_ != null) ? other.bMNDBKBHIOC_.Clone() : null);
		nJPCMDNHOFL_ = other.nJPCMDNHOFL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKBCDGFJADM Clone()
	{
		return new DKBCDGFJADM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DKBCDGFJADM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DKBCDGFJADM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DMHLLKBMHEL != other.DMHLLKBMHEL)
		{
			return false;
		}
		if (FPHGHAPGNAE != other.FPHGHAPGNAE)
		{
			return false;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (MAGPAONJOBD != other.MAGPAONJOBD)
		{
			return false;
		}
		if (!object.Equals(BMNDBKBHIOC, other.BMNDBKBHIOC))
		{
			return false;
		}
		if (NJPCMDNHOFL != other.NJPCMDNHOFL)
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
		if (DMHLLKBMHEL != 0)
		{
			num ^= DMHLLKBMHEL.GetHashCode();
		}
		if (FPHGHAPGNAE != MHMFAMHHJAA.Oaidgfjlfpo)
		{
			num ^= FPHGHAPGNAE.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (MAGPAONJOBD != 0)
		{
			num ^= MAGPAONJOBD.GetHashCode();
		}
		if (bMNDBKBHIOC_ != null)
		{
			num ^= BMNDBKBHIOC.GetHashCode();
		}
		if (NJPCMDNHOFL != 0)
		{
			num ^= NJPCMDNHOFL.GetHashCode();
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
		if (DMHLLKBMHEL != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DMHLLKBMHEL);
		}
		if (FPHGHAPGNAE != MHMFAMHHJAA.Oaidgfjlfpo)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)FPHGHAPGNAE);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(ItemId);
		}
		if (MAGPAONJOBD != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(MAGPAONJOBD);
		}
		if (bMNDBKBHIOC_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(BMNDBKBHIOC);
		}
		if (NJPCMDNHOFL != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(NJPCMDNHOFL);
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
		if (DMHLLKBMHEL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DMHLLKBMHEL);
		}
		if (FPHGHAPGNAE != MHMFAMHHJAA.Oaidgfjlfpo)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FPHGHAPGNAE);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemId);
		}
		if (MAGPAONJOBD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MAGPAONJOBD);
		}
		if (bMNDBKBHIOC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BMNDBKBHIOC);
		}
		if (NJPCMDNHOFL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NJPCMDNHOFL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DKBCDGFJADM other)
	{
		if (other == null)
		{
			return;
		}
		if (other.DMHLLKBMHEL != 0)
		{
			DMHLLKBMHEL = other.DMHLLKBMHEL;
		}
		if (other.FPHGHAPGNAE != MHMFAMHHJAA.Oaidgfjlfpo)
		{
			FPHGHAPGNAE = other.FPHGHAPGNAE;
		}
		if (other.ItemId != 0)
		{
			ItemId = other.ItemId;
		}
		if (other.MAGPAONJOBD != 0)
		{
			MAGPAONJOBD = other.MAGPAONJOBD;
		}
		if (other.bMNDBKBHIOC_ != null)
		{
			if (bMNDBKBHIOC_ == null)
			{
				BMNDBKBHIOC = new OIDHAGNGKLG();
			}
			BMNDBKBHIOC.MergeFrom(other.BMNDBKBHIOC);
		}
		if (other.NJPCMDNHOFL != 0)
		{
			NJPCMDNHOFL = other.NJPCMDNHOFL;
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
			case 32u:
				DMHLLKBMHEL = input.ReadUInt32();
				break;
			case 48u:
				FPHGHAPGNAE = (MHMFAMHHJAA)input.ReadEnum();
				break;
			case 80u:
				ItemId = input.ReadUInt32();
				break;
			case 104u:
				MAGPAONJOBD = input.ReadUInt32();
				break;
			case 114u:
				if (bMNDBKBHIOC_ == null)
				{
					BMNDBKBHIOC = new OIDHAGNGKLG();
				}
				input.ReadMessage(BMNDBKBHIOC);
				break;
			case 120u:
				NJPCMDNHOFL = input.ReadUInt32();
				break;
			}
		}
	}
}
