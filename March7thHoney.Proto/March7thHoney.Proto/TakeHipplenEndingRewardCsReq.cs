using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeHipplenEndingRewardCsReq : IMessage<TakeHipplenEndingRewardCsReq>, IMessage, IEquatable<TakeHipplenEndingRewardCsReq>, IDeepCloneable<TakeHipplenEndingRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<TakeHipplenEndingRewardCsReq> _parser = new MessageParser<TakeHipplenEndingRewardCsReq>(() => new TakeHipplenEndingRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DKPCDLDDONGFieldNumber = 12;

	private uint dKPCDLDDONG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeHipplenEndingRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeHipplenEndingRewardCsReqReflection.Descriptor.MessageTypes[0];

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
	public TakeHipplenEndingRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeHipplenEndingRewardCsReq(TakeHipplenEndingRewardCsReq other)
		: this()
	{
		dKPCDLDDONG_ = other.dKPCDLDDONG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeHipplenEndingRewardCsReq Clone()
	{
		return new TakeHipplenEndingRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeHipplenEndingRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeHipplenEndingRewardCsReq other)
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
			output.WriteRawTag(96);
			output.WriteUInt32(DKPCDLDDONG);
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakeHipplenEndingRewardCsReq other)
	{
		if (other != null)
		{
			if (other.DKPCDLDDONG != 0)
			{
				DKPCDLDDONG = other.DKPCDLDDONG;
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
			if (num != 96)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				DKPCDLDDONG = input.ReadUInt32();
			}
		}
	}
}
