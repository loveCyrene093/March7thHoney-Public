using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpaceZooDeleteCatCsReq : IMessage<SpaceZooDeleteCatCsReq>, IMessage, IEquatable<SpaceZooDeleteCatCsReq>, IDeepCloneable<SpaceZooDeleteCatCsReq>, IBufferMessage
{
	private static readonly MessageParser<SpaceZooDeleteCatCsReq> _parser = new MessageParser<SpaceZooDeleteCatCsReq>(() => new SpaceZooDeleteCatCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KICIFPJACNFFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_kICIFPJACNF_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> kICIFPJACNF_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SpaceZooDeleteCatCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SpaceZooDeleteCatCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> KICIFPJACNF => kICIFPJACNF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooDeleteCatCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooDeleteCatCsReq(SpaceZooDeleteCatCsReq other)
		: this()
	{
		kICIFPJACNF_ = other.kICIFPJACNF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooDeleteCatCsReq Clone()
	{
		return new SpaceZooDeleteCatCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SpaceZooDeleteCatCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpaceZooDeleteCatCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!kICIFPJACNF_.Equals(other.kICIFPJACNF_))
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
		num ^= kICIFPJACNF_.GetHashCode();
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
		kICIFPJACNF_.WriteTo(ref output, _repeated_kICIFPJACNF_codec);
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
		num += kICIFPJACNF_.CalculateSize(_repeated_kICIFPJACNF_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpaceZooDeleteCatCsReq other)
	{
		if (other != null)
		{
			kICIFPJACNF_.Add(other.kICIFPJACNF_);
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
			if (num != 16 && num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				kICIFPJACNF_.AddEntriesFrom(ref input, _repeated_kICIFPJACNF_codec);
			}
		}
	}
}
