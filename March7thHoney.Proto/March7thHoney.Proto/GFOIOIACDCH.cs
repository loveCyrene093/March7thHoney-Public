using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GFOIOIACDCH : IMessage<GFOIOIACDCH>, IMessage, IEquatable<GFOIOIACDCH>, IDeepCloneable<GFOIOIACDCH>, IBufferMessage
{
	private static readonly MessageParser<GFOIOIACDCH> _parser = new MessageParser<GFOIOIACDCH>(() => new GFOIOIACDCH());

	private UnknownFieldSet _unknownFields;

	public const int DMGCIDGKPFFFieldNumber = 6;

	private MCPPIEJEBEF dMGCIDGKPFF_;

	public const int PAIBKOMPFOEFieldNumber = 7;

	private uint pAIBKOMPFOE_;

	public const int KPDHCPCCPNAFieldNumber = 11;

	private GCOIFAHPGDF kPDHCPCCPNA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GFOIOIACDCH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GFOIOIACDCHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCPPIEJEBEF DMGCIDGKPFF
	{
		get
		{
			return dMGCIDGKPFF_;
		}
		set
		{
			dMGCIDGKPFF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PAIBKOMPFOE
	{
		get
		{
			return pAIBKOMPFOE_;
		}
		set
		{
			pAIBKOMPFOE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCOIFAHPGDF KPDHCPCCPNA
	{
		get
		{
			return kPDHCPCCPNA_;
		}
		set
		{
			kPDHCPCCPNA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFOIOIACDCH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFOIOIACDCH(GFOIOIACDCH other)
		: this()
	{
		dMGCIDGKPFF_ = ((other.dMGCIDGKPFF_ != null) ? other.dMGCIDGKPFF_.Clone() : null);
		pAIBKOMPFOE_ = other.pAIBKOMPFOE_;
		kPDHCPCCPNA_ = ((other.kPDHCPCCPNA_ != null) ? other.kPDHCPCCPNA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFOIOIACDCH Clone()
	{
		return new GFOIOIACDCH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GFOIOIACDCH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GFOIOIACDCH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DMGCIDGKPFF, other.DMGCIDGKPFF))
		{
			return false;
		}
		if (PAIBKOMPFOE != other.PAIBKOMPFOE)
		{
			return false;
		}
		if (!object.Equals(KPDHCPCCPNA, other.KPDHCPCCPNA))
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
		if (dMGCIDGKPFF_ != null)
		{
			num ^= DMGCIDGKPFF.GetHashCode();
		}
		if (PAIBKOMPFOE != 0)
		{
			num ^= PAIBKOMPFOE.GetHashCode();
		}
		if (kPDHCPCCPNA_ != null)
		{
			num ^= KPDHCPCCPNA.GetHashCode();
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
		if (dMGCIDGKPFF_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(DMGCIDGKPFF);
		}
		if (PAIBKOMPFOE != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(PAIBKOMPFOE);
		}
		if (kPDHCPCCPNA_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(KPDHCPCCPNA);
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
		if (dMGCIDGKPFF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DMGCIDGKPFF);
		}
		if (PAIBKOMPFOE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PAIBKOMPFOE);
		}
		if (kPDHCPCCPNA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KPDHCPCCPNA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GFOIOIACDCH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.dMGCIDGKPFF_ != null)
		{
			if (dMGCIDGKPFF_ == null)
			{
				DMGCIDGKPFF = new MCPPIEJEBEF();
			}
			DMGCIDGKPFF.MergeFrom(other.DMGCIDGKPFF);
		}
		if (other.PAIBKOMPFOE != 0)
		{
			PAIBKOMPFOE = other.PAIBKOMPFOE;
		}
		if (other.kPDHCPCCPNA_ != null)
		{
			if (kPDHCPCCPNA_ == null)
			{
				KPDHCPCCPNA = new GCOIFAHPGDF();
			}
			KPDHCPCCPNA.MergeFrom(other.KPDHCPCCPNA);
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
			case 50u:
				if (dMGCIDGKPFF_ == null)
				{
					DMGCIDGKPFF = new MCPPIEJEBEF();
				}
				input.ReadMessage(DMGCIDGKPFF);
				break;
			case 56u:
				PAIBKOMPFOE = input.ReadUInt32();
				break;
			case 90u:
				if (kPDHCPCCPNA_ == null)
				{
					KPDHCPCCPNA = new GCOIFAHPGDF();
				}
				input.ReadMessage(KPDHCPCCPNA);
				break;
			}
		}
	}
}
