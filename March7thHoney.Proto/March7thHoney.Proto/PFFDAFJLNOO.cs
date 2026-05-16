using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PFFDAFJLNOO : IMessage<PFFDAFJLNOO>, IMessage, IEquatable<PFFDAFJLNOO>, IDeepCloneable<PFFDAFJLNOO>, IBufferMessage
{
	private static readonly MessageParser<PFFDAFJLNOO> _parser = new MessageParser<PFFDAFJLNOO>(() => new PFFDAFJLNOO());

	private UnknownFieldSet _unknownFields;

	public const int IKGEBHGEEFBFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_iKGEBHGEEFB_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> iKGEBHGEEFB_ = new RepeatedField<uint>();

	public const int TidFieldNumber = 7;

	private uint tid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PFFDAFJLNOO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PFFDAFJLNOOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IKGEBHGEEFB => iKGEBHGEEFB_;

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
	public PFFDAFJLNOO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PFFDAFJLNOO(PFFDAFJLNOO other)
		: this()
	{
		iKGEBHGEEFB_ = other.iKGEBHGEEFB_.Clone();
		tid_ = other.tid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PFFDAFJLNOO Clone()
	{
		return new PFFDAFJLNOO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PFFDAFJLNOO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PFFDAFJLNOO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iKGEBHGEEFB_.Equals(other.iKGEBHGEEFB_))
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
		num ^= iKGEBHGEEFB_.GetHashCode();
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
		iKGEBHGEEFB_.WriteTo(ref output, _repeated_iKGEBHGEEFB_codec);
		if (Tid != 0)
		{
			output.WriteRawTag(56);
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
		num += iKGEBHGEEFB_.CalculateSize(_repeated_iKGEBHGEEFB_codec);
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
	public void MergeFrom(PFFDAFJLNOO other)
	{
		if (other != null)
		{
			iKGEBHGEEFB_.Add(other.iKGEBHGEEFB_);
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
			case 16u:
			case 18u:
				iKGEBHGEEFB_.AddEntriesFrom(ref input, _repeated_iKGEBHGEEFB_codec);
				break;
			case 56u:
				Tid = input.ReadUInt32();
				break;
			}
		}
	}
}
