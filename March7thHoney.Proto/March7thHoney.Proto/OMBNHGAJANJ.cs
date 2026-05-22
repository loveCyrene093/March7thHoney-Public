using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OMBNHGAJANJ : IMessage<OMBNHGAJANJ>, IMessage, IEquatable<OMBNHGAJANJ>, IDeepCloneable<OMBNHGAJANJ>, IBufferMessage
{
	private static readonly MessageParser<OMBNHGAJANJ> _parser = new MessageParser<OMBNHGAJANJ>(() => new OMBNHGAJANJ());

	private UnknownFieldSet _unknownFields;

	public const int NDOCIKPLKIFFieldNumber = 1;

	private uint nDOCIKPLKIF_;

	public const int DCPKPNLKGMMFieldNumber = 2;

	private uint dCPKPNLKGMM_;

	public const int SectionIdFieldNumber = 3;

	private uint sectionId_;

	public const int BNLHIMHFGDKFieldNumber = 4;

	private uint bNLHIMHFGDK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OMBNHGAJANJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OMBNHGAJANJReflection.Descriptor.MessageTypes[0];

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
	public OMBNHGAJANJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMBNHGAJANJ(OMBNHGAJANJ other)
		: this()
	{
		nDOCIKPLKIF_ = other.nDOCIKPLKIF_;
		dCPKPNLKGMM_ = other.dCPKPNLKGMM_;
		sectionId_ = other.sectionId_;
		bNLHIMHFGDK_ = other.bNLHIMHFGDK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMBNHGAJANJ Clone()
	{
		return new OMBNHGAJANJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OMBNHGAJANJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OMBNHGAJANJ other)
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
		if (DCPKPNLKGMM != other.DCPKPNLKGMM)
		{
			return false;
		}
		if (SectionId != other.SectionId)
		{
			return false;
		}
		if (BNLHIMHFGDK != other.BNLHIMHFGDK)
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
		if (DCPKPNLKGMM != 0)
		{
			num ^= DCPKPNLKGMM.GetHashCode();
		}
		if (SectionId != 0)
		{
			num ^= SectionId.GetHashCode();
		}
		if (BNLHIMHFGDK != 0)
		{
			num ^= BNLHIMHFGDK.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(NDOCIKPLKIF);
		}
		if (DCPKPNLKGMM != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(DCPKPNLKGMM);
		}
		if (SectionId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(SectionId);
		}
		if (BNLHIMHFGDK != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BNLHIMHFGDK);
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
		if (DCPKPNLKGMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DCPKPNLKGMM);
		}
		if (SectionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SectionId);
		}
		if (BNLHIMHFGDK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BNLHIMHFGDK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OMBNHGAJANJ other)
	{
		if (other != null)
		{
			if (other.NDOCIKPLKIF != 0)
			{
				NDOCIKPLKIF = other.NDOCIKPLKIF;
			}
			if (other.DCPKPNLKGMM != 0)
			{
				DCPKPNLKGMM = other.DCPKPNLKGMM;
			}
			if (other.SectionId != 0)
			{
				SectionId = other.SectionId;
			}
			if (other.BNLHIMHFGDK != 0)
			{
				BNLHIMHFGDK = other.BNLHIMHFGDK;
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
				NDOCIKPLKIF = input.ReadUInt32();
				break;
			case 16u:
				DCPKPNLKGMM = input.ReadUInt32();
				break;
			case 24u:
				SectionId = input.ReadUInt32();
				break;
			case 32u:
				BNLHIMHFGDK = input.ReadUInt32();
				break;
			}
		}
	}
}
