using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ILOGJILOJGB : IMessage<ILOGJILOJGB>, IMessage, IEquatable<ILOGJILOJGB>, IDeepCloneable<ILOGJILOJGB>, IBufferMessage
{
	private static readonly MessageParser<ILOGJILOJGB> _parser = new MessageParser<ILOGJILOJGB>(() => new ILOGJILOJGB());

	private UnknownFieldSet _unknownFields;

	public const int DKMFALAILPCFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_dKMFALAILPC_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> dKMFALAILPC_ = new RepeatedField<uint>();

	public const int BOHBBNIBFKLFieldNumber = 2;

	private static readonly MapField<uint, uint>.Codec _map_bOHBBNIBFKL_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 18u);

	private readonly MapField<uint, uint> bOHBBNIBFKL_ = new MapField<uint, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ILOGJILOJGB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ILOGJILOJGBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DKMFALAILPC => dKMFALAILPC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> BOHBBNIBFKL => bOHBBNIBFKL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILOGJILOJGB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILOGJILOJGB(ILOGJILOJGB other)
		: this()
	{
		dKMFALAILPC_ = other.dKMFALAILPC_.Clone();
		bOHBBNIBFKL_ = other.bOHBBNIBFKL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILOGJILOJGB Clone()
	{
		return new ILOGJILOJGB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ILOGJILOJGB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ILOGJILOJGB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dKMFALAILPC_.Equals(other.dKMFALAILPC_))
		{
			return false;
		}
		if (!BOHBBNIBFKL.Equals(other.BOHBBNIBFKL))
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
		num ^= dKMFALAILPC_.GetHashCode();
		num ^= BOHBBNIBFKL.GetHashCode();
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
		dKMFALAILPC_.WriteTo(ref output, _repeated_dKMFALAILPC_codec);
		bOHBBNIBFKL_.WriteTo(ref output, _map_bOHBBNIBFKL_codec);
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
		num += dKMFALAILPC_.CalculateSize(_repeated_dKMFALAILPC_codec);
		num += bOHBBNIBFKL_.CalculateSize(_map_bOHBBNIBFKL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ILOGJILOJGB other)
	{
		if (other != null)
		{
			dKMFALAILPC_.Add(other.dKMFALAILPC_);
			bOHBBNIBFKL_.MergeFrom(other.bOHBBNIBFKL_);
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
				dKMFALAILPC_.AddEntriesFrom(ref input, _repeated_dKMFALAILPC_codec);
				break;
			case 18u:
				bOHBBNIBFKL_.AddEntriesFrom(ref input, _map_bOHBBNIBFKL_codec);
				break;
			}
		}
	}
}
