using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DBHPNLHPCMD : IMessage<DBHPNLHPCMD>, IMessage, IEquatable<DBHPNLHPCMD>, IDeepCloneable<DBHPNLHPCMD>, IBufferMessage
{
	private static readonly MessageParser<DBHPNLHPCMD> _parser = new MessageParser<DBHPNLHPCMD>(() => new DBHPNLHPCMD());

	private UnknownFieldSet _unknownFields;

	public const int HNCDMHIDIJLFieldNumber = 1;

	private static readonly FieldCodec<JKLFBDFJLJH> _repeated_hNCDMHIDIJL_codec = FieldCodec.ForMessage(10u, JKLFBDFJLJH.Parser);

	private readonly RepeatedField<JKLFBDFJLJH> hNCDMHIDIJL_ = new RepeatedField<JKLFBDFJLJH>();

	public const int ILCHDGKODPEFieldNumber = 2;

	private uint iLCHDGKODPE_;

	public const int LPAGKHGCCFHFieldNumber = 5;

	private uint lPAGKHGCCFH_;

	public const int APHJPJBIMFBFieldNumber = 7;

	private uint aPHJPJBIMFB_;

	public const int FKEGAIHNODEFieldNumber = 8;

	private uint fKEGAIHNODE_;

	public const int NFGFPMEKPHNFieldNumber = 11;

	private uint nFGFPMEKPHN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DBHPNLHPCMD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DBHPNLHPCMDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JKLFBDFJLJH> HNCDMHIDIJL => hNCDMHIDIJL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ILCHDGKODPE
	{
		get
		{
			return iLCHDGKODPE_;
		}
		set
		{
			iLCHDGKODPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LPAGKHGCCFH
	{
		get
		{
			return lPAGKHGCCFH_;
		}
		set
		{
			lPAGKHGCCFH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint APHJPJBIMFB
	{
		get
		{
			return aPHJPJBIMFB_;
		}
		set
		{
			aPHJPJBIMFB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FKEGAIHNODE
	{
		get
		{
			return fKEGAIHNODE_;
		}
		set
		{
			fKEGAIHNODE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NFGFPMEKPHN
	{
		get
		{
			return nFGFPMEKPHN_;
		}
		set
		{
			nFGFPMEKPHN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DBHPNLHPCMD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DBHPNLHPCMD(DBHPNLHPCMD other)
		: this()
	{
		hNCDMHIDIJL_ = other.hNCDMHIDIJL_.Clone();
		iLCHDGKODPE_ = other.iLCHDGKODPE_;
		lPAGKHGCCFH_ = other.lPAGKHGCCFH_;
		aPHJPJBIMFB_ = other.aPHJPJBIMFB_;
		fKEGAIHNODE_ = other.fKEGAIHNODE_;
		nFGFPMEKPHN_ = other.nFGFPMEKPHN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DBHPNLHPCMD Clone()
	{
		return new DBHPNLHPCMD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DBHPNLHPCMD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DBHPNLHPCMD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hNCDMHIDIJL_.Equals(other.hNCDMHIDIJL_))
		{
			return false;
		}
		if (ILCHDGKODPE != other.ILCHDGKODPE)
		{
			return false;
		}
		if (LPAGKHGCCFH != other.LPAGKHGCCFH)
		{
			return false;
		}
		if (APHJPJBIMFB != other.APHJPJBIMFB)
		{
			return false;
		}
		if (FKEGAIHNODE != other.FKEGAIHNODE)
		{
			return false;
		}
		if (NFGFPMEKPHN != other.NFGFPMEKPHN)
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
		num ^= hNCDMHIDIJL_.GetHashCode();
		if (ILCHDGKODPE != 0)
		{
			num ^= ILCHDGKODPE.GetHashCode();
		}
		if (LPAGKHGCCFH != 0)
		{
			num ^= LPAGKHGCCFH.GetHashCode();
		}
		if (APHJPJBIMFB != 0)
		{
			num ^= APHJPJBIMFB.GetHashCode();
		}
		if (FKEGAIHNODE != 0)
		{
			num ^= FKEGAIHNODE.GetHashCode();
		}
		if (NFGFPMEKPHN != 0)
		{
			num ^= NFGFPMEKPHN.GetHashCode();
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
		hNCDMHIDIJL_.WriteTo(ref output, _repeated_hNCDMHIDIJL_codec);
		if (ILCHDGKODPE != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ILCHDGKODPE);
		}
		if (LPAGKHGCCFH != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(LPAGKHGCCFH);
		}
		if (APHJPJBIMFB != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(APHJPJBIMFB);
		}
		if (FKEGAIHNODE != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(FKEGAIHNODE);
		}
		if (NFGFPMEKPHN != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(NFGFPMEKPHN);
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
		num += hNCDMHIDIJL_.CalculateSize(_repeated_hNCDMHIDIJL_codec);
		if (ILCHDGKODPE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ILCHDGKODPE);
		}
		if (LPAGKHGCCFH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LPAGKHGCCFH);
		}
		if (APHJPJBIMFB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(APHJPJBIMFB);
		}
		if (FKEGAIHNODE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FKEGAIHNODE);
		}
		if (NFGFPMEKPHN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NFGFPMEKPHN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DBHPNLHPCMD other)
	{
		if (other != null)
		{
			hNCDMHIDIJL_.Add(other.hNCDMHIDIJL_);
			if (other.ILCHDGKODPE != 0)
			{
				ILCHDGKODPE = other.ILCHDGKODPE;
			}
			if (other.LPAGKHGCCFH != 0)
			{
				LPAGKHGCCFH = other.LPAGKHGCCFH;
			}
			if (other.APHJPJBIMFB != 0)
			{
				APHJPJBIMFB = other.APHJPJBIMFB;
			}
			if (other.FKEGAIHNODE != 0)
			{
				FKEGAIHNODE = other.FKEGAIHNODE;
			}
			if (other.NFGFPMEKPHN != 0)
			{
				NFGFPMEKPHN = other.NFGFPMEKPHN;
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
			case 10u:
				hNCDMHIDIJL_.AddEntriesFrom(ref input, _repeated_hNCDMHIDIJL_codec);
				break;
			case 16u:
				ILCHDGKODPE = input.ReadUInt32();
				break;
			case 40u:
				LPAGKHGCCFH = input.ReadUInt32();
				break;
			case 56u:
				APHJPJBIMFB = input.ReadUInt32();
				break;
			case 64u:
				FKEGAIHNODE = input.ReadUInt32();
				break;
			case 88u:
				NFGFPMEKPHN = input.ReadUInt32();
				break;
			}
		}
	}
}
