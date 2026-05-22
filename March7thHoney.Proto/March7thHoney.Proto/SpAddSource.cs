using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpAddSource : IMessage<SpAddSource>, IMessage, IEquatable<SpAddSource>, IDeepCloneable<SpAddSource>, IBufferMessage
{
	private static readonly MessageParser<SpAddSource> _parser = new MessageParser<SpAddSource>(() => new SpAddSource());

	private UnknownFieldSet _unknownFields;

	public const int SourceFieldNumber = 1;

	private string source_ = "";

	public const int SpAddFieldNumber = 2;

	private uint spAdd_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SpAddSource> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SpAddSourceReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Source
	{
		get
		{
			return source_;
		}
		set
		{
			source_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SpAdd
	{
		get
		{
			return spAdd_;
		}
		set
		{
			spAdd_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpAddSource()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpAddSource(SpAddSource other)
		: this()
	{
		source_ = other.source_;
		spAdd_ = other.spAdd_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpAddSource Clone()
	{
		return new SpAddSource(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SpAddSource);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpAddSource other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Source != other.Source)
		{
			return false;
		}
		if (SpAdd != other.SpAdd)
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
		if (Source.Length != 0)
		{
			num ^= Source.GetHashCode();
		}
		if (SpAdd != 0)
		{
			num ^= SpAdd.GetHashCode();
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
		if (Source.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Source);
		}
		if (SpAdd != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(SpAdd);
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
		if (Source.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Source);
		}
		if (SpAdd != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SpAdd);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpAddSource other)
	{
		if (other != null)
		{
			if (other.Source.Length != 0)
			{
				Source = other.Source;
			}
			if (other.SpAdd != 0)
			{
				SpAdd = other.SpAdd;
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
			case 10u:
				Source = input.ReadString();
				break;
			case 16u:
				SpAdd = input.ReadUInt32();
				break;
			}
		}
	}
}
