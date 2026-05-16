using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ACCBPEAJFEO : IMessage<ACCBPEAJFEO>, IMessage, IEquatable<ACCBPEAJFEO>, IDeepCloneable<ACCBPEAJFEO>, IBufferMessage
{
	private static readonly MessageParser<ACCBPEAJFEO> _parser = new MessageParser<ACCBPEAJFEO>(() => new ACCBPEAJFEO());

	private UnknownFieldSet _unknownFields;

	public const int StatusFieldNumber = 1;

	private LBMLLJHFEHB status_;

	public const int KEDIMMAGFBOFieldNumber = 4;

	private uint kEDIMMAGFBO_;

	public const int NLMMFJOPBFCFieldNumber = 5;

	private uint nLMMFJOPBFC_;

	public const int ReasonFieldNumber = 8;

	private OFHPKJDHOMF reason_;

	public const int FHLJEHDHJLIFieldNumber = 13;

	private static readonly FieldCodec<OJEJCHBHCJL> _repeated_fHLJEHDHJLI_codec = FieldCodec.ForMessage(106u, OJEJCHBHCJL.Parser);

	private readonly RepeatedField<OJEJCHBHCJL> fHLJEHDHJLI_ = new RepeatedField<OJEJCHBHCJL>();

	public const int APMIAKDPHJLFieldNumber = 14;

	private uint aPMIAKDPHJL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ACCBPEAJFEO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ACCBPEAJFEOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBMLLJHFEHB Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KEDIMMAGFBO
	{
		get
		{
			return kEDIMMAGFBO_;
		}
		set
		{
			kEDIMMAGFBO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NLMMFJOPBFC
	{
		get
		{
			return nLMMFJOPBFC_;
		}
		set
		{
			nLMMFJOPBFC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFHPKJDHOMF Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OJEJCHBHCJL> FHLJEHDHJLI => fHLJEHDHJLI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint APMIAKDPHJL
	{
		get
		{
			return aPMIAKDPHJL_;
		}
		set
		{
			aPMIAKDPHJL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACCBPEAJFEO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACCBPEAJFEO(ACCBPEAJFEO other)
		: this()
	{
		status_ = other.status_;
		kEDIMMAGFBO_ = other.kEDIMMAGFBO_;
		nLMMFJOPBFC_ = other.nLMMFJOPBFC_;
		reason_ = other.reason_;
		fHLJEHDHJLI_ = other.fHLJEHDHJLI_.Clone();
		aPMIAKDPHJL_ = other.aPMIAKDPHJL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACCBPEAJFEO Clone()
	{
		return new ACCBPEAJFEO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ACCBPEAJFEO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ACCBPEAJFEO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (KEDIMMAGFBO != other.KEDIMMAGFBO)
		{
			return false;
		}
		if (NLMMFJOPBFC != other.NLMMFJOPBFC)
		{
			return false;
		}
		if (Reason != other.Reason)
		{
			return false;
		}
		if (!fHLJEHDHJLI_.Equals(other.fHLJEHDHJLI_))
		{
			return false;
		}
		if (APMIAKDPHJL != other.APMIAKDPHJL)
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
		if (Status != LBMLLJHFEHB.Pcpdhelpkem)
		{
			num ^= Status.GetHashCode();
		}
		if (KEDIMMAGFBO != 0)
		{
			num ^= KEDIMMAGFBO.GetHashCode();
		}
		if (NLMMFJOPBFC != 0)
		{
			num ^= NLMMFJOPBFC.GetHashCode();
		}
		if (Reason != OFHPKJDHOMF.Pcpdhelpkem)
		{
			num ^= Reason.GetHashCode();
		}
		num ^= fHLJEHDHJLI_.GetHashCode();
		if (APMIAKDPHJL != 0)
		{
			num ^= APMIAKDPHJL.GetHashCode();
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
		if (Status != LBMLLJHFEHB.Pcpdhelpkem)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Status);
		}
		if (KEDIMMAGFBO != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(KEDIMMAGFBO);
		}
		if (NLMMFJOPBFC != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(NLMMFJOPBFC);
		}
		if (Reason != OFHPKJDHOMF.Pcpdhelpkem)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)Reason);
		}
		fHLJEHDHJLI_.WriteTo(ref output, _repeated_fHLJEHDHJLI_codec);
		if (APMIAKDPHJL != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(APMIAKDPHJL);
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
		if (Status != LBMLLJHFEHB.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (KEDIMMAGFBO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KEDIMMAGFBO);
		}
		if (NLMMFJOPBFC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NLMMFJOPBFC);
		}
		if (Reason != OFHPKJDHOMF.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		num += fHLJEHDHJLI_.CalculateSize(_repeated_fHLJEHDHJLI_codec);
		if (APMIAKDPHJL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(APMIAKDPHJL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ACCBPEAJFEO other)
	{
		if (other != null)
		{
			if (other.Status != LBMLLJHFEHB.Pcpdhelpkem)
			{
				Status = other.Status;
			}
			if (other.KEDIMMAGFBO != 0)
			{
				KEDIMMAGFBO = other.KEDIMMAGFBO;
			}
			if (other.NLMMFJOPBFC != 0)
			{
				NLMMFJOPBFC = other.NLMMFJOPBFC;
			}
			if (other.Reason != OFHPKJDHOMF.Pcpdhelpkem)
			{
				Reason = other.Reason;
			}
			fHLJEHDHJLI_.Add(other.fHLJEHDHJLI_);
			if (other.APMIAKDPHJL != 0)
			{
				APMIAKDPHJL = other.APMIAKDPHJL;
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
				Status = (LBMLLJHFEHB)input.ReadEnum();
				break;
			case 32u:
				KEDIMMAGFBO = input.ReadUInt32();
				break;
			case 40u:
				NLMMFJOPBFC = input.ReadUInt32();
				break;
			case 64u:
				Reason = (OFHPKJDHOMF)input.ReadEnum();
				break;
			case 106u:
				fHLJEHDHJLI_.AddEntriesFrom(ref input, _repeated_fHLJEHDHJLI_codec);
				break;
			case 112u:
				APMIAKDPHJL = input.ReadUInt32();
				break;
			}
		}
	}
}
