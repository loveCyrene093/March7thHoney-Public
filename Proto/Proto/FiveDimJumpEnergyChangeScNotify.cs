using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FiveDimJumpEnergyChangeScNotify : IMessage<FiveDimJumpEnergyChangeScNotify>, IMessage, IEquatable<FiveDimJumpEnergyChangeScNotify>, IDeepCloneable<FiveDimJumpEnergyChangeScNotify>, IBufferMessage
{
	private static readonly MessageParser<FiveDimJumpEnergyChangeScNotify> _parser = new MessageParser<FiveDimJumpEnergyChangeScNotify>(() => new FiveDimJumpEnergyChangeScNotify());

	private UnknownFieldSet _unknownFields;

	public const int JJOOHOADJMAFieldNumber = 11;

	private uint jJOOHOADJMA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FiveDimJumpEnergyChangeScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FiveDimJumpEnergyChangeScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JJOOHOADJMA
	{
		get
		{
			return jJOOHOADJMA_;
		}
		set
		{
			jJOOHOADJMA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FiveDimJumpEnergyChangeScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FiveDimJumpEnergyChangeScNotify(FiveDimJumpEnergyChangeScNotify other)
		: this()
	{
		jJOOHOADJMA_ = other.jJOOHOADJMA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FiveDimJumpEnergyChangeScNotify Clone()
	{
		return new FiveDimJumpEnergyChangeScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FiveDimJumpEnergyChangeScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FiveDimJumpEnergyChangeScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JJOOHOADJMA != other.JJOOHOADJMA)
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
		if (JJOOHOADJMA != 0)
		{
			num ^= JJOOHOADJMA.GetHashCode();
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
		if (JJOOHOADJMA != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(JJOOHOADJMA);
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
		if (JJOOHOADJMA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JJOOHOADJMA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FiveDimJumpEnergyChangeScNotify other)
	{
		if (other != null)
		{
			if (other.JJOOHOADJMA != 0)
			{
				JJOOHOADJMA = other.JJOOHOADJMA;
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
			if (num != 88)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				JJOOHOADJMA = input.ReadUInt32();
			}
		}
	}
}
