using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AKCNBOEOAPA : IMessage<AKCNBOEOAPA>, IMessage, IEquatable<AKCNBOEOAPA>, IDeepCloneable<AKCNBOEOAPA>, IBufferMessage
{
	private static readonly MessageParser<AKCNBOEOAPA> _parser = new MessageParser<AKCNBOEOAPA>(() => new AKCNBOEOAPA());

	private UnknownFieldSet _unknownFields;

	public const int JECHJDDNHMLFieldNumber = 6;

	private int jECHJDDNHML_;

	public const int KeyFieldNumber = 7;

	private uint key_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AKCNBOEOAPA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AKCNBOEOAPAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int JECHJDDNHML
	{
		get
		{
			return jECHJDDNHML_;
		}
		set
		{
			jECHJDDNHML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Key
	{
		get
		{
			return key_;
		}
		set
		{
			key_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKCNBOEOAPA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKCNBOEOAPA(AKCNBOEOAPA other)
		: this()
	{
		jECHJDDNHML_ = other.jECHJDDNHML_;
		key_ = other.key_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKCNBOEOAPA Clone()
	{
		return new AKCNBOEOAPA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AKCNBOEOAPA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AKCNBOEOAPA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JECHJDDNHML != other.JECHJDDNHML)
		{
			return false;
		}
		if (Key != other.Key)
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
		if (JECHJDDNHML != 0)
		{
			num ^= JECHJDDNHML.GetHashCode();
		}
		if (Key != 0)
		{
			num ^= Key.GetHashCode();
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
		if (JECHJDDNHML != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(JECHJDDNHML);
		}
		if (Key != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Key);
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
		if (JECHJDDNHML != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(JECHJDDNHML);
		}
		if (Key != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Key);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AKCNBOEOAPA other)
	{
		if (other != null)
		{
			if (other.JECHJDDNHML != 0)
			{
				JECHJDDNHML = other.JECHJDDNHML;
			}
			if (other.Key != 0)
			{
				Key = other.Key;
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
			case 48u:
				JECHJDDNHML = input.ReadInt32();
				break;
			case 56u:
				Key = input.ReadUInt32();
				break;
			}
		}
	}
}
