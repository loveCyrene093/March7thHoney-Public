using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BGMLAAEOFOH : IMessage<BGMLAAEOFOH>, IMessage, IEquatable<BGMLAAEOFOH>, IDeepCloneable<BGMLAAEOFOH>, IBufferMessage
{
	private static readonly MessageParser<BGMLAAEOFOH> _parser = new MessageParser<BGMLAAEOFOH>(() => new BGMLAAEOFOH());

	private UnknownFieldSet _unknownFields;

	public const int UidFieldNumber = 1;

	private uint uid_;

	public const int ANBBPPHBCJHFieldNumber = 2;

	private uint aNBBPPHBCJH_;

	public const int BBDOCJGAEEJFieldNumber = 3;

	private uint bBDOCJGAEEJ_;

	public const int MPPFOJCENPDFieldNumber = 4;

	private uint mPPFOJCENPD_;

	public const int DCPKPNLKGMMFieldNumber = 5;

	private uint dCPKPNLKGMM_;

	public const int SectionIdFieldNumber = 6;

	private uint sectionId_;

	public const int GridGameRoleListFieldNumber = 7;

	private static readonly FieldCodec<NFABIIBMNPB> _repeated_gridGameRoleList_codec = FieldCodec.ForMessage(58u, NFABIIBMNPB.Parser);

	private readonly RepeatedField<NFABIIBMNPB> gridGameRoleList_ = new RepeatedField<NFABIIBMNPB>();

	public const int LHCHBABCPMIFieldNumber = 8;

	private ILOGJILOJGB lHCHBABCPMI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BGMLAAEOFOH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BGMLAAEOFOHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ANBBPPHBCJH
	{
		get
		{
			return aNBBPPHBCJH_;
		}
		set
		{
			aNBBPPHBCJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BBDOCJGAEEJ
	{
		get
		{
			return bBDOCJGAEEJ_;
		}
		set
		{
			bBDOCJGAEEJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MPPFOJCENPD
	{
		get
		{
			return mPPFOJCENPD_;
		}
		set
		{
			mPPFOJCENPD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DCPKPNLKGMM
	{
		get
		{
			return dCPKPNLKGMM_;
		}
		set
		{
			dCPKPNLKGMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SectionId
	{
		get
		{
			return sectionId_;
		}
		set
		{
			sectionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NFABIIBMNPB> GridGameRoleList => gridGameRoleList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILOGJILOJGB LHCHBABCPMI
	{
		get
		{
			return lHCHBABCPMI_;
		}
		set
		{
			lHCHBABCPMI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGMLAAEOFOH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGMLAAEOFOH(BGMLAAEOFOH other)
		: this()
	{
		uid_ = other.uid_;
		aNBBPPHBCJH_ = other.aNBBPPHBCJH_;
		bBDOCJGAEEJ_ = other.bBDOCJGAEEJ_;
		mPPFOJCENPD_ = other.mPPFOJCENPD_;
		dCPKPNLKGMM_ = other.dCPKPNLKGMM_;
		sectionId_ = other.sectionId_;
		gridGameRoleList_ = other.gridGameRoleList_.Clone();
		lHCHBABCPMI_ = ((other.lHCHBABCPMI_ != null) ? other.lHCHBABCPMI_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGMLAAEOFOH Clone()
	{
		return new BGMLAAEOFOH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BGMLAAEOFOH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BGMLAAEOFOH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (ANBBPPHBCJH != other.ANBBPPHBCJH)
		{
			return false;
		}
		if (BBDOCJGAEEJ != other.BBDOCJGAEEJ)
		{
			return false;
		}
		if (MPPFOJCENPD != other.MPPFOJCENPD)
		{
			return false;
		}
		if (DCPKPNLKGMM != other.DCPKPNLKGMM)
		{
			return false;
		}
		if (SectionId != other.SectionId)
		{
			return false;
		}
		if (!gridGameRoleList_.Equals(other.gridGameRoleList_))
		{
			return false;
		}
		if (!object.Equals(LHCHBABCPMI, other.LHCHBABCPMI))
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
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (ANBBPPHBCJH != 0)
		{
			num ^= ANBBPPHBCJH.GetHashCode();
		}
		if (BBDOCJGAEEJ != 0)
		{
			num ^= BBDOCJGAEEJ.GetHashCode();
		}
		if (MPPFOJCENPD != 0)
		{
			num ^= MPPFOJCENPD.GetHashCode();
		}
		if (DCPKPNLKGMM != 0)
		{
			num ^= DCPKPNLKGMM.GetHashCode();
		}
		if (SectionId != 0)
		{
			num ^= SectionId.GetHashCode();
		}
		num ^= gridGameRoleList_.GetHashCode();
		if (lHCHBABCPMI_ != null)
		{
			num ^= LHCHBABCPMI.GetHashCode();
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
		if (Uid != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Uid);
		}
		if (ANBBPPHBCJH != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ANBBPPHBCJH);
		}
		if (BBDOCJGAEEJ != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(BBDOCJGAEEJ);
		}
		if (MPPFOJCENPD != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MPPFOJCENPD);
		}
		if (DCPKPNLKGMM != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(DCPKPNLKGMM);
		}
		if (SectionId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(SectionId);
		}
		gridGameRoleList_.WriteTo(ref output, _repeated_gridGameRoleList_codec);
		if (lHCHBABCPMI_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(LHCHBABCPMI);
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
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (ANBBPPHBCJH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ANBBPPHBCJH);
		}
		if (BBDOCJGAEEJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BBDOCJGAEEJ);
		}
		if (MPPFOJCENPD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MPPFOJCENPD);
		}
		if (DCPKPNLKGMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DCPKPNLKGMM);
		}
		if (SectionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SectionId);
		}
		num += gridGameRoleList_.CalculateSize(_repeated_gridGameRoleList_codec);
		if (lHCHBABCPMI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LHCHBABCPMI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BGMLAAEOFOH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Uid != 0)
		{
			Uid = other.Uid;
		}
		if (other.ANBBPPHBCJH != 0)
		{
			ANBBPPHBCJH = other.ANBBPPHBCJH;
		}
		if (other.BBDOCJGAEEJ != 0)
		{
			BBDOCJGAEEJ = other.BBDOCJGAEEJ;
		}
		if (other.MPPFOJCENPD != 0)
		{
			MPPFOJCENPD = other.MPPFOJCENPD;
		}
		if (other.DCPKPNLKGMM != 0)
		{
			DCPKPNLKGMM = other.DCPKPNLKGMM;
		}
		if (other.SectionId != 0)
		{
			SectionId = other.SectionId;
		}
		gridGameRoleList_.Add(other.gridGameRoleList_);
		if (other.lHCHBABCPMI_ != null)
		{
			if (lHCHBABCPMI_ == null)
			{
				LHCHBABCPMI = new ILOGJILOJGB();
			}
			LHCHBABCPMI.MergeFrom(other.LHCHBABCPMI);
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
			case 8u:
				Uid = input.ReadUInt32();
				break;
			case 16u:
				ANBBPPHBCJH = input.ReadUInt32();
				break;
			case 24u:
				BBDOCJGAEEJ = input.ReadUInt32();
				break;
			case 32u:
				MPPFOJCENPD = input.ReadUInt32();
				break;
			case 40u:
				DCPKPNLKGMM = input.ReadUInt32();
				break;
			case 48u:
				SectionId = input.ReadUInt32();
				break;
			case 58u:
				gridGameRoleList_.AddEntriesFrom(ref input, _repeated_gridGameRoleList_codec);
				break;
			case 66u:
				if (lHCHBABCPMI_ == null)
				{
					LHCHBABCPMI = new ILOGJILOJGB();
				}
				input.ReadMessage(LHCHBABCPMI);
				break;
			}
		}
	}
}
