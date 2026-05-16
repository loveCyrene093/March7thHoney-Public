using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ACDGMLBDJJN : IMessage<ACDGMLBDJJN>, IMessage, IEquatable<ACDGMLBDJJN>, IDeepCloneable<ACDGMLBDJJN>, IBufferMessage
{
	private static readonly MessageParser<ACDGMLBDJJN> _parser = new MessageParser<ACDGMLBDJJN>(() => new ACDGMLBDJJN());

	private UnknownFieldSet _unknownFields;

	public const int BNLHIMHFGDKFieldNumber = 2;

	private uint bNLHIMHFGDK_;

	public const int FEMPCGCBHKBFieldNumber = 3;

	private uint fEMPCGCBHKB_;

	public const int SectionIdFieldNumber = 8;

	private uint sectionId_;

	public const int DCPKPNLKGMMFieldNumber = 12;

	private uint dCPKPNLKGMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ACDGMLBDJJN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ACDGMLBDJJNReflection.Descriptor.MessageTypes[0];

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
	public uint FEMPCGCBHKB
	{
		get
		{
			return fEMPCGCBHKB_;
		}
		set
		{
			fEMPCGCBHKB_ = value;
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
	public ACDGMLBDJJN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACDGMLBDJJN(ACDGMLBDJJN other)
		: this()
	{
		bNLHIMHFGDK_ = other.bNLHIMHFGDK_;
		fEMPCGCBHKB_ = other.fEMPCGCBHKB_;
		sectionId_ = other.sectionId_;
		dCPKPNLKGMM_ = other.dCPKPNLKGMM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACDGMLBDJJN Clone()
	{
		return new ACDGMLBDJJN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ACDGMLBDJJN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ACDGMLBDJJN other)
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
		if (FEMPCGCBHKB != other.FEMPCGCBHKB)
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
		if (FEMPCGCBHKB != 0)
		{
			num ^= FEMPCGCBHKB.GetHashCode();
		}
		if (SectionId != 0)
		{
			num ^= SectionId.GetHashCode();
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
		if (BNLHIMHFGDK != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(BNLHIMHFGDK);
		}
		if (FEMPCGCBHKB != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(FEMPCGCBHKB);
		}
		if (SectionId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(SectionId);
		}
		if (DCPKPNLKGMM != 0)
		{
			output.WriteRawTag(96);
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
		if (BNLHIMHFGDK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BNLHIMHFGDK);
		}
		if (FEMPCGCBHKB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FEMPCGCBHKB);
		}
		if (SectionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SectionId);
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
	public void MergeFrom(ACDGMLBDJJN other)
	{
		if (other != null)
		{
			if (other.BNLHIMHFGDK != 0)
			{
				BNLHIMHFGDK = other.BNLHIMHFGDK;
			}
			if (other.FEMPCGCBHKB != 0)
			{
				FEMPCGCBHKB = other.FEMPCGCBHKB;
			}
			if (other.SectionId != 0)
			{
				SectionId = other.SectionId;
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
				BNLHIMHFGDK = input.ReadUInt32();
				break;
			case 24u:
				FEMPCGCBHKB = input.ReadUInt32();
				break;
			case 64u:
				SectionId = input.ReadUInt32();
				break;
			case 96u:
				DCPKPNLKGMM = input.ReadUInt32();
				break;
			}
		}
	}
}
