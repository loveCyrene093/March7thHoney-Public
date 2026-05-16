using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeBossBuffInfo : IMessage<ChallengeBossBuffInfo>, IMessage, IEquatable<ChallengeBossBuffInfo>, IDeepCloneable<ChallengeBossBuffInfo>, IBufferMessage
{
	private static readonly MessageParser<ChallengeBossBuffInfo> _parser = new MessageParser<ChallengeBossBuffInfo>(() => new ChallengeBossBuffInfo());

	private UnknownFieldSet _unknownFields;

	public const int BuffTwoFieldNumber = 3;

	private uint buffTwo_;

	public const int BuffOneFieldNumber = 8;

	private uint buffOne_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeBossBuffInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengeBossBuffInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BuffTwo
	{
		get
		{
			return buffTwo_;
		}
		set
		{
			buffTwo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BuffOne
	{
		get
		{
			return buffOne_;
		}
		set
		{
			buffOne_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossBuffInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossBuffInfo(ChallengeBossBuffInfo other)
		: this()
	{
		buffTwo_ = other.buffTwo_;
		buffOne_ = other.buffOne_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossBuffInfo Clone()
	{
		return new ChallengeBossBuffInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengeBossBuffInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeBossBuffInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BuffTwo != other.BuffTwo)
		{
			return false;
		}
		if (BuffOne != other.BuffOne)
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
		if (BuffTwo != 0)
		{
			num ^= BuffTwo.GetHashCode();
		}
		if (BuffOne != 0)
		{
			num ^= BuffOne.GetHashCode();
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
		if (BuffTwo != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(BuffTwo);
		}
		if (BuffOne != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(BuffOne);
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
		if (BuffTwo != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffTwo);
		}
		if (BuffOne != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffOne);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeBossBuffInfo other)
	{
		if (other != null)
		{
			if (other.BuffTwo != 0)
			{
				BuffTwo = other.BuffTwo;
			}
			if (other.BuffOne != 0)
			{
				BuffOne = other.BuffOne;
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
				BuffTwo = input.ReadUInt32();
				break;
			case 64u:
				BuffOne = input.ReadUInt32();
				break;
			}
		}
	}
}
