using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightSectionRecordInfo : IMessage<GridFightSectionRecordInfo>, IMessage, IEquatable<GridFightSectionRecordInfo>, IDeepCloneable<GridFightSectionRecordInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightSectionRecordInfo> _parser = new MessageParser<GridFightSectionRecordInfo>(() => new GridFightSectionRecordInfo());

	private UnknownFieldSet _unknownFields;

	public const int BNLHIMHFGDKFieldNumber = 3;

	private uint bNLHIMHFGDK_;

	public const int SectionIdFieldNumber = 10;

	private uint sectionId_;

	public const int DCPKPNLKGMMFieldNumber = 12;

	private uint dCPKPNLKGMM_;

	public const int CampRecordInfoFieldNumber = 412;

	private GridFightSectionCampRecordInfo campRecordInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightSectionRecordInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightSectionRecordInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BNLHIMHFGDK
	{
		get
		{
			return bNLHIMHFGDK_;
		}
		set
		{
			bNLHIMHFGDK_ = value;
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
	public GridFightSectionCampRecordInfo CampRecordInfo
	{
		get
		{
			return campRecordInfo_;
		}
		set
		{
			campRecordInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSectionRecordInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSectionRecordInfo(GridFightSectionRecordInfo other)
		: this()
	{
		bNLHIMHFGDK_ = other.bNLHIMHFGDK_;
		sectionId_ = other.sectionId_;
		dCPKPNLKGMM_ = other.dCPKPNLKGMM_;
		campRecordInfo_ = ((other.campRecordInfo_ != null) ? other.campRecordInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSectionRecordInfo Clone()
	{
		return new GridFightSectionRecordInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightSectionRecordInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightSectionRecordInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BNLHIMHFGDK != other.BNLHIMHFGDK)
		{
			return false;
		}
		if (SectionId != other.SectionId)
		{
			return false;
		}
		if (DCPKPNLKGMM != other.DCPKPNLKGMM)
		{
			return false;
		}
		if (!object.Equals(CampRecordInfo, other.CampRecordInfo))
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
		if (BNLHIMHFGDK != 0)
		{
			num ^= BNLHIMHFGDK.GetHashCode();
		}
		if (SectionId != 0)
		{
			num ^= SectionId.GetHashCode();
		}
		if (DCPKPNLKGMM != 0)
		{
			num ^= DCPKPNLKGMM.GetHashCode();
		}
		if (campRecordInfo_ != null)
		{
			num ^= CampRecordInfo.GetHashCode();
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
		if (BNLHIMHFGDK != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(BNLHIMHFGDK);
		}
		if (SectionId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(SectionId);
		}
		if (DCPKPNLKGMM != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(DCPKPNLKGMM);
		}
		if (campRecordInfo_ != null)
		{
			output.WriteRawTag(226, 25);
			output.WriteMessage(CampRecordInfo);
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
		if (BNLHIMHFGDK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BNLHIMHFGDK);
		}
		if (SectionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SectionId);
		}
		if (DCPKPNLKGMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DCPKPNLKGMM);
		}
		if (campRecordInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CampRecordInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightSectionRecordInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BNLHIMHFGDK != 0)
		{
			BNLHIMHFGDK = other.BNLHIMHFGDK;
		}
		if (other.SectionId != 0)
		{
			SectionId = other.SectionId;
		}
		if (other.DCPKPNLKGMM != 0)
		{
			DCPKPNLKGMM = other.DCPKPNLKGMM;
		}
		if (other.campRecordInfo_ != null)
		{
			if (campRecordInfo_ == null)
			{
				CampRecordInfo = new GridFightSectionCampRecordInfo();
			}
			CampRecordInfo.MergeFrom(other.CampRecordInfo);
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
			case 24u:
				BNLHIMHFGDK = input.ReadUInt32();
				break;
			case 80u:
				SectionId = input.ReadUInt32();
				break;
			case 96u:
				DCPKPNLKGMM = input.ReadUInt32();
				break;
			case 3298u:
				if (campRecordInfo_ == null)
				{
					CampRecordInfo = new GridFightSectionCampRecordInfo();
				}
				input.ReadMessage(CampRecordInfo);
				break;
			}
		}
	}
}
