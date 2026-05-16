using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetClientRaidTargetCountCsReq : IMessage<SetClientRaidTargetCountCsReq>, IMessage, IEquatable<SetClientRaidTargetCountCsReq>, IDeepCloneable<SetClientRaidTargetCountCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetClientRaidTargetCountCsReq> _parser = new MessageParser<SetClientRaidTargetCountCsReq>(() => new SetClientRaidTargetCountCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ProgressFieldNumber = 3;

	private uint progress_;

	public const int HJJMOOHHKMHFieldNumber = 14;

	private uint hJJMOOHHKMH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetClientRaidTargetCountCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetClientRaidTargetCountCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HJJMOOHHKMH
	{
		get
		{
			return hJJMOOHHKMH_;
		}
		set
		{
			hJJMOOHHKMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetClientRaidTargetCountCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetClientRaidTargetCountCsReq(SetClientRaidTargetCountCsReq other)
		: this()
	{
		progress_ = other.progress_;
		hJJMOOHHKMH_ = other.hJJMOOHHKMH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetClientRaidTargetCountCsReq Clone()
	{
		return new SetClientRaidTargetCountCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetClientRaidTargetCountCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetClientRaidTargetCountCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Progress != other.Progress)
		{
			return false;
		}
		if (HJJMOOHHKMH != other.HJJMOOHHKMH)
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
		if (Progress != 0)
		{
			num ^= Progress.GetHashCode();
		}
		if (HJJMOOHHKMH != 0)
		{
			num ^= HJJMOOHHKMH.GetHashCode();
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
		if (Progress != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Progress);
		}
		if (HJJMOOHHKMH != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(HJJMOOHHKMH);
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
		if (Progress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Progress);
		}
		if (HJJMOOHHKMH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HJJMOOHHKMH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetClientRaidTargetCountCsReq other)
	{
		if (other != null)
		{
			if (other.Progress != 0)
			{
				Progress = other.Progress;
			}
			if (other.HJJMOOHHKMH != 0)
			{
				HJJMOOHHKMH = other.HJJMOOHHKMH;
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
				Progress = input.ReadUInt32();
				break;
			case 112u:
				HJJMOOHHKMH = input.ReadUInt32();
				break;
			}
		}
	}
}
