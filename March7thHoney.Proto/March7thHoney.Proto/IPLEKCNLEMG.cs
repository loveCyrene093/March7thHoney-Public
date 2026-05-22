using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IPLEKCNLEMG : IMessage<IPLEKCNLEMG>, IMessage, IEquatable<IPLEKCNLEMG>, IDeepCloneable<IPLEKCNLEMG>, IBufferMessage
{
	private static readonly MessageParser<IPLEKCNLEMG> _parser = new MessageParser<IPLEKCNLEMG>(() => new IPLEKCNLEMG());

	private UnknownFieldSet _unknownFields;

	public const int KPOOFBPGMLNFieldNumber = 1;

	private uint kPOOFBPGMLN_;

	public const int IBOPJGBFCJIFieldNumber = 4;

	private uint iBOPJGBFCJI_;

	public const int PNHOEDHBGNMFieldNumber = 5;

	private uint pNHOEDHBGNM_;

	public const int FIKFMPBHIHMFieldNumber = 9;

	private uint fIKFMPBHIHM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IPLEKCNLEMG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IPLEKCNLEMGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KPOOFBPGMLN
	{
		get
		{
			return kPOOFBPGMLN_;
		}
		set
		{
			kPOOFBPGMLN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IBOPJGBFCJI
	{
		get
		{
			return iBOPJGBFCJI_;
		}
		set
		{
			iBOPJGBFCJI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PNHOEDHBGNM
	{
		get
		{
			return pNHOEDHBGNM_;
		}
		set
		{
			pNHOEDHBGNM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FIKFMPBHIHM
	{
		get
		{
			return fIKFMPBHIHM_;
		}
		set
		{
			fIKFMPBHIHM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPLEKCNLEMG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPLEKCNLEMG(IPLEKCNLEMG other)
		: this()
	{
		kPOOFBPGMLN_ = other.kPOOFBPGMLN_;
		iBOPJGBFCJI_ = other.iBOPJGBFCJI_;
		pNHOEDHBGNM_ = other.pNHOEDHBGNM_;
		fIKFMPBHIHM_ = other.fIKFMPBHIHM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPLEKCNLEMG Clone()
	{
		return new IPLEKCNLEMG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IPLEKCNLEMG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IPLEKCNLEMG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KPOOFBPGMLN != other.KPOOFBPGMLN)
		{
			return false;
		}
		if (IBOPJGBFCJI != other.IBOPJGBFCJI)
		{
			return false;
		}
		if (PNHOEDHBGNM != other.PNHOEDHBGNM)
		{
			return false;
		}
		if (FIKFMPBHIHM != other.FIKFMPBHIHM)
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
		if (KPOOFBPGMLN != 0)
		{
			num ^= KPOOFBPGMLN.GetHashCode();
		}
		if (IBOPJGBFCJI != 0)
		{
			num ^= IBOPJGBFCJI.GetHashCode();
		}
		if (PNHOEDHBGNM != 0)
		{
			num ^= PNHOEDHBGNM.GetHashCode();
		}
		if (FIKFMPBHIHM != 0)
		{
			num ^= FIKFMPBHIHM.GetHashCode();
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
		if (KPOOFBPGMLN != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(KPOOFBPGMLN);
		}
		if (IBOPJGBFCJI != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(IBOPJGBFCJI);
		}
		if (PNHOEDHBGNM != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(PNHOEDHBGNM);
		}
		if (FIKFMPBHIHM != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(FIKFMPBHIHM);
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
		if (KPOOFBPGMLN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KPOOFBPGMLN);
		}
		if (IBOPJGBFCJI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IBOPJGBFCJI);
		}
		if (PNHOEDHBGNM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PNHOEDHBGNM);
		}
		if (FIKFMPBHIHM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FIKFMPBHIHM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IPLEKCNLEMG other)
	{
		if (other != null)
		{
			if (other.KPOOFBPGMLN != 0)
			{
				KPOOFBPGMLN = other.KPOOFBPGMLN;
			}
			if (other.IBOPJGBFCJI != 0)
			{
				IBOPJGBFCJI = other.IBOPJGBFCJI;
			}
			if (other.PNHOEDHBGNM != 0)
			{
				PNHOEDHBGNM = other.PNHOEDHBGNM;
			}
			if (other.FIKFMPBHIHM != 0)
			{
				FIKFMPBHIHM = other.FIKFMPBHIHM;
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
				KPOOFBPGMLN = input.ReadUInt32();
				break;
			case 32u:
				IBOPJGBFCJI = input.ReadUInt32();
				break;
			case 40u:
				PNHOEDHBGNM = input.ReadUInt32();
				break;
			case 72u:
				FIKFMPBHIHM = input.ReadUInt32();
				break;
			}
		}
	}
}
