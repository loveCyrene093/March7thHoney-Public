using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DPHNLKIPDGJ : IMessage<DPHNLKIPDGJ>, IMessage, IEquatable<DPHNLKIPDGJ>, IDeepCloneable<DPHNLKIPDGJ>, IBufferMessage
{
	private static readonly MessageParser<DPHNLKIPDGJ> _parser = new MessageParser<DPHNLKIPDGJ>(() => new DPHNLKIPDGJ());

	private UnknownFieldSet _unknownFields;

	public const int BMEMPNKOBDMFieldNumber = 5;

	private bool bMEMPNKOBDM_;

	public const int IPOHLJBLKOAFieldNumber = 6;

	private uint iPOHLJBLKOA_;

	public const int EndTimeFieldNumber = 7;

	private long endTime_;

	public const int PLNNDCIJIHEFieldNumber = 10;

	private uint pLNNDCIJIHE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DPHNLKIPDGJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DPHNLKIPDGJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BMEMPNKOBDM
	{
		get
		{
			return bMEMPNKOBDM_;
		}
		set
		{
			bMEMPNKOBDM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IPOHLJBLKOA
	{
		get
		{
			return iPOHLJBLKOA_;
		}
		set
		{
			iPOHLJBLKOA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EndTime
	{
		get
		{
			return endTime_;
		}
		set
		{
			endTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PLNNDCIJIHE
	{
		get
		{
			return pLNNDCIJIHE_;
		}
		set
		{
			pLNNDCIJIHE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPHNLKIPDGJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPHNLKIPDGJ(DPHNLKIPDGJ other)
		: this()
	{
		bMEMPNKOBDM_ = other.bMEMPNKOBDM_;
		iPOHLJBLKOA_ = other.iPOHLJBLKOA_;
		endTime_ = other.endTime_;
		pLNNDCIJIHE_ = other.pLNNDCIJIHE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPHNLKIPDGJ Clone()
	{
		return new DPHNLKIPDGJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DPHNLKIPDGJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DPHNLKIPDGJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BMEMPNKOBDM != other.BMEMPNKOBDM)
		{
			return false;
		}
		if (IPOHLJBLKOA != other.IPOHLJBLKOA)
		{
			return false;
		}
		if (EndTime != other.EndTime)
		{
			return false;
		}
		if (PLNNDCIJIHE != other.PLNNDCIJIHE)
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
		if (BMEMPNKOBDM)
		{
			num ^= BMEMPNKOBDM.GetHashCode();
		}
		if (IPOHLJBLKOA != 0)
		{
			num ^= IPOHLJBLKOA.GetHashCode();
		}
		if (EndTime != 0L)
		{
			num ^= EndTime.GetHashCode();
		}
		if (PLNNDCIJIHE != 0)
		{
			num ^= PLNNDCIJIHE.GetHashCode();
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
		if (BMEMPNKOBDM)
		{
			output.WriteRawTag(40);
			output.WriteBool(BMEMPNKOBDM);
		}
		if (IPOHLJBLKOA != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(IPOHLJBLKOA);
		}
		if (EndTime != 0L)
		{
			output.WriteRawTag(56);
			output.WriteInt64(EndTime);
		}
		if (PLNNDCIJIHE != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(PLNNDCIJIHE);
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
		if (BMEMPNKOBDM)
		{
			num += 2;
		}
		if (IPOHLJBLKOA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IPOHLJBLKOA);
		}
		if (EndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndTime);
		}
		if (PLNNDCIJIHE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PLNNDCIJIHE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DPHNLKIPDGJ other)
	{
		if (other != null)
		{
			if (other.BMEMPNKOBDM)
			{
				BMEMPNKOBDM = other.BMEMPNKOBDM;
			}
			if (other.IPOHLJBLKOA != 0)
			{
				IPOHLJBLKOA = other.IPOHLJBLKOA;
			}
			if (other.EndTime != 0L)
			{
				EndTime = other.EndTime;
			}
			if (other.PLNNDCIJIHE != 0)
			{
				PLNNDCIJIHE = other.PLNNDCIJIHE;
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
			case 40u:
				BMEMPNKOBDM = input.ReadBool();
				break;
			case 48u:
				IPOHLJBLKOA = input.ReadUInt32();
				break;
			case 56u:
				EndTime = input.ReadInt64();
				break;
			case 80u:
				PLNNDCIJIHE = input.ReadUInt32();
				break;
			}
		}
	}
}
