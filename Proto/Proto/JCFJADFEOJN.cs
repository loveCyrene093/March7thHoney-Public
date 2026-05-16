using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JCFJADFEOJN : IMessage<JCFJADFEOJN>, IMessage, IEquatable<JCFJADFEOJN>, IDeepCloneable<JCFJADFEOJN>, IBufferMessage
{
	private static readonly MessageParser<JCFJADFEOJN> _parser = new MessageParser<JCFJADFEOJN>(() => new JCFJADFEOJN());

	private UnknownFieldSet _unknownFields;

	public const int NDOCIKPLKIFFieldNumber = 2;

	private uint nDOCIKPLKIF_;

	public const int BCOLJFHDLLDFieldNumber = 4;

	private uint bCOLJFHDLLD_;

	public const int IJEIEJLPGGJFieldNumber = 6;

	private uint iJEIEJLPGGJ_;

	public const int BBDOCJGAEEJFieldNumber = 7;

	private uint bBDOCJGAEEJ_;

	public const int TutorialUnlockIdListFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_tutorialUnlockIdList_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> tutorialUnlockIdList_ = new RepeatedField<uint>();

	public const int SectionIdFieldNumber = 11;

	private uint sectionId_;

	public const int BFNPCJOMGFLFieldNumber = 14;

	private uint bFNPCJOMGFL_;

	public const int DCPKPNLKGMMFieldNumber = 15;

	private uint dCPKPNLKGMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JCFJADFEOJN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JCFJADFEOJNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NDOCIKPLKIF
	{
		get
		{
			return nDOCIKPLKIF_;
		}
		set
		{
			nDOCIKPLKIF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BCOLJFHDLLD
	{
		get
		{
			return bCOLJFHDLLD_;
		}
		set
		{
			bCOLJFHDLLD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IJEIEJLPGGJ
	{
		get
		{
			return iJEIEJLPGGJ_;
		}
		set
		{
			iJEIEJLPGGJ_ = value;
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
	public RepeatedField<uint> TutorialUnlockIdList => tutorialUnlockIdList_;

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
	public uint BFNPCJOMGFL
	{
		get
		{
			return bFNPCJOMGFL_;
		}
		set
		{
			bFNPCJOMGFL_ = value;
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
	public JCFJADFEOJN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCFJADFEOJN(JCFJADFEOJN other)
		: this()
	{
		nDOCIKPLKIF_ = other.nDOCIKPLKIF_;
		bCOLJFHDLLD_ = other.bCOLJFHDLLD_;
		iJEIEJLPGGJ_ = other.iJEIEJLPGGJ_;
		bBDOCJGAEEJ_ = other.bBDOCJGAEEJ_;
		tutorialUnlockIdList_ = other.tutorialUnlockIdList_.Clone();
		sectionId_ = other.sectionId_;
		bFNPCJOMGFL_ = other.bFNPCJOMGFL_;
		dCPKPNLKGMM_ = other.dCPKPNLKGMM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCFJADFEOJN Clone()
	{
		return new JCFJADFEOJN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JCFJADFEOJN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JCFJADFEOJN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NDOCIKPLKIF != other.NDOCIKPLKIF)
		{
			return false;
		}
		if (BCOLJFHDLLD != other.BCOLJFHDLLD)
		{
			return false;
		}
		if (IJEIEJLPGGJ != other.IJEIEJLPGGJ)
		{
			return false;
		}
		if (BBDOCJGAEEJ != other.BBDOCJGAEEJ)
		{
			return false;
		}
		if (!tutorialUnlockIdList_.Equals(other.tutorialUnlockIdList_))
		{
			return false;
		}
		if (SectionId != other.SectionId)
		{
			return false;
		}
		if (BFNPCJOMGFL != other.BFNPCJOMGFL)
		{
			return false;
		}
		if (DCPKPNLKGMM != other.DCPKPNLKGMM)
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
		if (NDOCIKPLKIF != 0)
		{
			num ^= NDOCIKPLKIF.GetHashCode();
		}
		if (BCOLJFHDLLD != 0)
		{
			num ^= BCOLJFHDLLD.GetHashCode();
		}
		if (IJEIEJLPGGJ != 0)
		{
			num ^= IJEIEJLPGGJ.GetHashCode();
		}
		if (BBDOCJGAEEJ != 0)
		{
			num ^= BBDOCJGAEEJ.GetHashCode();
		}
		num ^= tutorialUnlockIdList_.GetHashCode();
		if (SectionId != 0)
		{
			num ^= SectionId.GetHashCode();
		}
		if (BFNPCJOMGFL != 0)
		{
			num ^= BFNPCJOMGFL.GetHashCode();
		}
		if (DCPKPNLKGMM != 0)
		{
			num ^= DCPKPNLKGMM.GetHashCode();
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
		if (NDOCIKPLKIF != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(NDOCIKPLKIF);
		}
		if (BCOLJFHDLLD != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BCOLJFHDLLD);
		}
		if (IJEIEJLPGGJ != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(IJEIEJLPGGJ);
		}
		if (BBDOCJGAEEJ != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(BBDOCJGAEEJ);
		}
		tutorialUnlockIdList_.WriteTo(ref output, _repeated_tutorialUnlockIdList_codec);
		if (SectionId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(SectionId);
		}
		if (BFNPCJOMGFL != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(BFNPCJOMGFL);
		}
		if (DCPKPNLKGMM != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(DCPKPNLKGMM);
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
		if (NDOCIKPLKIF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NDOCIKPLKIF);
		}
		if (BCOLJFHDLLD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BCOLJFHDLLD);
		}
		if (IJEIEJLPGGJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IJEIEJLPGGJ);
		}
		if (BBDOCJGAEEJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BBDOCJGAEEJ);
		}
		num += tutorialUnlockIdList_.CalculateSize(_repeated_tutorialUnlockIdList_codec);
		if (SectionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SectionId);
		}
		if (BFNPCJOMGFL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BFNPCJOMGFL);
		}
		if (DCPKPNLKGMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DCPKPNLKGMM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JCFJADFEOJN other)
	{
		if (other != null)
		{
			if (other.NDOCIKPLKIF != 0)
			{
				NDOCIKPLKIF = other.NDOCIKPLKIF;
			}
			if (other.BCOLJFHDLLD != 0)
			{
				BCOLJFHDLLD = other.BCOLJFHDLLD;
			}
			if (other.IJEIEJLPGGJ != 0)
			{
				IJEIEJLPGGJ = other.IJEIEJLPGGJ;
			}
			if (other.BBDOCJGAEEJ != 0)
			{
				BBDOCJGAEEJ = other.BBDOCJGAEEJ;
			}
			tutorialUnlockIdList_.Add(other.tutorialUnlockIdList_);
			if (other.SectionId != 0)
			{
				SectionId = other.SectionId;
			}
			if (other.BFNPCJOMGFL != 0)
			{
				BFNPCJOMGFL = other.BFNPCJOMGFL;
			}
			if (other.DCPKPNLKGMM != 0)
			{
				DCPKPNLKGMM = other.DCPKPNLKGMM;
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
			case 16u:
				NDOCIKPLKIF = input.ReadUInt32();
				break;
			case 32u:
				BCOLJFHDLLD = input.ReadUInt32();
				break;
			case 48u:
				IJEIEJLPGGJ = input.ReadUInt32();
				break;
			case 56u:
				BBDOCJGAEEJ = input.ReadUInt32();
				break;
			case 80u:
			case 82u:
				tutorialUnlockIdList_.AddEntriesFrom(ref input, _repeated_tutorialUnlockIdList_codec);
				break;
			case 88u:
				SectionId = input.ReadUInt32();
				break;
			case 112u:
				BFNPCJOMGFL = input.ReadUInt32();
				break;
			case 120u:
				DCPKPNLKGMM = input.ReadUInt32();
				break;
			}
		}
	}
}
