using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JMDDGOGNBEK : IMessage<JMDDGOGNBEK>, IMessage, IEquatable<JMDDGOGNBEK>, IDeepCloneable<JMDDGOGNBEK>, IBufferMessage
{
	private static readonly MessageParser<JMDDGOGNBEK> _parser = new MessageParser<JMDDGOGNBEK>(() => new JMDDGOGNBEK());

	private UnknownFieldSet _unknownFields;

	public const int GoodsIdFieldNumber = 10;

	private uint goodsId_;

	public const int JDFCLIFHEBEFieldNumber = 15;

	private static readonly FieldCodec<BAPBJANOPLP> _repeated_jDFCLIFHEBE_codec = FieldCodec.ForMessage(122u, BAPBJANOPLP.Parser);

	private readonly RepeatedField<BAPBJANOPLP> jDFCLIFHEBE_ = new RepeatedField<BAPBJANOPLP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JMDDGOGNBEK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JMDDGOGNBEKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GoodsId
	{
		get
		{
			return goodsId_;
		}
		set
		{
			goodsId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BAPBJANOPLP> JDFCLIFHEBE => jDFCLIFHEBE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMDDGOGNBEK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMDDGOGNBEK(JMDDGOGNBEK other)
		: this()
	{
		goodsId_ = other.goodsId_;
		jDFCLIFHEBE_ = other.jDFCLIFHEBE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMDDGOGNBEK Clone()
	{
		return new JMDDGOGNBEK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JMDDGOGNBEK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JMDDGOGNBEK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GoodsId != other.GoodsId)
		{
			return false;
		}
		if (!jDFCLIFHEBE_.Equals(other.jDFCLIFHEBE_))
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
		if (GoodsId != 0)
		{
			num ^= GoodsId.GetHashCode();
		}
		num ^= jDFCLIFHEBE_.GetHashCode();
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
		if (GoodsId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(GoodsId);
		}
		jDFCLIFHEBE_.WriteTo(ref output, _repeated_jDFCLIFHEBE_codec);
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
		if (GoodsId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GoodsId);
		}
		num += jDFCLIFHEBE_.CalculateSize(_repeated_jDFCLIFHEBE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JMDDGOGNBEK other)
	{
		if (other != null)
		{
			if (other.GoodsId != 0)
			{
				GoodsId = other.GoodsId;
			}
			jDFCLIFHEBE_.Add(other.jDFCLIFHEBE_);
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
			case 80u:
				GoodsId = input.ReadUInt32();
				break;
			case 122u:
				jDFCLIFHEBE_.AddEntriesFrom(ref input, _repeated_jDFCLIFHEBE_codec);
				break;
			}
		}
	}
}
