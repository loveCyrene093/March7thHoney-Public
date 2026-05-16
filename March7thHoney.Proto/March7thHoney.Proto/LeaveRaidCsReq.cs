using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LeaveRaidCsReq : IMessage<LeaveRaidCsReq>, IMessage, IEquatable<LeaveRaidCsReq>, IDeepCloneable<LeaveRaidCsReq>, IBufferMessage
{
	private static readonly MessageParser<LeaveRaidCsReq> _parser = new MessageParser<LeaveRaidCsReq>(() => new LeaveRaidCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IsSaveFieldNumber = 9;

	private bool isSave_;

	public const int RaidIdFieldNumber = 15;

	private uint raidId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LeaveRaidCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LeaveRaidCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsSave
	{
		get
		{
			return isSave_;
		}
		set
		{
			isSave_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RaidId
	{
		get
		{
			return raidId_;
		}
		set
		{
			raidId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LeaveRaidCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LeaveRaidCsReq(LeaveRaidCsReq other)
		: this()
	{
		isSave_ = other.isSave_;
		raidId_ = other.raidId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LeaveRaidCsReq Clone()
	{
		return new LeaveRaidCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LeaveRaidCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LeaveRaidCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsSave != other.IsSave)
		{
			return false;
		}
		if (RaidId != other.RaidId)
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
		if (IsSave)
		{
			num ^= IsSave.GetHashCode();
		}
		if (RaidId != 0)
		{
			num ^= RaidId.GetHashCode();
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
		if (IsSave)
		{
			output.WriteRawTag(72);
			output.WriteBool(IsSave);
		}
		if (RaidId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(RaidId);
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
		if (IsSave)
		{
			num += 2;
		}
		if (RaidId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RaidId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LeaveRaidCsReq other)
	{
		if (other != null)
		{
			if (other.IsSave)
			{
				IsSave = other.IsSave;
			}
			if (other.RaidId != 0)
			{
				RaidId = other.RaidId;
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
			case 72u:
				IsSave = input.ReadBool();
				break;
			case 120u:
				RaidId = input.ReadUInt32();
				break;
			}
		}
	}
}
