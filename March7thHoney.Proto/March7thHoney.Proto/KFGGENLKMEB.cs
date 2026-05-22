using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KFGGENLKMEB : IMessage<KFGGENLKMEB>, IMessage, IEquatable<KFGGENLKMEB>, IDeepCloneable<KFGGENLKMEB>, IBufferMessage
{
	private static readonly MessageParser<KFGGENLKMEB> _parser = new MessageParser<KFGGENLKMEB>(() => new KFGGENLKMEB());

	private UnknownFieldSet _unknownFields;

	public const int LECFKGLEKCJFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_lECFKGLEKCJ_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> lECFKGLEKCJ_ = new RepeatedField<uint>();

	public const int BuffIdFieldNumber = 2;

	private uint buffId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KFGGENLKMEB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KFGGENLKMEBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LECFKGLEKCJ => lECFKGLEKCJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFGGENLKMEB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFGGENLKMEB(KFGGENLKMEB other)
		: this()
	{
		lECFKGLEKCJ_ = other.lECFKGLEKCJ_.Clone();
		buffId_ = other.buffId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFGGENLKMEB Clone()
	{
		return new KFGGENLKMEB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KFGGENLKMEB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KFGGENLKMEB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lECFKGLEKCJ_.Equals(other.lECFKGLEKCJ_))
		{
			return false;
		}
		if (BuffId != other.BuffId)
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
		num ^= lECFKGLEKCJ_.GetHashCode();
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
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
		lECFKGLEKCJ_.WriteTo(ref output, _repeated_lECFKGLEKCJ_codec);
		if (BuffId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(BuffId);
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
		num += lECFKGLEKCJ_.CalculateSize(_repeated_lECFKGLEKCJ_codec);
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KFGGENLKMEB other)
	{
		if (other != null)
		{
			lECFKGLEKCJ_.Add(other.lECFKGLEKCJ_);
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
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
			case 10u:
				lECFKGLEKCJ_.AddEntriesFrom(ref input, _repeated_lECFKGLEKCJ_codec);
				break;
			case 16u:
				BuffId = input.ReadUInt32();
				break;
			}
		}
	}
}
