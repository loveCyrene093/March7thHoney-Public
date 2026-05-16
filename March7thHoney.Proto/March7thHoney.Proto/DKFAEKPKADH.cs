using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DKFAEKPKADH : IMessage<DKFAEKPKADH>, IMessage, IEquatable<DKFAEKPKADH>, IDeepCloneable<DKFAEKPKADH>, IBufferMessage
{
	private static readonly MessageParser<DKFAEKPKADH> _parser = new MessageParser<DKFAEKPKADH>(() => new DKFAEKPKADH());

	private UnknownFieldSet _unknownFields;

	public const int MNJNFMKIKMHFieldNumber = 1;

	private static readonly FieldCodec<JBDGHPCBHPO> _repeated_mNJNFMKIKMH_codec = FieldCodec.ForMessage(10u, JBDGHPCBHPO.Parser);

	private readonly RepeatedField<JBDGHPCBHPO> mNJNFMKIKMH_ = new RepeatedField<JBDGHPCBHPO>();

	public const int BFNLCFMDDJHFieldNumber = 4;

	private uint bFNLCFMDDJH_;

	public const int DKHLLGOIHKHFieldNumber = 6;

	private uint dKHLLGOIHKH_;

	public const int FGAAPCNNMIPFieldNumber = 12;

	private uint fGAAPCNNMIP_;

	public const int MEAJAEBDAOIFieldNumber = 13;

	private uint mEAJAEBDAOI_;

	public const int OLNOIIEDKEPFieldNumber = 14;

	private ItemCostData oLNOIIEDKEP_;

	public const int AFHBNKOHHHBFieldNumber = 15;

	private bool aFHBNKOHHHB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DKFAEKPKADH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DKFAEKPKADHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JBDGHPCBHPO> MNJNFMKIKMH => mNJNFMKIKMH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BFNLCFMDDJH
	{
		get
		{
			return bFNLCFMDDJH_;
		}
		set
		{
			bFNLCFMDDJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DKHLLGOIHKH
	{
		get
		{
			return dKHLLGOIHKH_;
		}
		set
		{
			dKHLLGOIHKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FGAAPCNNMIP
	{
		get
		{
			return fGAAPCNNMIP_;
		}
		set
		{
			fGAAPCNNMIP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MEAJAEBDAOI
	{
		get
		{
			return mEAJAEBDAOI_;
		}
		set
		{
			mEAJAEBDAOI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData OLNOIIEDKEP
	{
		get
		{
			return oLNOIIEDKEP_;
		}
		set
		{
			oLNOIIEDKEP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool AFHBNKOHHHB
	{
		get
		{
			return aFHBNKOHHHB_;
		}
		set
		{
			aFHBNKOHHHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKFAEKPKADH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKFAEKPKADH(DKFAEKPKADH other)
		: this()
	{
		mNJNFMKIKMH_ = other.mNJNFMKIKMH_.Clone();
		bFNLCFMDDJH_ = other.bFNLCFMDDJH_;
		dKHLLGOIHKH_ = other.dKHLLGOIHKH_;
		fGAAPCNNMIP_ = other.fGAAPCNNMIP_;
		mEAJAEBDAOI_ = other.mEAJAEBDAOI_;
		oLNOIIEDKEP_ = ((other.oLNOIIEDKEP_ != null) ? other.oLNOIIEDKEP_.Clone() : null);
		aFHBNKOHHHB_ = other.aFHBNKOHHHB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKFAEKPKADH Clone()
	{
		return new DKFAEKPKADH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DKFAEKPKADH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DKFAEKPKADH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mNJNFMKIKMH_.Equals(other.mNJNFMKIKMH_))
		{
			return false;
		}
		if (BFNLCFMDDJH != other.BFNLCFMDDJH)
		{
			return false;
		}
		if (DKHLLGOIHKH != other.DKHLLGOIHKH)
		{
			return false;
		}
		if (FGAAPCNNMIP != other.FGAAPCNNMIP)
		{
			return false;
		}
		if (MEAJAEBDAOI != other.MEAJAEBDAOI)
		{
			return false;
		}
		if (!object.Equals(OLNOIIEDKEP, other.OLNOIIEDKEP))
		{
			return false;
		}
		if (AFHBNKOHHHB != other.AFHBNKOHHHB)
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
		num ^= mNJNFMKIKMH_.GetHashCode();
		if (BFNLCFMDDJH != 0)
		{
			num ^= BFNLCFMDDJH.GetHashCode();
		}
		if (DKHLLGOIHKH != 0)
		{
			num ^= DKHLLGOIHKH.GetHashCode();
		}
		if (FGAAPCNNMIP != 0)
		{
			num ^= FGAAPCNNMIP.GetHashCode();
		}
		if (MEAJAEBDAOI != 0)
		{
			num ^= MEAJAEBDAOI.GetHashCode();
		}
		if (oLNOIIEDKEP_ != null)
		{
			num ^= OLNOIIEDKEP.GetHashCode();
		}
		if (AFHBNKOHHHB)
		{
			num ^= AFHBNKOHHHB.GetHashCode();
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
		mNJNFMKIKMH_.WriteTo(ref output, _repeated_mNJNFMKIKMH_codec);
		if (BFNLCFMDDJH != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BFNLCFMDDJH);
		}
		if (DKHLLGOIHKH != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(DKHLLGOIHKH);
		}
		if (FGAAPCNNMIP != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(FGAAPCNNMIP);
		}
		if (MEAJAEBDAOI != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(MEAJAEBDAOI);
		}
		if (oLNOIIEDKEP_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(OLNOIIEDKEP);
		}
		if (AFHBNKOHHHB)
		{
			output.WriteRawTag(120);
			output.WriteBool(AFHBNKOHHHB);
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
		num += mNJNFMKIKMH_.CalculateSize(_repeated_mNJNFMKIKMH_codec);
		if (BFNLCFMDDJH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BFNLCFMDDJH);
		}
		if (DKHLLGOIHKH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DKHLLGOIHKH);
		}
		if (FGAAPCNNMIP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FGAAPCNNMIP);
		}
		if (MEAJAEBDAOI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MEAJAEBDAOI);
		}
		if (oLNOIIEDKEP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OLNOIIEDKEP);
		}
		if (AFHBNKOHHHB)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DKFAEKPKADH other)
	{
		if (other == null)
		{
			return;
		}
		mNJNFMKIKMH_.Add(other.mNJNFMKIKMH_);
		if (other.BFNLCFMDDJH != 0)
		{
			BFNLCFMDDJH = other.BFNLCFMDDJH;
		}
		if (other.DKHLLGOIHKH != 0)
		{
			DKHLLGOIHKH = other.DKHLLGOIHKH;
		}
		if (other.FGAAPCNNMIP != 0)
		{
			FGAAPCNNMIP = other.FGAAPCNNMIP;
		}
		if (other.MEAJAEBDAOI != 0)
		{
			MEAJAEBDAOI = other.MEAJAEBDAOI;
		}
		if (other.oLNOIIEDKEP_ != null)
		{
			if (oLNOIIEDKEP_ == null)
			{
				OLNOIIEDKEP = new ItemCostData();
			}
			OLNOIIEDKEP.MergeFrom(other.OLNOIIEDKEP);
		}
		if (other.AFHBNKOHHHB)
		{
			AFHBNKOHHHB = other.AFHBNKOHHHB;
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
				mNJNFMKIKMH_.AddEntriesFrom(ref input, _repeated_mNJNFMKIKMH_codec);
				break;
			case 32u:
				BFNLCFMDDJH = input.ReadUInt32();
				break;
			case 48u:
				DKHLLGOIHKH = input.ReadUInt32();
				break;
			case 96u:
				FGAAPCNNMIP = input.ReadUInt32();
				break;
			case 104u:
				MEAJAEBDAOI = input.ReadUInt32();
				break;
			case 114u:
				if (oLNOIIEDKEP_ == null)
				{
					OLNOIIEDKEP = new ItemCostData();
				}
				input.ReadMessage(OLNOIIEDKEP);
				break;
			case 120u:
				AFHBNKOHHHB = input.ReadBool();
				break;
			}
		}
	}
}
