using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OEGICCFGHJE : IMessage<OEGICCFGHJE>, IMessage, IEquatable<OEGICCFGHJE>, IDeepCloneable<OEGICCFGHJE>, IBufferMessage
{
	private static readonly MessageParser<OEGICCFGHJE> _parser = new MessageParser<OEGICCFGHJE>(() => new OEGICCFGHJE());

	private UnknownFieldSet _unknownFields;

	public const int DKPCDLDDONGFieldNumber = 3;

	private uint dKPCDLDDONG_;

	public const int IsTakenRewardFieldNumber = 14;

	private bool isTakenReward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OEGICCFGHJE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OEGICCFGHJEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DKPCDLDDONG
	{
		get
		{
			return dKPCDLDDONG_;
		}
		set
		{
			dKPCDLDDONG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsTakenReward
	{
		get
		{
			return isTakenReward_;
		}
		set
		{
			isTakenReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEGICCFGHJE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEGICCFGHJE(OEGICCFGHJE other)
		: this()
	{
		dKPCDLDDONG_ = other.dKPCDLDDONG_;
		isTakenReward_ = other.isTakenReward_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEGICCFGHJE Clone()
	{
		return new OEGICCFGHJE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OEGICCFGHJE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OEGICCFGHJE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DKPCDLDDONG != other.DKPCDLDDONG)
		{
			return false;
		}
		if (IsTakenReward != other.IsTakenReward)
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
		if (DKPCDLDDONG != 0)
		{
			num ^= DKPCDLDDONG.GetHashCode();
		}
		if (IsTakenReward)
		{
			num ^= IsTakenReward.GetHashCode();
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
		if (DKPCDLDDONG != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(DKPCDLDDONG);
		}
		if (IsTakenReward)
		{
			output.WriteRawTag(112);
			output.WriteBool(IsTakenReward);
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
		if (DKPCDLDDONG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DKPCDLDDONG);
		}
		if (IsTakenReward)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OEGICCFGHJE other)
	{
		if (other != null)
		{
			if (other.DKPCDLDDONG != 0)
			{
				DKPCDLDDONG = other.DKPCDLDDONG;
			}
			if (other.IsTakenReward)
			{
				IsTakenReward = other.IsTakenReward;
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
			case 24u:
				DKPCDLDDONG = input.ReadUInt32();
				break;
			case 112u:
				IsTakenReward = input.ReadBool();
				break;
			}
		}
	}
}
