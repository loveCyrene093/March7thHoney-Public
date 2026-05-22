using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SwapLineupCsReq : IMessage<SwapLineupCsReq>, IMessage, IEquatable<SwapLineupCsReq>, IDeepCloneable<SwapLineupCsReq>, IBufferMessage
{
	private static readonly MessageParser<SwapLineupCsReq> _parser = new MessageParser<SwapLineupCsReq>(() => new SwapLineupCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IsVirtualFieldNumber = 1;

	private bool isVirtual_;

	public const int NHNHEJELCMMFieldNumber = 2;

	private uint nHNHEJELCMM_;

	public const int IndexFieldNumber = 10;

	private uint index_;

	public const int PlaneIdFieldNumber = 11;

	private uint planeId_;

	public const int ExtraLineupTypeFieldNumber = 13;

	private ExtraLineupType extraLineupType_;

	public const int IIFNABKHAEGFieldNumber = 15;

	private uint iIFNABKHAEG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SwapLineupCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SwapLineupCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsVirtual
	{
		get
		{
			return isVirtual_;
		}
		set
		{
			isVirtual_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NHNHEJELCMM
	{
		get
		{
			return nHNHEJELCMM_;
		}
		set
		{
			nHNHEJELCMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Index
	{
		get
		{
			return index_;
		}
		set
		{
			index_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PlaneId
	{
		get
		{
			return planeId_;
		}
		set
		{
			planeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExtraLineupType ExtraLineupType
	{
		get
		{
			return extraLineupType_;
		}
		set
		{
			extraLineupType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IIFNABKHAEG
	{
		get
		{
			return iIFNABKHAEG_;
		}
		set
		{
			iIFNABKHAEG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwapLineupCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwapLineupCsReq(SwapLineupCsReq other)
		: this()
	{
		isVirtual_ = other.isVirtual_;
		nHNHEJELCMM_ = other.nHNHEJELCMM_;
		index_ = other.index_;
		planeId_ = other.planeId_;
		extraLineupType_ = other.extraLineupType_;
		iIFNABKHAEG_ = other.iIFNABKHAEG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwapLineupCsReq Clone()
	{
		return new SwapLineupCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SwapLineupCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SwapLineupCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsVirtual != other.IsVirtual)
		{
			return false;
		}
		if (NHNHEJELCMM != other.NHNHEJELCMM)
		{
			return false;
		}
		if (Index != other.Index)
		{
			return false;
		}
		if (PlaneId != other.PlaneId)
		{
			return false;
		}
		if (ExtraLineupType != other.ExtraLineupType)
		{
			return false;
		}
		if (IIFNABKHAEG != other.IIFNABKHAEG)
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
		if (IsVirtual)
		{
			num ^= IsVirtual.GetHashCode();
		}
		if (NHNHEJELCMM != 0)
		{
			num ^= NHNHEJELCMM.GetHashCode();
		}
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
		}
		if (PlaneId != 0)
		{
			num ^= PlaneId.GetHashCode();
		}
		if (ExtraLineupType != ExtraLineupType.LineupNone)
		{
			num ^= ExtraLineupType.GetHashCode();
		}
		if (IIFNABKHAEG != 0)
		{
			num ^= IIFNABKHAEG.GetHashCode();
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
		if (IsVirtual)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsVirtual);
		}
		if (NHNHEJELCMM != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(NHNHEJELCMM);
		}
		if (Index != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Index);
		}
		if (PlaneId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(PlaneId);
		}
		if (ExtraLineupType != ExtraLineupType.LineupNone)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)ExtraLineupType);
		}
		if (IIFNABKHAEG != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(IIFNABKHAEG);
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
		if (IsVirtual)
		{
			num += 2;
		}
		if (NHNHEJELCMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NHNHEJELCMM);
		}
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Index);
		}
		if (PlaneId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PlaneId);
		}
		if (ExtraLineupType != ExtraLineupType.LineupNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ExtraLineupType);
		}
		if (IIFNABKHAEG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IIFNABKHAEG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SwapLineupCsReq other)
	{
		if (other != null)
		{
			if (other.IsVirtual)
			{
				IsVirtual = other.IsVirtual;
			}
			if (other.NHNHEJELCMM != 0)
			{
				NHNHEJELCMM = other.NHNHEJELCMM;
			}
			if (other.Index != 0)
			{
				Index = other.Index;
			}
			if (other.PlaneId != 0)
			{
				PlaneId = other.PlaneId;
			}
			if (other.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				ExtraLineupType = other.ExtraLineupType;
			}
			if (other.IIFNABKHAEG != 0)
			{
				IIFNABKHAEG = other.IIFNABKHAEG;
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
				IsVirtual = input.ReadBool();
				break;
			case 16u:
				NHNHEJELCMM = input.ReadUInt32();
				break;
			case 80u:
				Index = input.ReadUInt32();
				break;
			case 88u:
				PlaneId = input.ReadUInt32();
				break;
			case 104u:
				ExtraLineupType = (ExtraLineupType)input.ReadEnum();
				break;
			case 120u:
				IIFNABKHAEG = input.ReadUInt32();
				break;
			}
		}
	}
}
