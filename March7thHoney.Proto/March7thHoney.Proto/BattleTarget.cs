using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BattleTarget : IMessage<BattleTarget>, IMessage, IEquatable<BattleTarget>, IDeepCloneable<BattleTarget>, IBufferMessage
{
	private static readonly MessageParser<BattleTarget> _parser = new MessageParser<BattleTarget>(() => new BattleTarget());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private uint id_;

	public const int ProgressFieldNumber = 2;

	private uint progress_;

	public const int TotalProgressFieldNumber = 3;

	private uint totalProgress_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleTarget> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleTargetReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

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
	public uint TotalProgress
	{
		get
		{
			return totalProgress_;
		}
		set
		{
			totalProgress_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleTarget()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleTarget(BattleTarget other)
		: this()
	{
		id_ = other.id_;
		progress_ = other.progress_;
		totalProgress_ = other.totalProgress_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleTarget Clone()
	{
		return new BattleTarget(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleTarget);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleTarget other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Progress != other.Progress)
		{
			return false;
		}
		if (TotalProgress != other.TotalProgress)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Progress != 0)
		{
			num ^= Progress.GetHashCode();
		}
		if (TotalProgress != 0)
		{
			num ^= TotalProgress.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Id);
		}
		if (Progress != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Progress);
		}
		if (TotalProgress != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(TotalProgress);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (Progress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Progress);
		}
		if (TotalProgress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TotalProgress);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleTarget other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Progress != 0)
			{
				Progress = other.Progress;
			}
			if (other.TotalProgress != 0)
			{
				TotalProgress = other.TotalProgress;
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
				Id = input.ReadUInt32();
				break;
			case 16u:
				Progress = input.ReadUInt32();
				break;
			case 24u:
				TotalProgress = input.ReadUInt32();
				break;
			}
		}
	}
}
