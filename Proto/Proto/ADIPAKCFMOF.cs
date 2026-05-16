using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ADIPAKCFMOF : IMessage<ADIPAKCFMOF>, IMessage, IEquatable<ADIPAKCFMOF>, IDeepCloneable<ADIPAKCFMOF>, IBufferMessage
{
	private static readonly MessageParser<ADIPAKCFMOF> _parser = new MessageParser<ADIPAKCFMOF>(() => new ADIPAKCFMOF());

	private UnknownFieldSet _unknownFields;

	public const int DAIPENEGCBDFieldNumber = 1;

	private int dAIPENEGCBD_;

	public const int DAMHMDPODLDFieldNumber = 14;

	private int dAMHMDPODLD_;

	public const int FDPMIGNAFIMFieldNumber = 15;

	private uint fDPMIGNAFIM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ADIPAKCFMOF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ADIPAKCFMOFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DAIPENEGCBD
	{
		get
		{
			return dAIPENEGCBD_;
		}
		set
		{
			dAIPENEGCBD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DAMHMDPODLD
	{
		get
		{
			return dAMHMDPODLD_;
		}
		set
		{
			dAMHMDPODLD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FDPMIGNAFIM
	{
		get
		{
			return fDPMIGNAFIM_;
		}
		set
		{
			fDPMIGNAFIM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADIPAKCFMOF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADIPAKCFMOF(ADIPAKCFMOF other)
		: this()
	{
		dAIPENEGCBD_ = other.dAIPENEGCBD_;
		dAMHMDPODLD_ = other.dAMHMDPODLD_;
		fDPMIGNAFIM_ = other.fDPMIGNAFIM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADIPAKCFMOF Clone()
	{
		return new ADIPAKCFMOF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ADIPAKCFMOF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ADIPAKCFMOF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DAIPENEGCBD != other.DAIPENEGCBD)
		{
			return false;
		}
		if (DAMHMDPODLD != other.DAMHMDPODLD)
		{
			return false;
		}
		if (FDPMIGNAFIM != other.FDPMIGNAFIM)
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
		if (DAIPENEGCBD != 0)
		{
			num ^= DAIPENEGCBD.GetHashCode();
		}
		if (DAMHMDPODLD != 0)
		{
			num ^= DAMHMDPODLD.GetHashCode();
		}
		if (FDPMIGNAFIM != 0)
		{
			num ^= FDPMIGNAFIM.GetHashCode();
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
		if (DAIPENEGCBD != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DAIPENEGCBD);
		}
		if (DAMHMDPODLD != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(DAMHMDPODLD);
		}
		if (FDPMIGNAFIM != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(FDPMIGNAFIM);
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
		if (DAIPENEGCBD != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DAIPENEGCBD);
		}
		if (DAMHMDPODLD != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DAMHMDPODLD);
		}
		if (FDPMIGNAFIM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FDPMIGNAFIM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ADIPAKCFMOF other)
	{
		if (other != null)
		{
			if (other.DAIPENEGCBD != 0)
			{
				DAIPENEGCBD = other.DAIPENEGCBD;
			}
			if (other.DAMHMDPODLD != 0)
			{
				DAMHMDPODLD = other.DAMHMDPODLD;
			}
			if (other.FDPMIGNAFIM != 0)
			{
				FDPMIGNAFIM = other.FDPMIGNAFIM;
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
				DAIPENEGCBD = input.ReadInt32();
				break;
			case 112u:
				DAMHMDPODLD = input.ReadInt32();
				break;
			case 120u:
				FDPMIGNAFIM = input.ReadUInt32();
				break;
			}
		}
	}
}
