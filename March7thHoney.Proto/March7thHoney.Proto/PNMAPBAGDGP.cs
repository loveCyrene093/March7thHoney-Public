using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PNMAPBAGDGP : IMessage<PNMAPBAGDGP>, IMessage, IEquatable<PNMAPBAGDGP>, IDeepCloneable<PNMAPBAGDGP>, IBufferMessage
{
	private static readonly MessageParser<PNMAPBAGDGP> _parser = new MessageParser<PNMAPBAGDGP>(() => new PNMAPBAGDGP());

	private UnknownFieldSet _unknownFields;

	public const int HNGMHPFNBGCFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_hNGMHPFNBGC_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> hNGMHPFNBGC_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PNMAPBAGDGP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PNMAPBAGDGPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HNGMHPFNBGC => hNGMHPFNBGC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNMAPBAGDGP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNMAPBAGDGP(PNMAPBAGDGP other)
		: this()
	{
		hNGMHPFNBGC_ = other.hNGMHPFNBGC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNMAPBAGDGP Clone()
	{
		return new PNMAPBAGDGP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PNMAPBAGDGP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PNMAPBAGDGP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hNGMHPFNBGC_.Equals(other.hNGMHPFNBGC_))
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
		num ^= hNGMHPFNBGC_.GetHashCode();
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
		hNGMHPFNBGC_.WriteTo(ref output, _repeated_hNGMHPFNBGC_codec);
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
		num += hNGMHPFNBGC_.CalculateSize(_repeated_hNGMHPFNBGC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PNMAPBAGDGP other)
	{
		if (other != null)
		{
			hNGMHPFNBGC_.Add(other.hNGMHPFNBGC_);
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
			if (num != 40 && num != 42)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				hNGMHPFNBGC_.AddEntriesFrom(ref input, _repeated_hNGMHPFNBGC_codec);
			}
		}
	}
}
