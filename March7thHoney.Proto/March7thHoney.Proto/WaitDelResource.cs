using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class WaitDelResource : IMessage<WaitDelResource>, IMessage, IEquatable<WaitDelResource>, IDeepCloneable<WaitDelResource>, IBufferMessage
{
	private static readonly MessageParser<WaitDelResource> _parser = new MessageParser<WaitDelResource>(() => new WaitDelResource());

	private UnknownFieldSet _unknownFields;

	public const int NumFieldNumber = 8;

	private uint num_;

	public const int TidFieldNumber = 9;

	private uint tid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<WaitDelResource> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => WaitDelResourceReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Num
	{
		get
		{
			return num_;
		}
		set
		{
			num_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Tid
	{
		get
		{
			return tid_;
		}
		set
		{
			tid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WaitDelResource()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WaitDelResource(WaitDelResource other)
		: this()
	{
		num_ = other.num_;
		tid_ = other.tid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WaitDelResource Clone()
	{
		return new WaitDelResource(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as WaitDelResource);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(WaitDelResource other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Num != other.Num)
		{
			return false;
		}
		if (Tid != other.Tid)
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
		if (Num != 0)
		{
			num ^= Num.GetHashCode();
		}
		if (Tid != 0)
		{
			num ^= Tid.GetHashCode();
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
		if (Num != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Num);
		}
		if (Tid != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Tid);
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
		if (Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Num);
		}
		if (Tid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Tid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(WaitDelResource other)
	{
		if (other != null)
		{
			if (other.Num != 0)
			{
				Num = other.Num;
			}
			if (other.Tid != 0)
			{
				Tid = other.Tid;
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
			case 64u:
				Num = input.ReadUInt32();
				break;
			case 72u:
				Tid = input.ReadUInt32();
				break;
			}
		}
	}
}
