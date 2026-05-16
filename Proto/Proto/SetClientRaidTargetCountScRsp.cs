using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetClientRaidTargetCountScRsp : IMessage<SetClientRaidTargetCountScRsp>, IMessage, IEquatable<SetClientRaidTargetCountScRsp>, IDeepCloneable<SetClientRaidTargetCountScRsp>, IBufferMessage
{
	private static readonly MessageParser<SetClientRaidTargetCountScRsp> _parser = new MessageParser<SetClientRaidTargetCountScRsp>(() => new SetClientRaidTargetCountScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ProgressFieldNumber = 1;

	private uint progress_;

	public const int HJJMOOHHKMHFieldNumber = 4;

	private uint hJJMOOHHKMH_;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetClientRaidTargetCountScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetClientRaidTargetCountScRspReflection.Descriptor.MessageTypes[0];

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
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetClientRaidTargetCountScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetClientRaidTargetCountScRsp(SetClientRaidTargetCountScRsp other)
		: this()
	{
		progress_ = other.progress_;
		hJJMOOHHKMH_ = other.hJJMOOHHKMH_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetClientRaidTargetCountScRsp Clone()
	{
		return new SetClientRaidTargetCountScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetClientRaidTargetCountScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetClientRaidTargetCountScRsp other)
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
		if (Retcode != other.Retcode)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(Progress);
		}
		if (HJJMOOHHKMH != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(HJJMOOHHKMH);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetClientRaidTargetCountScRsp other)
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
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
				Progress = input.ReadUInt32();
				break;
			case 32u:
				HJJMOOHHKMH = input.ReadUInt32();
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
