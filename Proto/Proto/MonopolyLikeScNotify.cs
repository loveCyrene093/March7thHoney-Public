using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyLikeScNotify : IMessage<MonopolyLikeScNotify>, IMessage, IEquatable<MonopolyLikeScNotify>, IDeepCloneable<MonopolyLikeScNotify>, IBufferMessage
{
	private static readonly MessageParser<MonopolyLikeScNotify> _parser = new MessageParser<MonopolyLikeScNotify>(() => new MonopolyLikeScNotify());

	private UnknownFieldSet _unknownFields;

	public const int CHNPMIBHOAAFieldNumber = 4;

	private uint cHNPMIBHOAA_;

	public const int HFJNDOAIDOPFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_hFJNDOAIDOP_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> hFJNDOAIDOP_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyLikeScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyLikeScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CHNPMIBHOAA
	{
		get
		{
			return cHNPMIBHOAA_;
		}
		set
		{
			cHNPMIBHOAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HFJNDOAIDOP => hFJNDOAIDOP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyLikeScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyLikeScNotify(MonopolyLikeScNotify other)
		: this()
	{
		cHNPMIBHOAA_ = other.cHNPMIBHOAA_;
		hFJNDOAIDOP_ = other.hFJNDOAIDOP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyLikeScNotify Clone()
	{
		return new MonopolyLikeScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyLikeScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyLikeScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CHNPMIBHOAA != other.CHNPMIBHOAA)
		{
			return false;
		}
		if (!hFJNDOAIDOP_.Equals(other.hFJNDOAIDOP_))
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
		if (CHNPMIBHOAA != 0)
		{
			num ^= CHNPMIBHOAA.GetHashCode();
		}
		num ^= hFJNDOAIDOP_.GetHashCode();
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
		if (CHNPMIBHOAA != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CHNPMIBHOAA);
		}
		hFJNDOAIDOP_.WriteTo(ref output, _repeated_hFJNDOAIDOP_codec);
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
		if (CHNPMIBHOAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CHNPMIBHOAA);
		}
		num += hFJNDOAIDOP_.CalculateSize(_repeated_hFJNDOAIDOP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyLikeScNotify other)
	{
		if (other != null)
		{
			if (other.CHNPMIBHOAA != 0)
			{
				CHNPMIBHOAA = other.CHNPMIBHOAA;
			}
			hFJNDOAIDOP_.Add(other.hFJNDOAIDOP_);
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
			case 32u:
				CHNPMIBHOAA = input.ReadUInt32();
				break;
			case 120u:
			case 122u:
				hFJNDOAIDOP_.AddEntriesFrom(ref input, _repeated_hFJNDOAIDOP_codec);
				break;
			}
		}
	}
}
