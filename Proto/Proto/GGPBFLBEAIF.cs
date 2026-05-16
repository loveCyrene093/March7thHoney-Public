using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GGPBFLBEAIF : IMessage<GGPBFLBEAIF>, IMessage, IEquatable<GGPBFLBEAIF>, IDeepCloneable<GGPBFLBEAIF>, IBufferMessage
{
	private static readonly MessageParser<GGPBFLBEAIF> _parser = new MessageParser<GGPBFLBEAIF>(() => new GGPBFLBEAIF());

	private UnknownFieldSet _unknownFields;

	public const int PNFGGBPECNDFieldNumber = 1;

	private static readonly FieldCodec<BHDDKILAJCJ> _repeated_pNFGGBPECND_codec = FieldCodec.ForMessage(10u, BHDDKILAJCJ.Parser);

	private readonly RepeatedField<BHDDKILAJCJ> pNFGGBPECND_ = new RepeatedField<BHDDKILAJCJ>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GGPBFLBEAIF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GGPBFLBEAIFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BHDDKILAJCJ> PNFGGBPECND => pNFGGBPECND_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GGPBFLBEAIF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GGPBFLBEAIF(GGPBFLBEAIF other)
		: this()
	{
		pNFGGBPECND_ = other.pNFGGBPECND_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GGPBFLBEAIF Clone()
	{
		return new GGPBFLBEAIF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GGPBFLBEAIF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GGPBFLBEAIF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pNFGGBPECND_.Equals(other.pNFGGBPECND_))
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
		num ^= pNFGGBPECND_.GetHashCode();
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
		pNFGGBPECND_.WriteTo(ref output, _repeated_pNFGGBPECND_codec);
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
		num += pNFGGBPECND_.CalculateSize(_repeated_pNFGGBPECND_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GGPBFLBEAIF other)
	{
		if (other != null)
		{
			pNFGGBPECND_.Add(other.pNFGGBPECND_);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				pNFGGBPECND_.AddEntriesFrom(ref input, _repeated_pNFGGBPECND_codec);
			}
		}
	}
}
